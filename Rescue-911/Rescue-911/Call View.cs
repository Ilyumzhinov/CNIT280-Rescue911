using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Call_View : Special_View
    {
        Emergency_Call Current_Call;
        List<Patient> Suggested_Patients = new List<Patient>();
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event EventHandler OnUserControlButtonClicked;

        public Call_View(ref Shared_Data xSD) : base(ref xSD, "Log Call")
        {
            InitializeComponent();

            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.SetState("Not Logged");

            // SD.Calls.Add(Current_Call);
        }

        private void Call_View_Load(object sender, EventArgs e)
        {
            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy ");

            txtPhoneNumber.Focus();
        }

        private void btnEmergency_click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            if (OnUserControlButtonClicked != null)
                OnUserControlButtonClicked(this, e);
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
            else if (txtCallerName.Text == string.Empty)
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

        private void btnAddEmer_Click(object sender, EventArgs e)
        {
            Emergency_Form Em = new Emergency_Form(ref SD, Current_Call);
            Em.Show();
        }
    }
}