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
                segmented_Control1.SetAvailableSegments(AvailableSegments);
                segmented_Control1.SegmentBtn_Click -= new EventHandler(Change_Segment);
                segmented_Control1.SegmentBtn_Click += new EventHandler(Change_Segment);
            }
        }
        //


        // CONSTRUCTOR
        public Call_Control()
        {
            InitializeComponent();
        }
        //

        
        // SETs & GETs
        public void Setup_Control(ref Special_List<Emergency_Call> xECs, ref Special_List<Caller> xCallers, int initialSegment)
        {
            EmergencyCalls = xECs;
            Callers = xCallers;

            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.SetState("Not Logged");

            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy");

            txtPhoneNumber.Focus();

            // To set default segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + initialSegment;
            Change_Segment(btnTemp, null);
        }

        public void SetOperator_ID(int xOperator_ID) { Current_Operator_ID = xOperator_ID; }
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
            segmented_Control1.SetActiveSegment(((Button)sender).Name);

            if (((Button)sender).Text == "Add")
            {
                panelAdd.Visible = true;
                // panelView.Visible = false;
                // panelAdd.Visible = true;
            }
            else if (((Button)sender).Text == "Edit")
            {
                // panelEdit.Visible = false;
                //  panelView.Visible = false;
                panelAdd.Visible = false;
            }
            else if (((Button)sender).Text == "View")
            {
                panelAdd.Visible = false;
                //  panelEdit.Visible = false;
                //  panelView.Visible = true;
            }
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

        public Emergency_Call GetCall()
        {
            return Current_Call;
        }
    }
}