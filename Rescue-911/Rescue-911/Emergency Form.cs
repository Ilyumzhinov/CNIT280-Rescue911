using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Form : Form
    {
        private Shared_Data SD;
        private Emergency_Call Current_Call;
        private int enmergency_ID;
        private int Calls_ID;
        private Emergency E = new Emergency();
        public Emergency_Form(ref Shared_Data xSD, Emergency_Call xEC)
        {
            SD = xSD;

            Current_Call = xEC;

            InitializeComponent();


           
        }
       
        

     
        

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void Emergency_Form_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < SD.Emergencies.Length; a++) {
                if (null == SD.Emergencies[a]) {
                    enmergency_ID = a;
                    break;
                }
            }
            for (int a = 0; a < SD.Calls.Length; a++)
            {
                if (null == SD.Calls[a])
                {
                    Calls_ID = a;
                    break;
                }
            }
            Current_Call.SetState("ready");
            Emergency_Call[] ECalls = new Emergency_Call[1000];
            ECalls[0] = SD.Calls[Calls_ID-1];

            E.SetEmergency_ID(enmergency_ID);
            E.SetLinked_Calls(ECalls);
        

            lbes.Text = Current_Call.GetTeams_Required().ToString();
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = E.GetEmergency_ID().ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();
            
        }
        private void btnCreateEmergency1_Click(object sender, EventArgs e)
        {

            SD.Emergencies[enmergency_ID] = E;
            ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);
            this.Close();
        }
    }
}
