using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class CallForm : Form
    {
        Shared_Data SD;
        Emergency_Call Current_Call;
        private int Current_Call_Index;

        public CallForm(ref Shared_Data xSD)
        {
            SD = xSD;

            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            int maxCaller_ID = 0;
            for (int i = 0; i < SD.Calls.Count; i++)
            {
                if ((SD.Calls.Count - i) == 1)
                {
                    Current_Call_Index = i + 1;

                    Current_Call.GetEmergency_Caller().SetCaller_ID(SD.Calls[i - 1].GetEmergency_Caller().GetCaller_ID() + 1);
                    Current_Call.SetState("Not Logged");

                    SD.Calls.Add(Current_Call);
                    // Update the Shared Data values regarding the Calls.
                    ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

                    break;
                }
                else
                {
                    if (maxCaller_ID > SD.Calls[i].GetEmergency_Caller().GetCaller_ID())
                        maxCaller_ID = SD.Calls[i].GetEmergency_Caller().GetCaller_ID();
                } 
            }
            InitializeComponent();
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            lbCallID.Text = Current_Call.GetEmergency_Caller().GetCaller_ID().ToString();

            lbCallState.Text = Current_Call.GetState();

            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy ");
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
            Emergency_Link_Form EmergencyLinkForm = new Emergency_Link_Form(ref SD, Current_Call);

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

                Current_Call.GetEmergency_Caller().SetLast_Name(txtCallerLastName.Text);
                Current_Call.SetLandmark(txtLandmark.Text);

                // Update the Shared Data values regarding the Calls.
                SD.Calls[Current_Call_Index] = Current_Call;
                ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);
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


                //To-Do: Suggeted names from a database
                //lstCallerNames.Items.Clear();
                //int j = 0;
                //for (int i = 0; i < SD.Count; i++)
                //{
                //    if (CallerPNTest[i] == txtPhoneNumber.Text)
                //    {
                //        SuggestedCallerIDs[j] = i;
                //        lstCallerNames.Items.Add(CallerNamesTest[i] + " " + CallerLNamesTest[i]);

                //        j++;
                //    }
                //}

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

        private void CallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckFields() == false)
                SD.Calls.RemoveAt(SD.Calls.Count - 1);
        }
    }
}