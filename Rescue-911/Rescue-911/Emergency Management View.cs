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
        Special_List<Dispatch> dispatch;
        //


        // CONSTRUCTORS
        //To-setup the view.
        public Emergency_Management_View(bool toDisplay, ref Special_List<Emergency_Call> xECs, ref Special_List<Emergency> xEmergencies, ref Special_List<Response_Team> xRTs,ref Special_List<Dispatch> xDispatch ) : this(toDisplay)
        {
            Calls = xECs;
            Emergencies = xEmergencies;
            RTs = xRTs;
            dispatch = xDispatch;
        }

        //To-display the view.
        public Emergency_Management_View(bool toDisplay) : base(toDisplay, false)
        {
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
                emergencyControl.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);
                RTList.RTSelected += new EventHandler(lstTeams_SelectedIndexChanged);

                if (xPerson is Supervisor)
                {
                    emergencyControl.Setup_Control(ref Calls, "Waiting", true);
                    RTList.Visible = false;
                }
                else if (xPerson is Operator)
                {
                    emergencyControl.Setup_Control(ref Calls, "Logged", true);
                    RTList.SetResponseTeams_List(ref RTs, 1);
                }
            }
            else
            {
                // Setting up the View
                emergencyControl.EnabledControls(false);
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
                if (RT.GetTeamstatus() == "Available-ready") {

                    RT.SetStatusByDispatch("Available");
                }
                // To-Do: get the actual emergency call selected
                if (mSelectedCall.GetPriority() <= 2)
                {
                    if (RT.GetTeamstatus() == "Available")
                    {
                        RT.SetStatusByDispatch("Available-ready");
                    }
                   // ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                   // lstItem.SubItems.Add(RT.GetGrade().ToString());
                   // lstItem.Tag = RT;

                   //// lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                   // continue;
                }

                if (mSelectedCall.GetPriority() <= 3 && RT.GetGrade() > 1)
                {

                    if (RT.GetTeamstatus() == "Available")
                    {
                        RT.SetStatusByDispatch("Available-ready");
                    }
                    //  ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    //  lstItem.SubItems.Add(RT.GetGrade().ToString());
                    //  lstItem.Tag = RT;

                    ////  lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    //  continue;
                }

                if (mSelectedCall.GetPriority() <= 4 && RT.GetGrade() > 2)
                {
                    if (RT.GetTeamstatus() == "Available")
                    {
                        RT.SetStatusByDispatch("Available-ready");
                    }

                    // ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    // lstItem.SubItems.Add(RT.GetGrade().ToString());
                    // lstItem.Tag = RT;

                    //// lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    // continue;
                }
            }

            btnSend.Visible = true;
            //lbDecision.Text
            rbYes.Visible = true;
            rbNo.Visible = true;
        }

        private void btnCreateDispatch_Click(object sender, EventArgs e)
        {
            Dispatch xDispatch = new Dispatch();
            xDispatch.SetEmergency(mSelectedCall.GetEmergency());
            xDispatch.SetResponseTeam(mSelectedRT);
            xDispatch.SetStatus("Send");
            dispatch.Add(xDispatch);
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            
            // SD.AddDispatch(xDispatch);
           
            mSelectedCall.SetState("Accepted");
            mSelectedRT.SetStatusByDispatch("Dispatched");
            Dispatch dis = new Dispatch();
            dis.SetEmergency(mSelectedCall.GetEmergency());
            dis.SetResponseTeam(mSelectedRT);
            dis.SetStatus("Accepted");
            dispatch.AddItem(dis);
            rbYes.Checked = false;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Waiting");
            rbNo.Checked = false;
        }

        private void Emergency_Management_View_SizeChanged(object sender, EventArgs e)
        {
            //emer.Width = this.Width;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbYes.Enabled = false;
            rbNo.Enabled = false;
            mSelectedRT = (Response_Team)sender;
            if (mSelectedRT != null && mSelectedRT.GetTeamstatus() == "Available-ready") {
                rbYes.Enabled = true;
                rbNo.Enabled = true;

            }
        }
    }
}