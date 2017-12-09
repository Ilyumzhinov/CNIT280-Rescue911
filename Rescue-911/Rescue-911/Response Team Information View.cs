using System;
using System.Drawing;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Response_Team_Information_View : Special_View, IUserDependent
    {
        private Response_Team Current_RT;
        private Emergency_Call mSelectedCall;
        private Special_List<Emergency> Emergencies;
        private Special_List<Emergency_Call> Calls;
        private Special_List<Dispatch> Dispatches;
       

        // CONSTRUCTORS
        //To-setup the view.
        public Response_Team_Information_View(bool toDisplay, ref Special_List<Emergency_Call> xCalls, ref Special_List<Emergency> xEmergencies, Special_List<Dispatch> xDispatches) : this(toDisplay)
        {
            Calls = xCalls;
            Emergencies = xEmergencies;
            Dispatches = xDispatches;
        }

        //To-display the view.
        public Response_Team_Information_View(bool toDisplay) : base(toDisplay, false)
        {
            InitializeComponent();
        }
        //

        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is EMT)
            {
                Current_RT = ((EMT)xPerson).GetResponseTeam();

                lbRT_ID.Text = Current_RT.GetID().ToString();

                for (int a = 0; a < Dispatches.Count; a++) {


                    if (Dispatches[a].getStatus() == "Waiting For Dispatch" && Dispatches[a].GetResponseTeam().GetID()== Current_RT.GetID()) {
                        rbYes.Enabled = true;
                        rbNo.Enabled = true;

                    }
                }
               
                // Emergency list set-up.
                if (Emergencies[0] != null)
                {
                    Response_Team_Information_View_SizeChanged(this, null);
                    emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                    emergencyList.SetEmergency_List(ref Calls, "Waiting", true);
                }
            } else
            {
                // Setting up the View
                emergencyList.Enabled = false;
                rbYes.Enabled = false;
                rbNo.Enabled = false;

                lbRT_ID.Text = "NOT SET";

                SendStatusUpdate(true, "To access, you must have EMT access level!", "urgent");
            }
        }
        
        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            mSelectedCall = (Emergency_Call)sender;
        }

        // If a team approves an emergency.
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Accepted");
            
            for (int a = 0; a < Dispatches.Count; a ++) {

                if (Dispatches[a].GetEmergency() == mSelectedCall.GetEmergency())
                    Dispatches[a].GetResponseTeam().SetStatusByDispatch("Dispatched");
                    Dispatches[a].SetStatus("Dispatched");
            }
            
        }

        // If a team rejects an emergency.
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            mSelectedCall.SetState("Declined");
            for (int a = 0; a < Dispatches.Count; a ++)
            {

                if (Dispatches[a].GetEmergency() == mSelectedCall.GetEmergency())
                    Dispatches[a].SetStatus("Declined");

            }
        }

        private void Response_Team_Information_View_SizeChanged(object sender, EventArgs e)
        {
            emergencyList.Width = this.Width;
        }
    }
}
