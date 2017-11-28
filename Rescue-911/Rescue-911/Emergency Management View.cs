using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Management_View : Special_View
    {
        private Emergency_Call mSelectedCall;
        private Response_Team mSelectedRT;

        // CONSTRUCTORS
        //To-display the view.
        public Emergency_Management_View(ref Shared_Data xSD) : base(ref xSD, "Emergency Management", false, Color.IndianRed)
        {
            InitializeComponent();

            // Emergency list set-up.
            if (SD.GetEmergencies()[0] != null)
            {
                Emergency_Management_View_SizeChanged(this, null);
                emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                Special_List<Emergency_Call> tempECs = SD.GetCalls();
                
                emergencyList.SetEmergency_List(ref tempECs, "Logged", true);
            }
        }

        //To-instantiate the view.
        public Emergency_Management_View() : base("Emergency Management", false, Color.IndianRed)
        { }
        //

        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            lstTeams.Items.Clear();

            mSelectedCall = (Emergency_Call)sender;

            // Populating the listBox with the response teams.
            foreach (Response_Team RT in SD.GetResponseTeams())
            {
                // To-Do: get the actual emergency call selected
                if (mSelectedCall.GetPriority() <= 2)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                    lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }

                if (mSelectedCall.GetPriority() <= 3 && RT.GetGrade() > 1)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                    lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }

                if (mSelectedCall.GetPriority() <= 4 && RT.GetGrade() > 2)
                {
                    ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                    lstItem.SubItems.Add(RT.GetGrade().ToString());
                    lstItem.Tag = RT;

                    lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                    continue;
                }
            }

            lbResult.Visible = true;
            rbYes.Visible = true;
            rbNo.Visible = true;
        }

        private void btnCreateDispatch_Click(object sender, EventArgs e)
        {
            lbResult.Visible = true;
            lbResult.Text = "Request sent";
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            Dispatch xDispatch = new Dispatch();
            xDispatch.SetEmergency(mSelectedCall.GetEmergency());
            xDispatch.SetResponseTeam(mSelectedRT);

            SD.AddDispatch(xDispatch);

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
    }
}