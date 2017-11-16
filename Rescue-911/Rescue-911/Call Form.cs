using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class CallForm : Special_Form
    {
        Emergency_Call Current_Call;
        List<Patient> Suggested_Patients = new List<Patient>();

        public CallForm(ref Shared_Data xSD) : base(ref xSD, "Log Call")
        {
            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.SetState("Not Logged");

            SD.Calls.Add(Current_Call);
            // Update the Shared Data values regarding the Calls.
            ((Login_Form)SD.LoginForm).UpdateSD(SD);

            InitializeComponent();
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            lbCallState.Text = Current_Call.GetState();

            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy ");

            txtPhoneNumber.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            // Open the Emergency Form
            Emergency_Form EmergencyForm = new Emergency_Form(ref SD, Current_Call);

            EmergencyForm.Show();
            // To-Do: change this to the method inside the Emergency Form.
            this.Close();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            // Open the Emergency Form
            Emergency_Link_Form EmergencyLinkForm = new Emergency_Link_Form(ref SD);

            EmergencyLinkForm.Show();
            // To-Do: change this to the method inside the Emergency Link Form.
            this.Close();
        }

        private bool CheckFields()
        {
            int teams;

            // Existence checks
            if (Current_Call.GetPriority() == 0)
            {
                cboCallPriority.Focus();
                return false;
            }
            else if (Current_Call.GetEmergency_Caller().GetPhone_Number() == null)
            {
                txtPhoneNumber.Focus();
                return false;
            }
            else if (Current_Call.GetEmergency_Caller().GetName() == null)
            {
                txtCallerName.Focus();
                return false;
            }
            else if (Current_Call.GetAddress() == null)
            {
                txtAddress.Focus();
                return false;
            }
            else if (Current_Call.GetDescription() == null)
            {
                txtDescription.Focus();
                return false;
            }
            else if (int.TryParse(txtTeamsReq.Text, out teams) == false)
            {
                txtTeamsReq.Focus();
                return false;
            }
            else // All checks are satisfied
            {
                Current_Call.SetTeams_Required(teams);
                Current_Call.SetState("Logged");

                Current_Call.SetLandmark(txtLandmark.Text);

                // Update the Shared Data values regarding the Calls.
                SD.Calls.Add(Current_Call);
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                return true;
            }
        }

        private void cboCallPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets an actual index.
            Current_Call.SetPriority(cboCallPriority.SelectedIndex + 1);
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            // Change dataType to string
            int number;
            if (int.TryParse(txtPhoneNumber.Text, out number) && txtPhoneNumber.Text.Length == 10)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
            }
        }

        private void txtCallerName_Leave(object sender, EventArgs e)
        {
            if (txtCallerName.Text.Trim() != string.Empty)
                Current_Call.GetEmergency_Caller().SetName(txtCallerName.Text);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() != string.Empty)
                Current_Call.SetAddress(txtAddress.Text);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() != string.Empty)
                Current_Call.SetDescription(txtDescription.Text);
        }

        private void lstCallerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCallerNames.SelectedIndex != -1)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);

                txtCallerName.Text = Suggested_Patients[lstCallerNames.SelectedIndex].GetName() + ", " + Suggested_Patients[lstCallerNames.SelectedIndex].GetLast_Name();

                txtCallerName.Enabled = false;
            }
        }

        private void CallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckFields() == false)
                SD.Calls.RemoveAt(SD.Calls.Count - 1);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //To-Do: Suggeted names from a database
            lstCallerNames.Items.Clear();
            Suggested_Patients.Clear();

            int j = 0;
            for (int i = 0; i < SD.Patients.Count; i++)
            {
                if (SD.Patients[i].GetAssociatedPNumber() == null)
                    continue;

                foreach (Caller iNumber in SD.Patients[i].GetAssociatedPNumber())
                {
                    if (iNumber.GetPhone_Number() == txtPhoneNumber.Text)
                    {
                        Suggested_Patients.Add(SD.Patients[i]);

                        lstCallerNames.Items.Add(Suggested_Patients[j].GetName() + " " + Suggested_Patients[j].GetLast_Name());

                        j++;
                    }
                }
            }
            if (j == 0)
            {
                txtCallerName.Clear();
                txtCallerName.Enabled = true;
            }
        }
    }
}