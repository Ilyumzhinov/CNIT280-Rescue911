using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;


namespace Rescue_911
{
    public partial class Emergency_Add_View : Special_View, IUserDependent
    {
        private Special_List<Emergency_Call> Calls;
        private Special_List<Caller> Callers;
        private Emergency_Call Current_Call;
        private Emergency Emer = new Emergency();
        private int temp = 0;

        public Emergency_Add_View(bool toDisplay, ref Special_List<Emergency_Call> xCalls, ref Emergency_Call xEC, ref Special_List<Caller> xCallers) : this(toDisplay)
        {
            emergencyControl.Setup_Control(ref xCalls, ref xEC);
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

                emergencyControl.EnabledControls(false);
            }
            else return;

        }
    }
}
