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

                Form1 f1 = new Form1(SD);

                f1.Show();
                this.Hide();
            }
        }

        private void btnLoginOther_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(SD);

            f1.Show();
            this.Hide();
        }
    }
}
