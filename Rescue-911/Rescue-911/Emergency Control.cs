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
    public partial class Emergency_Control : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        public int selectedIndex;

        //Composite Data
        private Special_List<Emergency_Call> EmergencyCalls;
        private Emergency_Call Current_Call;
        private Emergency Current_Emergency = new Emergency();

        //Event Handlers
        public event EventHandler EmergencySelected;
        public event EventHandler Emergency_Added;
        //


        //Public Data
        private string availableSegments = "f/f/f/f";
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
        public Emergency_Control()
        {
            InitializeComponent();
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Enabled = false;
        }
        //

        // SETs & GETs
        //To set up Add segment
        public void Setup_Control(ref Special_List<Emergency_Call> xCalls, ref Emergency_Call xEC)
        {
            EmergencyCalls = xCalls;
            Current_Call = xEC;

            Current_Emergency = new Emergency();

            // Generating a unique Emergency ID
            int tempID = 0;
            for (int a = 0; a < EmergencyCalls.Count; a++)
            {
                if (EmergencyCalls[a].GetEmergency().GetEmergency_ID() >= tempID)
                {

                    tempID = xCalls[a].GetEmergency().GetEmergency_ID();
                }

            }
            Current_Emergency.SetEmergency_ID(tempID + 1);

            txtEmergencyID.Text = Current_Emergency.GetEmergency_ID().ToString();
            callControlView.Setup_Control(Current_Call, "Overview", 0);

            // Setting the view segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + 0;
            btnTemp.Text = "Add";
            Change_Segment(btnTemp, null);
        }

        //To set up List segment
        public void Setup_Control(ref Special_List<Emergency_Call> xExistingCalls, string xState = "Logged", bool xStateCanChange = false)
        {
            // Setting up the values
            EmergencyCalls = xExistingCalls;
            EmergencyCalls.ItemAdded += new EventHandler(lstEmergencies_CallUpdateEvent);

            // Setting up the interface
            cmbState.Items.AddRange(new object[] {
            "Logged",
            "Waiting",
            "Accepted",
            "Actioned",
            "Declined"});
            cmbState.Enabled = xStateCanChange;
            cmbState.SelectedItem = xState;
            lstEmergencies.Columns[0].Width = 80;
            lstEmergencies.Columns[1].Width = 80;
            lstEmergencies.Columns[2].Width = 80;
            lstEmergencies.Columns[3].Width = 80;
            lstEmergencies.Columns[4].Width = 80;
            lstEmergencies.Columns[5].Width = lstEmergencies.Width - 80 * 5 - (int)(SystemInformation.VerticalScrollBarWidth * 1.5);
            lstEmergencies.Height = lstEmergencies.Font.Height * 25;

            // Setting the view segment
            Button btnTemp = new Button();
            btnTemp.Name = "btnSegment" + 3;
            btnTemp.Text = "List";
            Change_Segment(btnTemp, null);
        }
        //


        // FUNCTIONAL METHODS
        // Algorithm for showing and hiding different elements based on the selected segment
        private void Change_Segment(object sender, EventArgs e)
        {
            this.SizeChanged -= new EventHandler(this_SizeChanged);

            if (((Button)sender).Text == "Add")
            {
                SetSegment_Add(ref Current_Emergency);
            }
            else if (((Button)sender).Text == "Edit")
            {
               // SetSegment_Edit(ref Current_Call);
            }
            else if (((Button)sender).Text == "View")
            {
                if (Current_Call == null)
                {
                    lbWarning.Visible = true;
                    return;
                }

                SetSegment_View(ref Current_Call);
            }
            else if (((Button)sender).Text == "List")
            {
                SetSegment_List(ref EmergencyCalls);

                this.SizeChanged += new EventHandler(this_SizeChanged);
            }

            segmentMain.SetActiveSegment(((Button)sender).Name);
        }

        private void SetSegment_Add(ref Emergency xEmergency)
        {
            EnabledControls(true);
            PopulateFields(xEmergency);

            pnlSpecs.Visible = true;
            pnlAddEmergencyBtn.Visible = true;

            pnlRelatedData.Visible = true;
            cboEmergencyType.Focus();
        }

        private void SetSegment_View(ref Emergency_Call xCall)
        {
            EnabledControls(false);

            PopulateFields(xCall.GetEmergency());
            callControlView.Setup_Control(xCall, "Overview", 0);

            pnlSpecs.Visible = true;
            pnlRelatedData.Visible = true;
        }

        private void SetSegment_List(ref Special_List<Emergency_Call> xEmergencies)
        {
            EnabledControls(false);
            panelList.Enabled = true;
            pnlParameters.Enabled = true;

            pnlParameters.Visible = true;
            panelList.Visible = true;
            listEmergenciesPopulate(cboEmergencyType.SelectedText, xEmergencies);
        }

        private void PopulateFields(Emergency xEmergency)
        {
            txtEmergencyID.Text = xEmergency.GetEmergency_ID().ToString();

            if (xEmergency.GetEType() != string.Empty)
                cboEmergencyType.SelectedItem = xEmergency.GetEType();
        }

        public void EnabledControls(bool xEnable = false)
        {
            pnlParameters.Visible = false;
            pnlSpecs.Visible = false;
            pnlRelatedData.Visible = false;
            panelList.Visible = false;
            lbWarning.Visible = false;

            if (xEnable == false)
            {
                cboEmergencyType.DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                cboEmergencyType.DropDownStyle = ComboBoxStyle.DropDownList; 
            }

            cboEmergencyType.Enabled = xEnable;
        }
        //

        //List segment Functions
        private void listEmergenciesPopulate(string state, List<Emergency_Call> ExistingCalls)
        {

            lstEmergencies.Items.Clear();

            foreach (Emergency_Call iEC in ExistingCalls)
            {
                // Adding the events for initial calls
                lstEmergencies_CallUpdateEvent(iEC, null);
            }
        }

        private ListViewItem lstItemFetch(Emergency_Call xCall)
        {
            ListViewItem lstItem = new ListViewItem(xCall.GetEmergency().GetEmergency_ID().ToString());

            lstItem.SubItems.Add(xCall.GetEmergency().GetEType());
            lstItem.SubItems.Add(xCall.GetTeams_Required().ToString());
            lstItem.SubItems.Add(xCall.GetPriorityString());
            lstItem.SubItems.Add(xCall.GetState());
            lstItem.SubItems.Add(xCall.GetDescription());
            lstItem.Tag = xCall;

            return lstItem;
        }

        private void lstEmergencies_CallUpdateEvent(object sender, EventArgs e)
        {
            ((Emergency_Call)sender).Call_Updated -= new EventHandler(lstEmergencies_Update);
            ((Emergency_Call)sender).Call_Updated += new EventHandler(lstEmergencies_Update);

            if (((Emergency_Call)sender).GetState() != (string)cmbState.SelectedItem)
                return;

            lstEmergencies.Items.Add(lstItemFetch((Emergency_Call)sender));
        }

        private void lstEmergencies_Update(object sender, EventArgs e)
        {
            int index = -1;

            // Find the changed item in the list by checking the PK of the updated item.
            for (int i = 0; i < lstEmergencies.Items.Count; i++)
            {
                if (((Emergency_Call)(lstEmergencies.Items[i].Tag)).GetDateTime() == ((Emergency_Call)sender).GetDateTime() && ((Emergency_Call)(lstEmergencies.Items[i].Tag)).GetEmergency_Caller().GetPhone_Number() == ((Emergency_Call)sender).GetEmergency_Caller().GetPhone_Number())
                {
                    index = i;

                    break;
                }
            }

            // Check the state of the updated item with the current condition of the list
            if (((Emergency_Call)sender).GetState() != (string)cmbState.SelectedItem)
            {
                // Was it found in the list?
                if (index != -1)
                {
                    // Remove it
                    lstEmergencies.Items[index].Remove();
                    return;
                }
                else
                    return;
            }

            // We know that it corresponds to the condition of the list
            ListViewItem lstItem = lstItemFetch((Emergency_Call)sender);

            // Was it found?
            if (index == -1)
            {
                // if no, add it
                lstEmergencies.Items.Add(lstItem);
            }
            else
            {
                // if yes, replace it
                lstEmergencies.Items[index] = lstItem;
            }
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = lstEmergencies.SelectedIndices[0];
                Current_Call = (Emergency_Call)lstEmergencies.SelectedItems[0].Tag;

                EmergencySelected?.Invoke(lstEmergencies.SelectedItems[0].Tag, e);
            }
            catch
            {
                selectedIndex = -1;

                Current_Call = null;
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, EmergencyCalls);
        }

        private void this_SizeChanged(object sender, EventArgs e)
        {
            lstEmergencies.Columns[5].Width = lstEmergencies.Width - 80 * 5 - SystemInformation.VerticalScrollBarWidth;
        }

        private void btnAddEmer_Click(object sender, EventArgs e)
        {
            if (cboEmergencyType.SelectedItem == null)
            {
                cboEmergencyType.Focus();
                return;
            }

            Current_Call.SetEmergency(Current_Emergency);
            Current_Call.SetState("Logged");

            Emergency_Added?.Invoke(Current_Call, e);
        }

        private void cboEmergencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Current_Emergency.SetEType((string)cboEmergencyType.SelectedItem);
            }
            catch
            {
                Current_Emergency.SetEType("");
            }
        }
        //
    }
}
