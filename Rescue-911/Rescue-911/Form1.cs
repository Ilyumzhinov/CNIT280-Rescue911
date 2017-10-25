using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Form1 : Form
    {
        public Shared_Data SD;

        public Form1()
        {
            InitializeComponent();

            SD = new Shared_Data();
            SD.OpenForms[2, 0] = this;

            //JUST FOR NOW, the context:
            lbContext.Text += "User: " + SD.ResponseTeams[0] + " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallForm CallForm = new CallForm(ref SD);

            CallForm.Show();
        }

        private void btnWaitingCall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                if (SD.OpenForms[0, i] == null)
                {
                    SD.OpenForms[0, i] = new Call_Waiting_Form(ref SD);
                    SD.OpenForms[0, i].Show();
                    break;
                }
            }
        }

        private void btnReceiveCall_Click(object sender, EventArgs e)
        {
           
            if (SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)] == null)
            {
                SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)] = new Receive_Call_Form(SD.ResponseTeams[0], ref SD);
            }
            SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)].Show();
        }

        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }
    }
}
