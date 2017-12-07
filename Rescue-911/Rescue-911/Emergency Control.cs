﻿using System;
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
        private Special_List<Emergency> Emergencies;
        private Emergency_Call Current_Call;
        private Emergency Current_Emergency = new Emergency();

        //Event Handlers
        public event EventHandler EmergencySelected;
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
        }
        //


        // FUNCTIONAL METHODS
        // Algorithm for showing and hiding different elements based on the selected segment
        private void Change_Segment(object sender, EventArgs e)
        {
            segmentMain.SetActiveSegment(((Button)sender).Name);

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
              //  SetSegment_View(Current_Call);
            }
            else if (((Button)sender).Text == "List")
            {

            }
        }

        private void SetSegment_Add(ref Emergency xEmergency)
        {
            EnabledControls(true);
            //pnlEmergencyBtns.Enabled = true;
            //pnlEmergencyBtns.Visible = true;

            PopulateFields(xEmergency);

            cboEmergencyType.Focus();

            panelAdd.Visible = true;
        }

        private void PopulateFields(Emergency xEmergency)
        {
            txtEmergencyID.Text = xEmergency.GetEmergency_ID().ToString();

            if (xEmergency.GetEType() != string.Empty)
                cboEmergencyType.SelectedItem = xEmergency.GetEType();
        }

        public void EnabledControls(bool xEnable = false)
        {
            if (xEnable == false)
            {
                cboEmergencyType.DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                cboEmergencyType.DropDownStyle = ComboBoxStyle.DropDownList; 
            }

            cboEmergencyType.Enabled = xEnable;

            pnlParameters.Visible = false;
            pnlParameters.Enabled = false;
           // pnlUpdateBtn.Visible = false;
           // pnlUpdateBtn.Enabled = false;

            panelList.Visible = false;
            panelList.Enabled = false;

            panelAdd.Visible = xEnable;
            panelAdd.Enabled = xEnable;
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

                EmergencySelected?.Invoke(lstEmergencies.SelectedItems[0].Tag, e);
            }
            catch
            {
                selectedIndex = -1;
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, EmergencyCalls);
        }

        private void pnlList_SizeChanged(object sender, EventArgs e)
        {
            lstEmergencies.Columns[5].Width = lstEmergencies.Width - 80 * 5 - SystemInformation.VerticalScrollBarWidth;
        }
        //
    }
}