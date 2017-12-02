using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Call_View : Special_View
    {
        // DATA STRUCTURE
        //Composite Data
        private Emergency_Call Current_Call;
        private List<Patient> Suggested_Patients = new List<Patient>();

        //Events
        public event EventHandler LinkEmergencyButton_Click;
        public event EventHandler AddEmergencyButton_Click;
        //


        // CONSTRUCTORS
        //To-display the view.
        public Call_View(ref Shared_Data xSD) : base(ref xSD, "Log Call", false, Color.Teal)
        {
            InitializeComponent();

            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.SetState("Not Logged");

            txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy");

            txtPhoneNumber.Focus();
        }

        //To-instantiate the view.
        public Call_View() : base("Log Call", false, Color.Teal)
        {}
        //


        // EVENTS
        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false)
                return;

            LinkEmergencyButton_Click?.Invoke(this, e);
        }

        private void btnAddEmer_Click(object sender, EventArgs e)
        {

            if (CheckFields() == false)
                return;

            AddEmergencyButton_Click?.Invoke(this, e);
            //Emergency_Form Em = new Emergency_Form(ref SD, Current_Call);
            //Em.Show();
        }
        //

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

                Current_Call.SetLandmark(txtLandmark.Text);

                // Update the Shared Data values regarding the Calls.
                SD.AddCall(Current_Call);


                SD.UpdateSD(ref SD);
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

            if (txtPhoneNumber.Text.Length == 10)
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

        public Emergency_Call GetEmergency_Call() { return Current_Call; }
    }
}