using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Form : Special_Form
    {
        private Emergency_Call Current_Call;
        private Emergency E = new Emergency();
        public Emergency_Form(ref Shared_Data xSD, Emergency_Call xEC) : base(ref xSD, "Emergency")
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
            ((Main_Form)SD.MainForm).UpdateSD(SD);
            this.Close();
        }
    }
}
