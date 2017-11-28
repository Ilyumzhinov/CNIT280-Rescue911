using System;
using System.Drawing;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Response_Team_Information_View : Special_View
    {
        private Response_Team Current_RT;
        private Emergency_Call mSelectedCall;

        // CONSTRUCTORS
        //To-display the view.
        public Response_Team_Information_View(ref Shared_Data xSD) : base(ref xSD, "Response Team Info", false, Color.SandyBrown)
        {
            InitializeComponent();

            // Setting up the View
            emergencyList.Enabled = false;
            rbYes.Enabled = false;
            rbNo.Enabled = false;

            lbRT_ID.Text = "NOT SET";
        }

        //To-instantiate the view.
        public Response_Team_Information_View() : base("Response Team Info", false, Color.SandyBrown)
        { }
        //

        // FUNCTIONAL METHODS
        public void SetContext(Response_Team xRT)
        {
            Current_RT = xRT;

            lbRT_ID.Text = Current_RT.GetID().ToString();

            // Emergency list set-up.
            if (SD.GetEmergencies()[0] != null)
            {
                Response_Team_Information_View_SizeChanged(this, null);
                emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                Special_List<Emergency_Call> tempECs = (Special_List<Emergency_Call>)SD.GetCalls();
                emergencyList.SetEmergency_List(ref tempECs, "Waiting", true);
            }
        }


        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            mSelectedCall = (Emergency_Call)sender;
        }

        // If a team approves an emergency.
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Actioned");
        }

        // If a team rejects an emergency.
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Declined");
        }

        private void Response_Team_Information_View_SizeChanged(object sender, EventArgs e)
        {
            emergencyList.Width = this.Width;
        }
    }
}
