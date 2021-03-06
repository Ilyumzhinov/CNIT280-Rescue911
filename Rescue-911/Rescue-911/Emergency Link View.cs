﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Link_View : Special_View
    {
        private Special_List<Emergency> Emergencies;
        private Special_List<Emergency_Call> Calls;
        private Emergency_Call Current_Call;
        private Emergency_Call mSelectedCall;

        // CONSTRUCTORS
        //To-setup the view.
        public Emergency_Link_View(bool toDisplay, ref Special_List<Emergency> xEmergencies, ref Special_List<Emergency_Call> xECs, Emergency_Call xCurrentCall) :  this(toDisplay)
        {
            Emergencies = xEmergencies;
            Calls = xECs;
            Current_Call = xCurrentCall;

            // Call Control set-up.
            callControlOverview.Setup_Control(Current_Call, "Overview", 0);

            // Emergency list set-up.
            if (Emergencies[0] != null)
            {
                emergencyControl.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                emergencyControl.Setup_Control(ref Calls, "Logged", true);
            }
        }

        //To-display the view.
        public Emergency_Link_View(bool toDisplay) : base(toDisplay, false)
        {
                InitializeComponent();
        }
        //


        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            foreach (Emergency_Call iEC in Calls)
            {
                if (iEC == mSelectedCall)
                { 
                    Current_Call.SetEmergency(iEC.GetEmergency());
                    Current_Call.SetState("Logged");

                    
                    ((Call_View)GetPrevious_View()).EnableControls();

                    SendStatusUpdate(true, "Emergency Call was linked successfully", "success");

                    break;
                }

            }
        }

        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            btnLinkEmergency.Visible = true;

            mSelectedCall = (Emergency_Call)sender;
        }
    }
}