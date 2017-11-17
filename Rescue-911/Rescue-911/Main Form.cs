using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace Rescue_911
{
    public partial class Main_Form : Special_Form
    {
        public Main_Form(Shared_Data xSD, List<Type> xAcccessibleForms, Person xUserType) : base(ref xSD, "Emergency Response Information System")
        {
            InitializeComponent();

            // Setting up the form.
            // To-Do: Add dynamic ID type identification
            // To-Do: If an EMT, show a Response Team ID to which they belong.
            lbUser.Text = xUserType.GetName() + " " + xUserType.GetLast_Name();
            lbAccessLevel.Text = xUserType.GetType().ToString();

            layoutPanel.Width = (int)(250);
            layoutPanel.Left = (int)(this.Width / 2.0) - (int)(layoutPanel.Width / 2.0);

            layoutPanel.BorderStyle = BorderStyle.None;

            PopulateMenu(xAcccessibleForms);

            if (layoutPanel.Height < (this.Height - layoutPanel.Top))
            {
                layoutPanel.Top = (int)(this.Height / 2.0) - (int)(layoutPanel.Height / 2.0);
            }
        }

        // This method is used to dynamically populate the form with buttons.
        // Reference on LayoutPanel: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel#positioning-controls-using-docking-and-anchoring
        private void PopulateMenu(List<Type> xAcccessibleForms)
        {
            for (int i = 0; i < xAcccessibleForms.Count; i++)
            {
                Special_Form instance = (Special_Form)(Activator.CreateInstance(xAcccessibleForms[i], new object[] { SD }));

                Button b = new Button();
                b.Size = new System.Drawing.Size(250, 50);
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.ForeColor = System.Drawing.Color.White;
                b.Name = "btn" + i;
                b.Tag = i;
                b.TabIndex = i;
                b.Text = "Open " + instance.Text;
                // Spacing between buttons
                b.Margin = new Padding(0, 0, 0, 22);
                SetUpButton(ref b, xAcccessibleForms[i]);

                layoutPanel.Controls.Add(b);
            }
        }
        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }
        // Do the visual as well as functional button setup.
        private void SetUpButton(ref Button xBtn, Type xT)
        {
            if (xT == typeof(CallForm))
            {
                xBtn.BackColor = System.Drawing.Color.Teal;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;

                xBtn.Click += new System.EventHandler(this.btnCallLog_Click);
            }
            else if (xT == typeof(Emergency_Management_Form))
            {
                xBtn.BackColor = System.Drawing.Color.IndianRed;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;

                xBtn.Click += new System.EventHandler(this.btnWaitingCall_Click);
            }
            else if (xT == typeof(Receive_Call_Form))
            {
                xBtn.BackColor = System.Drawing.Color.SandyBrown;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;

                xBtn.Click += new System.EventHandler(this.btnReceiveCall_Click);
            }
            else if (xT == typeof(EMT_login_shift))
            {
                xBtn.BackColor = System.Drawing.Color.Black;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;

                xBtn.Click += new System.EventHandler(this.btnEMTLogin);
            }
            else if (xT == typeof(Base_Station_Records))
            {
                xBtn.BackColor = System.Drawing.Color.SteelBlue;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;

                xBtn.Click += new System.EventHandler(this.btnBSRecord_Click);
            }
            else if (xT == typeof(Dispatch_Related_Times))
            {
                xBtn.BackColor = System.Drawing.Color.MediumPurple;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;

                xBtn.Click += new System.EventHandler(this.btnDispatchTimes_Click);
            }
            else if (xT == typeof(Dispatch_Report))
            {
                xBtn.BackColor = System.Drawing.Color.PaleVioletRed;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;

                xBtn.Click += new System.EventHandler(this.btnDispatchReport_Click);
            }
            else if (xT == typeof(LinkPatient))
            {
                xBtn.BackColor = System.Drawing.Color.Peru;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Peru;

                xBtn.Click += new System.EventHandler(this.btnLinkPatient_Click);
            }
            else if (xT == typeof(Patient_Information_Form))
            {
                xBtn.BackColor = System.Drawing.Color.Orchid;
                xBtn.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;

                xBtn.Click += new System.EventHandler(this.btnPatientInto_Click);
            }

            // Another way of creating this event
            //  b.Click += (sender, e) =>
            // {
            //    instance.Show();
            // };

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEMTLogin(object sender, EventArgs e)
        {
            EMT_login_shift emtlogform = new EMT_login_shift(ref SD);
            emtlogform.Show();
        }

        private void btnBSRecord_Click(object sender, EventArgs e)
        {
            Base_Station_Records BSR = new Base_Station_Records(ref SD);
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


        private void btnPatientInto_Click(object sender, EventArgs e)
        {
            Patient_Information_Form PI = new Patient_Information_Form(ref SD);
            PI.Show();
        }

        private void btnLinkPatient_Click(object sender, EventArgs e)
        {
            LinkPatient sb = new LinkPatient(ref SD);
            sb.Show();
        }

        private void buttonpatient_Click_1(object sender, EventArgs e)
        {
            Patient_Information_Form a = new Patient_Information_Form(ref SD);
            a.Show();
        }

        private void btnCallLog_Click(object sender, EventArgs e)
        {
            CallForm CF = new CallForm(ref SD);
            CF.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SD.LoginForm.Show();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SD.LoginForm != null)
                SD.LoginForm.Close();
        }
    }
}
