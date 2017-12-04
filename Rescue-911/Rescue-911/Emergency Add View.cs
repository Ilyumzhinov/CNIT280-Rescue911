using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;


namespace Rescue_911
{
    public partial class Emergency_Add_View : Special_View, IUserDependent
    {
        private Special_List<Emergency_Call> Calls;
        private Emergency_Call Current_Call;
        private Emergency Emer = new Emergency();
        private int temp = 0;
        
        public Emergency_Add_View(bool toDisplay,ref Special_List<Emergency_Call> xCalls,ref Emergency_Call xEC) : this(toDisplay)
        {
            Calls = xCalls;
            Current_Call = xEC;
        
            
            for (int a = 0; a < xCalls.Count; a++) {
                if (xCalls[a].GetEmergency().GetEmergency_ID() >= temp) {

                    temp = xCalls[a].GetEmergency().GetEmergency_ID();
                }
                
            }
            Emer.SetEType("broken bones");
            Emer.SetEmergency_ID(temp + 1);
            Current_Call.SetEmergency(Emer);
            // Change taht
            
           
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = (temp + 1).ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();
           
        }
        
        public Emergency_Add_View(bool toDisplay) : base(toDisplay, "Add Emergency", Color.GreenYellow)
        {
            if (toDisplay)
                InitializeComponent();
        }

        public void SendUser(Person xUser) {
            if (xUser is Operator == false)
            {
                btnCreateEmergency1.Enabled = false;
                SendStatusUpdate(true, "To access, you must have Operator access level!", "urgent");
            }
            else return;
           
        }

    
     
        public void btnCreateEmergency1_Click(object sender, EventArgs e)
        {
           
            lbes.Text = "Logged";
            Current_Call.SetState("Logged");
            SendStatusUpdate(true, "Emergency Add Success", "urgent");



        }

        
    }
}
