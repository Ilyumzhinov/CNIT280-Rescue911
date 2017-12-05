using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Call_View : Special_View, IUserDependent
    {
        // DATA STRUCTURE
        //Primitives
        private int Current_Operator_ID;
        //Composite Data
        private Special_List<Emergency_Call> EmergencyCalls;
        private Special_List<Caller> Callers;
        private Emergency_Call Current_Call;

        //Events
        public event EventHandler LinkEmergencyButton_Click;
        public event EventHandler AddEmergencyButton_Click;
        //


        // CONSTRUCTORS
        //To-setup the view.
        public Call_View(bool toDisplay, ref Special_List<Emergency_Call> xECs, ref Special_List<Caller> xCallers) : this(toDisplay)
        {
            //EmergencyCalls = xECs;
            //Callers = xCallers;

            //Current_Call = new Emergency_Call();
            //Current_Call.SetDateTime(DateTime.Now);

            //Current_Call.SetState("Not Logged");

            //txtCallDateTime.Text = Current_Call.GetDateTime().ToString("h:mm:ss MM/dd/yyyy");

            //txtPhoneNumber.Focus();
        }

        //To-display the view.
        public Call_View(bool toDisplay) : base(toDisplay, "Log Call", Color.Teal)
        {
            if (toDisplay)
                InitializeComponent();
        }
        //


        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Operator)
            {
                Current_Operator_ID = ((Operator)xPerson).GetOperator_ID();
            }
            else
            {
                // Setting up the View
                //pnlCallInfo.Enabled = false;
                //pnlEmergency.Enabled = false;
                //pnlCaller.Enabled = false;

                SendStatusUpdate(true, "To access, you must have Operator access level!", "urgent");
            }
        }
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
        }
        //

        private bool CheckFields()
        {
            // Existence checks
            //if (Current_Call.GetPriority() == 0)
            //{
            //    cboCallPriority.Focus();
            //    return false;
            //}
            //else if (Current_Call.GetEmergency_Caller().GetPhone_Number() == null)
            //{
            //    txtPhoneNumber.Focus();
            //    return false;
            //}
            //else if (Current_Call.GetEmergency_Caller().GetName() == null)
            //{
            //    txtCallerName.Focus();
            //    return false;
            //}
            //else if (Current_Call.GetAddress() == null)
            //{
            //    txtAddress.Focus();
            //    return false;
            //}
            //else if (Current_Call.GetDescription() == null)
            //{
            //    txtDescription.Focus();
            //    return false;
            //}
            //else 
            //{
            //    // All checks are satisfied

            //    Current_Call.SetTeams_Required((int)numTeams.Value);

            //    Current_Call.SetLandmark(txtLandmark.Text);

            //    Current_Call.SetLink_Operator_ID(Current_Operator_ID);

            //    //Update the Shared Data values regarding the Calls.
            //    EmergencyCalls.AddItem(Current_Call);

                return true;
            //}
        }

        //private void cboCallPriority_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Sets an actual index.
        //   // Current_Call.SetPriority(cboCallPriority.SelectedIndex + 1);
        //}

        //private void txtPhoneNumber_Leave(object sender, EventArgs e)
        //{
        //    // Change dataType to string

        //    //if (txtPhoneNumber.Text.Length == 10)
        //    //{
        //    //    bool found = false;
        //    //    txtCallerName.Enabled = true;

        //    //    foreach (Caller iCaller in Callers)
        //    //    {
        //    //        if (iCaller.GetPhone_Number() != txtPhoneNumber.Text)
        //    //            continue;

        //    //        if (iCaller.GetPatient() == null)
        //    //        {
        //    //            txtCallerName.Text = iCaller.GetName();
        //    //        }
        //    //        else
        //    //        {
        //    //            txtCallerName.Text = (iCaller.GetPatient().GetLast_Name() + " " + iCaller.GetPatient().GetName());
        //    //        }
        //    //        txtCallerName.Enabled = false;

        //    //        Current_Call.SetEmergency_Caller(iCaller);

        //    //        found = true;
        //    //        break;
        //    //    }

        //    //    if (found == false)
        //    //    {
        //    //        Current_Call.GetEmergency_Caller().SetPhone_Number(txtPhoneNumber.Text);
        //    //    }
        //    //}
        //}

        ////private void txtCallerName_Leave(object sender, EventArgs e)
        ////{
        ////    if (txtCallerName.Text.Trim() != string.Empty)
        ////        Current_Call.GetEmergency_Caller().SetName(txtCallerName.Text);
        ////}

        ////private void txtAddress_Leave(object sender, EventArgs e)
        ////{
        ////    if (txtAddress.Text.Trim() != string.Empty)
        ////        Current_Call.SetAddress(txtAddress.Text);
        ////}

        ////private void txtDescription_Leave(object sender, EventArgs e)
        ////{
        ////    if (txtDescription.Text.Trim() != string.Empty)
        ////        Current_Call.SetDescription(txtDescription.Text);
        ////}

        public Emergency_Call GetEmergency_Call()
        {
            return Current_Call;
        }

    }
}