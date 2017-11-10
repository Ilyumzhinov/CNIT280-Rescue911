using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Login_Form : Form
    {
        private Shared_Data SD;

        public Login_Form()
        {
            SD = new Shared_Data();

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                return;

            foreach (EMT iEMT in SD.EMTs)
            {
                if (txtName.Text != iEMT.GetName())
                    continue;

                if (txtPassword.Text != iEMT.GetPassword())
                    continue;

                // Adding accessible Forms for an EMT
                List<Type> AccessibleForms = new List<Type>();
                AccessibleForms.Add(typeof(CallForm));
                AccessibleForms.Add(typeof(Emergency_Management_Form));
                AccessibleForms.Add(typeof(Receive_Call_Form));

                Form1 f1 = new Form1(SD, AccessibleForms);
                f1.Show();
                this.Hide();
            }
        }

        private void btnLoginOther_Click(object sender, EventArgs e)
        {
            // Adding accessible Forms for a somebody
            List<Type> AccessibleForms = new List<Type>();

            AccessibleForms.Add(typeof(CallForm));
            AccessibleForms.Add(typeof(Emergency_Management_Form));
            AccessibleForms.Add(typeof(Receive_Call_Form));
            AccessibleForms.Add(typeof(EMT_login_shift));
            AccessibleForms.Add(typeof(Dispatch_Related_Times));
            AccessibleForms.Add(typeof(Dispatch_Report));

            Form1 f1 = new Form1(SD, AccessibleForms);

            f1.Show();
            this.Hide();
        }
    }
}
