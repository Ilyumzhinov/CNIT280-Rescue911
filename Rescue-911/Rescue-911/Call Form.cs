using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class CallForm : Form
    {
        Emergency_Call Current_Call;
        bool[] RequiredGraphsChecked = new bool[5];
        int[] SuggestedCallerIDs = new int[3];

        //TEST ITEMS
        string[] CallerNamesTest = new string[3] { "Artem", "Kevin", "Jordan" };
        string[] CallerLNamesTest = new string[3] { "Ilyumzhinov", "Zhang", "Sexton"};
        string[] CallerPNTest = new string[3] { "1231231231", "1231231231", "1111111111" };
        //


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

            if (Current_Call.GetState() != null)
            {
                lbCallState.Text = Current_Call.GetState();
            }
            else
            {
                lbCallState.ForeColor = Color.Chocolate;
                lbCallState.Text = "not logged";
            }

            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy ");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int teams;

            // Existence checks
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
            else if (int.TryParse(txtTeamsReq.Text, out teams) == false)
            {
                txtTeamsReq.Focus();
            }
            else // All checks are satisfied
            {
                Current_Call.SetTeams_Required(teams);
                Current_Call.SetState("logged");

                if (txtLandmark.Text.Trim() != string.Empty)
                    Current_Call.SetLandmark(txtLandmark.Text);

                // Open the Emergency Form
                Emergency_Form EmergencyForm = new Emergency_Form();
                EmergencyForm.SetEmergency_Call(Current_Call);
                EmergencyForm.Show();
                //this.Close();
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
            int number;
            if (int.TryParse(txtPhoneNumber.Text, out number) && txtPhoneNumber.Text.Length == 10)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);


                // Suggeted names from a database
                lstCallerNames.Items.Clear();
                int j = 0;
                for (int i = 0; i < CallerNamesTest.Count(); i++)
                {
                    if (CallerPNTest[i] == txtPhoneNumber.Text)
                    {
                        SuggestedCallerIDs[j] = i;
                        lstCallerNames.Items.Add(CallerNamesTest[i] + " " + CallerLNamesTest[i]);

                        j++;
                    }
                }
                //

                RequiredGraphsChecked[1] = true;
            }
            else
            {
                RequiredGraphsChecked[1] = false;
            }
        }

        private void txtCallerName_Leave(object sender, EventArgs e)
        {
            if (txtCallerName.Text.Trim() != string.Empty)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
                RequiredGraphsChecked[2] = true;
            }
            else
            {
                RequiredGraphsChecked[2] = false;
            }

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() != string.Empty)
            {
                Current_Call.SetAddress(txtAddress.Text);
                RequiredGraphsChecked[3] = true;
            }
            else
            {
                RequiredGraphsChecked[3] = false;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() != string.Empty)
            {
                Current_Call.SetDescription(txtDescription.Text);
                RequiredGraphsChecked[4] = true;
            }
            else
            {
                RequiredGraphsChecked[4] = false;
            }
        }

        private void lstCallerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCallerNames.SelectedIndex != -1)
            {
                foreach (int index in SuggestedCallerIDs)
                {
                    if (index == lstCallerNames.SelectedIndex)
                    {
                        Current_Call.GetEmergency_Caller().SetCaller_ID(SuggestedCallerIDs[index]);
                        Current_Call.GetEmergency_Caller().SetName(CallerNamesTest[SuggestedCallerIDs[index]]);
                        Current_Call.GetEmergency_Caller().SetLast_Name(CallerLNamesTest[SuggestedCallerIDs[index]]);
                    }
                }

                lbCallID.Text = Current_Call.GetEmergency_Caller().GetCaller_ID().ToString();
                txtCallerName.Text = Current_Call.GetEmergency_Caller().GetName();
                txtCallerLastName.Text = Current_Call.GetEmergency_Caller().GetLast_Name();
            }
        }
    }
}