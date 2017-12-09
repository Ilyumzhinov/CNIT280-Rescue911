using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;


namespace Rescue_911
{
    public partial class Emergency_Add_View : Special_View, IUserDependent
    {
        public Emergency_Add_View(bool toDisplay, ref Special_List<Emergency_Call> xCalls, ref Emergency_Call xEC, ref Special_List<Caller> xCallers) : this(toDisplay)
        {
            emergencyControl.Setup_Control(ref xCalls, ref xEC);

            emergencyControl.Emergency_Added -= new EventHandler(AddEmer);
            emergencyControl.Emergency_Added += new EventHandler(AddEmer);
        }

        public Emergency_Add_View(bool toDisplay) : base(toDisplay, false)
        {
                InitializeComponent();
        }

        public void SendUser(Person xUser)
        {
            if (xUser is Operator == false)
            {
                SendStatusUpdate(true, "To access, you must have Operator access level!", "urgent");

                emergencyControl.Visible = false;
            }
            else return;
        }

        private void AddEmer(object sender, EventArgs e)
        {
            emergencyControl.Enabled = false;

            ((Call_View)GetPrevious_View()).EnableControls();
            SendStatusUpdate(true, "Emergency ID"+ ((Emergency_Call)sender).GetEmergency().GetEmergency_ID().ToString() + " added", "success");
        }
    }
}
