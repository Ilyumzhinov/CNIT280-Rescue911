using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace Rescue_911
{
    public partial class Form1 : Form
    {
        public Shared_Data SD;

        public Form1(Shared_Data xSD, List<Type> xAcccessibleForms)
        {
            InitializeComponent();

            SD = xSD;
            SD.OpenForms[2, 0] = this;

            //JUST FOR NOW, the context:
            //   lbContext.Text += "User: " + SD.ResponseTeams[0].GetID() + " ";

            for (int i = 0; i < xAcccessibleForms.Count; i++)
            {
                Form instance = (General_Form)(Activator.CreateInstance(xAcccessibleForms[i], new object[] {  SD }));

              //  Form RCF = ;
                Button b = new Button();
                b.Size = new System.Drawing.Size(100, 50);
                //   b.Location = new System.Drawing.Point(0, 0);
                b.Text = instance.Text;

                b.Click += (sender, e) =>
                {
                    instance.Show();
                };
                layoutPanel.Controls.Add(b);
            }
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
                    SD.OpenForms[0, i] = new Emergency_Management_Form(ref SD);
                    SD.OpenForms[0, i].Show();
                    break;
                }
            }
        }

        private void btnReceiveCall_Click(object sender, EventArgs e)
        {
           
            if (SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)] == null)
            {
                // CHANGE HARDCODED PART
                SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)] = new Receive_Call_Form(ref SD);
            }
            SD.OpenForms[1, (SD.ResponseTeams[0].GetID() - 1)].Show();
        }

        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void emtlogformbuttom_Click(object sender, EventArgs e)
        {
            EMT_login_shift emtlogform = new EMT_login_shift(SD);
            emtlogform.Show();
        }

        private void btnBSRecord_Click(object sender, EventArgs e)
        {
            Base_Station_Records BSR = new Base_Station_Records();
            BSR.Show();
        }

        private void btnDispatchTimes_Click(object sender, EventArgs e)
        {
            Dispatch_Related_Times DRT = new Dispatch_Related_Times(ref SD);
            DRT.Show();
        }

        private void btnDispatchReport_Click(object sender, EventArgs e)
        {
            Dispatch_Report DR = new Dispatch_Report(ref SD);
            DR.Show();
        }

    
        private void buttonpatient_Click(object sender, EventArgs e)
        {
            Patient patientinformation = new Patient();
            patientinformation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linkepatientandsub sb = new Linkepatientandsub(SD);
            sb.Show();
        }
    }
}
