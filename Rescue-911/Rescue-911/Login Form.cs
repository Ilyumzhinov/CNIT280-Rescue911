using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Login_Form : Form
    {
        private Shared_Data SD;

        public Login_Form()
        {
            SD = new Shared_Data();

            SD.LoginForm = this;

            InitializeComponent();
        }
        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty && txtPassword.Text.Trim() == string.Empty)
            {
                txtName.Focus();
                return;
            }

            lbName.Visible = false;
            lbPassword.Visible = false;
            string nameFound = string.Empty;

            foreach (EMT iEMT in SD.EMTs)
            {
                if (txtName.Text != iEMT.GetName())
                    continue;

                nameFound = iEMT.GetName();

                if (txtPassword.Text != iEMT.GetPassword())
                    continue;

                this.Hide();

                // Adding accessible Forms for an EMT
                List<Type> AccessibleForms = new List<Type>();
                AccessibleForms.Add(typeof(Receive_Call_Form));
                AccessibleForms.Add(typeof(EMT_login_shift));
                AccessibleForms.Add(typeof(Dispatch_Report));
                AccessibleForms.Add(typeof(Patient_Information_Form));

                Main_Form MF = new Main_Form(SD, AccessibleForms, iEMT);
                MF.Show();
            }

            if (nameFound == string.Empty)
            {
                txtName.Focus();
                lbName.Visible = true;
            }
            else
            {
                txtPassword.Focus();
                lbPassword.Visible = true;
            }
        }

        private void btnLoginOther_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Adding accessible Forms for a somebody
            List<Type> AccessibleForms = new List<Type>();

            AccessibleForms.Add(typeof(CallForm));
            AccessibleForms.Add(typeof(Emergency_Management_Form));
            AccessibleForms.Add(typeof(Receive_Call_Form));
            AccessibleForms.Add(typeof(EMT_login_shift));
            AccessibleForms.Add(typeof(Base_Station_Records));
            AccessibleForms.Add(typeof(Dispatch_Related_Times));
            AccessibleForms.Add(typeof(Dispatch_Report));
            AccessibleForms.Add(typeof(LinkPatient));
            AccessibleForms.Add(typeof(Patient_Information_Form));

            Person fakePerson = new Person();
            fakePerson.SetName("Other");
            fakePerson.SetLast_Name("Person");
            fakePerson.SetAddress("Cupertino, California");


            Main_Form MF = new Main_Form(SD, AccessibleForms, fakePerson);

            MF.Show();
        }

       

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            txtPassword.Clear();
            lbName.Visible = false;
            lbPassword.Visible = false;
        }

        
    }
}