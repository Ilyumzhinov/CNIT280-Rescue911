using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Call_Control : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        private int Current_Operator_ID;

        //Composite Data
        private Special_List<Emergency_Call> EmergencyCalls;
        private Special_List<Caller> Callers;
        private Emergency_Call Current_Call;

        //Events
        public event EventHandler LinkEmergencyButton_Click;
        public event EventHandler AddEmergencyButton_Click;

        //Public Data
        private string availableSegments = "f/f/f";
        [Description("Set access to segments. Use 't' for granting the access to a view or 'f' to block it. Use / to separate elements"), Category("Data")]
        public string AvailableSegments
        {
            get
            {
                return availableSegments;
            }
            set
            {
                availableSegments = value;
                segmentMain.SetAvailableSegments(AvailableSegments);
                segmentMain.SegmentBtn_Click -= new EventHandler(Change_Segment);
                segmentMain.SegmentBtn_Click += new EventHandler(Change_Segment);
            }
        }
        //


        // CONSTRUCTOR
        public Call_Control()
        {
            InitializeComponent();

            // Setting local View segment Control
            segmentView.SetAvailableSegments("t/t");
            segmentView.SegmentBtn_Click -= new EventHandler(Change_ViewSegment);
            segmentView.SegmentBtn_Click += new EventHandler(Change_ViewSegment);
        }
        //


        // SETs & GETs
        // To set up any of the Views
        public void Setup_Control(ref Special_List<Emergency_Call> xECs, ref Special_List<Caller> xCallers, int initialSegment)
        {
            // Setting up global data
            EmergencyCalls = xECs;
            Callers = xCallers;

            // Setting up local data
            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);
            Current_Call.SetState("Not Logged");
            Current_Call.SetTeams_Required(1);
            //

            // Setting the default segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + initialSegment;
            //To-Do: change this
            btnTemp.Text = "Add";
            Change_Segment(btnTemp, null);
        }

        //To set up View segment only
        public void Setup_Control(Emergency_Call xCall, string intialViewLabel, int intialViewSegmentIndex)
        {
            Current_Call = xCall;

            // Setting the default segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + 2;
            btnTemp.Text = "View";
            Change_Segment(btnTemp, null);
            //

            // Setting the view segment
            btnTemp.Name = "btnSegment" + intialViewSegmentIndex;
            btnTemp.Text = intialViewLabel;
            Change_ViewSegment(btnTemp, null);
        }

        public void SetOperator_ID(int xOperator_ID) { Current_Operator_ID = xOperator_ID; }
        public Emergency_Call GetCall()
        {
            return Current_Call;
        }
        //


        // FUNCTIONAL METHODS
        private bool CheckFields()
        {
            // Existence checks
            if (Current_Call.GetPriority() == 0)
            {
                cboCallPriority.Focus();
                return false;
            }
            else if (Current_Call.GetEmergency_Caller().GetPhone_Number() == null)
            {
                txtPhoneNumber.Focus();
                return false;
            }
            else if (Current_Call.GetEmergency_Caller().GetName() == null)
            {
                txtCallerName.Focus();
                return false;
            }
            else if (Current_Call.GetAddress() == null)
            {
                txtAddress.Focus();
                return false;
            }
            else if (Current_Call.GetDescription() == null)
            {
                txtDescription.Focus();
                return false;
            }
            else
            {
                // All checks are satisfied
                Current_Call.SetTeams_Required((int)numTeams.Value);

                Current_Call.SetLandmark(txtLandmark.Text);

                Current_Call.SetLink_Operator_ID(Current_Operator_ID);

                //Update the Shared Data values regarding the Calls.
                EmergencyCalls.AddItem(Current_Call);

                return true;
            }
        }

        // Algorithm for showing and hiding different elements based on the selected segment
        private void Change_Segment(object sender, EventArgs e)
        {
            segmentMain.SetActiveSegment(((Button)sender).Name);

            if (((Button)sender).Text == "Add")
            {
                SetSegment_Add(ref Current_Call);
            }
            else if (((Button)sender).Text == "Edit")
            {
                SetSegment_Edit(ref Current_Call);
            }
            else if (((Button)sender).Text == "View")
            {
                SetSegment_View(Current_Call);
            }
        }

        private void SetSegment_Add(ref Emergency_Call xCall)
        {
            EnableControls(true);
            pnlEmergencyBtns.Enabled = true;
            pnlEmergencyBtns.Visible = true;

            PopulateFields(xCall);

            txtPhoneNumber.Focus();

            panelAdd.Visible = true;
        }

        private void SetSegment_Edit(ref Emergency_Call xCall)
        {
            SetSegment_Add(ref xCall);
            pnlEmergencyBtns.Enabled = false;
            pnlEmergencyBtns.Visible = false;

            pnlUpdateBtn.Enabled = true;
            pnlUpdateBtn.Visible = true;
        }

        private void SetSegment_View(Emergency_Call xCall)
        {
            EnableControls(false);

            PopulateFields(xCall);

            pnlParameters.Enabled = true;
            pnlParameters.Visible = true;

            // Setting the default segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + 0;
            btnTemp.Text = "Overview";
            Change_ViewSegment(btnTemp, null);

            panelAdd.Visible = true;
        }

        // Controls changes between Overview/Detail segmentes of the View segment
        private void Change_ViewSegment(object sender, EventArgs e)
        {
            segmentView.SetActiveSegment(((Button)sender).Name);

            if (((Button)sender).Text == "Overview")
            {
                pnlCaller.Visible = false;
                pnlCaller.Enabled = false;

                pnlOtherData.Visible = false;
                pnlOtherData.Enabled = false;
            }
            else if (((Button)sender).Text == "Detail")
            {
                pnlCaller.Visible = true;
                pnlCaller.Enabled = true;

                pnlOtherData.Visible = true;
                pnlOtherData.Enabled = true;
            }
        }

        private void PopulateFields(Emergency_Call xCall)
        {
            txtCallDateTime.Text = xCall.GetDateTime().ToString("h:mm:ss MM/dd/yyyy");
            if (xCall.GetPriority() != 0)
                cboCallPriority.SelectedIndex = xCall.GetPriority() - 1;
            numTeams.Value = xCall.GetTeams_Required();

            txtAddress.Text = xCall.GetAddress();
            txtLandmark.Text = xCall.GetLandmark();
            txtDescription.Text = xCall.GetDescription();

            txtPhoneNumber.Text = xCall.GetEmergency_Caller().GetPhone_Number();
            txtCallerName.Text = xCall.GetEmergency_Caller().GetName();
        }

        public void EnableControls(bool xEnable)
        {
            if (xEnable == false)
            {
                txtCallDateTime.BorderStyle = BorderStyle.None;
                cboCallPriority.DropDownStyle = ComboBoxStyle.Simple;
                numTeams.BorderStyle = BorderStyle.None;

                txtPhoneNumber.BorderStyle = BorderStyle.None;
                txtCallerName.BorderStyle = BorderStyle.None;

                txtAddress.BorderStyle = BorderStyle.None;
                txtLandmark.BorderStyle = BorderStyle.None;
                txtDescription.BorderStyle = BorderStyle.None;
            }
            else
            {
                txtCallDateTime.BorderStyle = BorderStyle.Fixed3D;
                cboCallPriority.DropDownStyle = ComboBoxStyle.DropDownList;
                numTeams.BorderStyle = BorderStyle.Fixed3D;

                txtPhoneNumber.BorderStyle = BorderStyle.Fixed3D;
                txtCallerName.BorderStyle = BorderStyle.Fixed3D;

                txtAddress.BorderStyle = BorderStyle.Fixed3D;
                txtLandmark.BorderStyle = BorderStyle.Fixed3D;
                txtDescription.BorderStyle = BorderStyle.Fixed3D;
            }

            cboCallPriority.Enabled = xEnable;
            numTeams.ReadOnly = !xEnable;

            txtAddress.ReadOnly = !xEnable;
            txtLandmark.ReadOnly = !xEnable;
            txtDescription.ReadOnly = !xEnable;

            txtPhoneNumber.ReadOnly = !xEnable;
            txtCallerName.ReadOnly = !xEnable;


            pnlParameters.Visible = false;
            pnlParameters.Enabled = false;
            pnlEmergencyBtns.Visible = false;
            pnlEmergencyBtns.Enabled = false;
            pnlUpdateBtn.Visible = false;
            pnlUpdateBtn.Enabled = false;

            pnlCaller.Visible = true;
            pnlCaller.Enabled = xEnable;

            pnlOtherData.Visible = true;
            pnlOtherData.Enabled = xEnable;
        }
        //

        // EVENT HANDLERS
        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            LinkEmergencyButton_Click?.Invoke(this, e);
        }

        private void btnAddEmer_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            AddEmergencyButton_Click?.Invoke(this, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cboCallPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets an actual index.
            Current_Call.SetPriority(cboCallPriority.SelectedIndex + 1);
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            // Change dataType to string

            if (txtPhoneNumber.Text.Length == 10)
            {
                bool found = false;
                txtCallerName.Enabled = true;

                foreach (Caller iCaller in Callers)
                {
                    if (iCaller.GetPhone_Number() != txtPhoneNumber.Text)
                        continue;

                    if (iCaller.GetPatient() == null)
                    {
                        txtCallerName.Text = iCaller.GetName();
                    }
                    else
                    {
                        txtCallerName.Text = (iCaller.GetPatient().GetLast_Name() + " " + iCaller.GetPatient().GetName());
                    }
                    txtCallerName.Enabled = false;

                    Current_Call.SetEmergency_Caller(iCaller);

                    found = true;
                    break;
                }

                if (found == false)
                {
                    Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
                }
            }
        }

        private void txtCallerName_Leave(object sender, EventArgs e)
        {
            if (txtCallerName.Text.Trim() != string.Empty)
                Current_Call.GetEmergency_Caller().SetName(txtCallerName.Text);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() != string.Empty)
                Current_Call.SetAddress(txtAddress.Text);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() != string.Empty)
                Current_Call.SetDescription(txtDescription.Text);
        }

        private void numTeams_Leave(object sender, EventArgs e)
        {
            Current_Call.SetTeams_Required((int)numTeams.Value);
        }

        private void txtLandmark_Leave(object sender, EventArgs e)
        {
            Current_Call.SetLandmark(txtLandmark.Text);
        }
        //
    }
}