using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;


namespace Rescue_911
{
    public partial class Emergency_Add_View : Special_View
    {
        private Emergency_Call Current_Call;
        private Emergency E = new Emergency();

        public Emergency_Add_View(ref Shared_Data xSD, Emergency_Call xEC) : base(ref xSD, "Add Emergency", false, Color.GreenYellow)
        {
            Current_Call = xEC;
            InitializeComponent();
        }

        private void Emergency_Form_Load(object sender, EventArgs e)
        {

            E.SetEmergency_ID(SD.Emergencies.Capacity - 1);
            E.AddLinked_Call(Current_Call);
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = E.GetEmergency_ID().ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();

        }
        private void btnCreateEmergency1_Click(object sender, EventArgs e)
        {

            SD.Emergencies.Add(E);
            SD.UpdateSD(ref SD);
        }
    }
}
