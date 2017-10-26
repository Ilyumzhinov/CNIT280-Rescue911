using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Form : Form
    {
        private Shared_Data SD;
        private Emergency_Call Current_Call;

        public Emergency_Form(ref Shared_Data xSD, Emergency_Call xEC)
        {
            SD = xSD;

            Current_Call = xEC;

            InitializeComponent();
        }
       
        private void btnCreateEmergency_Click(object sender, EventArgs e)
        {

            

        }

     
        private void btnCreateEmergency1_Click(object sender, EventArgs e)
        {
            Current_Call.SetState("ready");
            Emergency Emergencies = new Emergency();
            Emergencies.SetEmergency_ID(11112);
            btnCreateEmergency1.Visible = true;


            lbTitle.Text = "Creat a Emergency Record";

            lbemergencyid.Visible = true;
            lbemergencylocation.Visible = true;
            lvemergencydecreption.Visible = true;

            lbemergencystats.Visible = true;
            txtemergencyd.Visible = true;
            lbel.Visible = true;
            lbemergencyid1.Visible = true;

            lbes.Visible = true;

            lbes.Text = Current_Call.GetTeams_Required().ToString();
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = Emergencies.GetEmergency_ID().ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
