using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class CallForm : Form
    {
        Shared_Data SD;
        Emergency_Call Current_Call;
        int[] SuggestedCallerIDs = new int[3];

        public CallForm(ref Shared_Data xSD)
        {
            SD = xSD;

            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.GetEmergency_Caller().SetCaller_ID(SD.Calls.get);


            InitializeComponent();
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
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtPhoneNumber.Text, out number) && txtPhoneNumber.Text.Length == 10)
            {
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);


                // Suggeted names from a database
                //lstCallerNames.Items.Clear();
                //int j = 0;
                //for (int i = 0; i < CallerNamesTest.Count(); i++)
                //{
                //    if (CallerPNTest[i] == txtPhoneNumber.Text)
                //    {
                //        SuggestedCallerIDs[j] = i;
                //        lstCallerNames.Items.Add(CallerNamesTest[i] + " " + CallerLNamesTest[i]);

                //        j++;
                //    }
                //}
                //
            }
        }

        private void txtCallerName_Leave(object sender, EventArgs e)
        {
            if (txtCallerName.Text.Trim() != string.Empty)
                Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
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
            //if (lstCallerNames.SelectedIndex != -1)
            //{
            //    foreach (int index in SuggestedCallerIDs)
            //    {
            //        if (index == lstCallerNames.SelectedIndex)
            //        {
            //            Current_Call.GetEmergency_Caller().SetCaller_ID(SuggestedCallerIDs[index]);
            //            Current_Call.GetEmergency_Caller().SetName(CallerNamesTest[SuggestedCallerIDs[index]]);
            //            Current_Call.GetEmergency_Caller().SetLast_Name(CallerLNamesTest[SuggestedCallerIDs[index]]);
            //        }
            //    }

            //    lbCallID.Text = Current_Call.GetEmergency_Caller().GetCaller_ID().ToString();
            //    txtCallerName.Text = Current_Call.GetEmergency_Caller().GetName();
            //    txtCallerLastName.Text = Current_Call.GetEmergency_Caller().GetLast_Name();
            //}
        }
    }
}