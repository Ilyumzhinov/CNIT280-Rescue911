using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Management_View : Special_View, IUserDependent
    {
        // DATA STRUCTURE
        //Composite Data
        private Emergency_Call mSelectedCall;
        private Response_Team mSelectedRT;

        //Associations
        private Special_List<Emergency_Call> Calls;
        private Special_List<Emergency> Emergencies;
        private Special_List<Response_Team> RTs;
        //


        // CONSTRUCTORS
        //To-setup the view.
        public Emergency_Management_View(bool toDisplay, ref Special_List<Emergency_Call> xECs, ref Special_List<Emergency> xEmergencies, ref Special_List<Response_Team> xRTs) : this(toDisplay)
        {
            Calls = xECs;
            Emergencies = xEmergencies;
            RTs = new Special_List<Response_Team>();
            //RTs = xRTs;
            foreach (Response_Team RT in xRTs)
            {
                if (RT.GetTeamstatus() == "Available")
                {
                    RTs.Add(RT);
                }
            }

        }

        //To-display the view.
        public Emergency_Management_View(bool toDisplay) : base(toDisplay, "Emergency Management", Color.IndianRed)
        {
            if (toDisplay)
                InitializeComponent();
        }
        //


        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            // Emergency list set-up.

            if (xPerson is Operator || xPerson is Supervisor)
            {
                if (Emergencies[0] == null)
                    return;

                Emergency_Management_View_SizeChanged(this, null);
                emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);
                
                if (xPerson is Supervisor)
                {
                    emergencyList.SetEmergency_List(ref Calls, "Waiting", true);
                    RTList.Visible = false;
                }
                else if (xPerson is Operator)
                {
                    emergencyList.SetEmergency_List(ref Calls, "Logged", true);
                    RTList.SetResponseTeams_List(ref RTs, 1);
                }
            }
            else
            {
                // Setting up the View
                emergencyList.Enabled = false;
                RTList.Enabled = false;
                panel2.Enabled = false;

                SendStatusUpdate(true, "To access, you must have Operator or Supervisor access level!", "urgent");
            }
        }
        //


        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
           // lstTeams.Items.Clear();

            mSelectedCall = (Emergency_Call)sender;

            // Populating the listBox with the response teams.
            foreach (Response_Team RT in RTs)
            {
                // To-Do: get the actual emergency call selected
                if (mSelectedCall.GetPriority() <= 2)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                   // lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }

                if (mSelectedCall.GetPriority() <= 3 && RT.GetGrade() > 1)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                  //  lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }

                if (mSelectedCall.GetPriority() <= 4 && RT.GetGrade() > 2)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                   // lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }
            }

            btnSend.Visible = true;
            //lbDecision.Text
           // rbYes.Visible = true;
            //rbNo.Visible = true;
        }

        private void btnCreateDispatch_Click(object sender, EventArgs e)
        {
            
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            Dispatch xDispatch = new Dispatch();
            xDispatch.SetEmergency(mSelectedCall.GetEmergency());
            xDispatch.SetResponseTeam(mSelectedRT);

           // SD.AddDispatch(xDispatch);

            mSelectedCall.SetState("Accepted");
            rbYes.Checked = false;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Waiting");
            rbNo.Checked = false;
        }

        private void Emergency_Management_View_SizeChanged(object sender, EventArgs e)
        {
            emergencyList.Width = this.Width;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSelectedRT = (Response_Team)((ListView)sender).Tag;
        }

        private void lbDecision_Click(object sender, EventArgs e)
        {

        }
    }
}