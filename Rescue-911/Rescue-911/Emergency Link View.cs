﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Link_View : Special_View
    {
        private Emergency_Call Current_Call;
        private Emergency_Call mSelectedCall;

        public Emergency_Link_View(ref Shared_Data xSD, Emergency_Call xCurrentCall) : base(ref xSD, "Link to Emergency", false, Color.Green, "This cannot be undone")
        {
            // Change it
            Current_Call = xCurrentCall;

            InitializeComponent();

            lbCallState.Text = Current_Call.GetState();
            lbAddress.Text = Current_Call.GetAddress();
            txtDescription.Text = Current_Call.GetDescription();

            // Emergency list set-up.
            if (SD.GetEmergencies()[0] != null)
            {
                emergencyList.Width = this.Width;
                emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                Special_List<Emergency_Call> tempECs = SD.GetCalls();
                emergencyList.SetEmergency_List(ref tempECs, "Logged", true);
            }
        }

        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            foreach (Emergency_Call iEC in SD.GetCalls())
            {
                if (iEC == mSelectedCall)
                { 
                    Current_Call.SetEmergency(iEC.GetEmergency());
                    Current_Call.SetState("Logged");

                    break;
                }

            }
        }

        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            btnLinkEmergency.Visible = true;

            mSelectedCall = (Emergency_Call)sender;
        }


        private void Emergency_Link_View_SizeChanged(object sender, EventArgs e)
        {
            emergencyList.Width = this.Width;
        }
    }
}