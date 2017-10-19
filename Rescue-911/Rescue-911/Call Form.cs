using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class CallForm : Form
    {
        Emergency_Call Current_Call;
        bool[] RequiredGraphsChecked = new bool[5];

        public CallForm()
        {
            InitializeComponent();

            Current_Call = new Emergency_Call();
            Current_Call.GetEmergency_Caller().SetCaller_ID(1);
            Current_Call.SetDateTime(DateTime.Now);
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            lbCallID.Text = Current_Call.GetEmergency_Caller().GetCaller_ID().ToString();
            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy ");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (RequiredGraphsChecked[0] == false)
            {
                cboCallPriority.Focus();
            }
            else if (RequiredGraphsChecked[1] == false)
            {
                txtPhoneNumber.Focus();
            }
            else if (RequiredGraphsChecked[2] == false)
            {
                txtCallerName.Focus();
            }
            else if (RequiredGraphsChecked[3] == false)
            {
                txtAddress.Focus();
            }
            else if (RequiredGraphsChecked[4] == false)
            {
                txtDescription.Focus();
            }
            else
            {
                if (int.TryParse(txtTeamsReq.Text, out int teams))
                    Current_Call.SetTeams_Required(teams);

                if (txtLandmark.Text.Trim() != string.Empty)
                    Current_Call.SetLandmark(txtLandmark.Text);

                this.Close();
            }
        }

        private void cboCallPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets an actual index.
            Current_Call.SetPriority(cboCallPriority.SelectedIndex + 1);
            RequiredGraphsChecked[0] = true;
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtPhoneNumber.Text, out int number) && txtPhoneNumber.Text.Length == 10)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);

                RequiredGraphsChecked[1] = true;
            }
        }

        private void txtCallerName_Leave(object sender, EventArgs e)
        {
            if (txtCallerName.Text.Trim() != string.Empty)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
                RequiredGraphsChecked[2] = true;
            }

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() != string.Empty)
            {
                Current_Call.SetAddress(txtAddress.Text);
                RequiredGraphsChecked[3] = true;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() != string.Empty)
            {
                Current_Call.SetDescription(txtDescription.Text);
                RequiredGraphsChecked[4] = true;
            }
        }
    }
}
