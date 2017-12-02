using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;


namespace Rescue_911
{
    public partial class Emergency_Add_View : Special_View
    {
        private Special_List<Emergency_Call> Calls;
        private Emergency_Call Current_Call;
        private Emergency E = new Emergency();
       
        public Emergency_Add_View(bool toDisplay, ref Special_List<Emergency_Call> xCalls, Emergency_Call xEC) : this(toDisplay)
        {
            Calls = xCalls;
            Current_Call = xEC;

           // E.SetEmergency_ID(SD.GetEmergencies()[SD.GetEmergencies().Count - 1].GetEmergency_ID() + 1);

            // Change taht
            E.SetEType("broken bones");
            Current_Call.SetEmergency(E);
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = E.GetEmergency_ID().ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();
        }

        public Emergency_Add_View(bool toDisplay) : base(toDisplay, "Add Emergency", Color.GreenYellow)
        {
            if (toDisplay)
                InitializeComponent();
        }

     
        public void btnCreateEmergency1_Click(object sender, EventArgs e)
        {
            Current_Call.SetState("Logged");
            lbes.Text = "Logged";
            Calls.Add(Current_Call);

        }

        
    }
}
