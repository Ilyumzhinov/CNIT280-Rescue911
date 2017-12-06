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

        //Events
        public event EventHandler LinkEmergency;
        public event EventHandler AddEmergency;
        //


        // CONSTRUCTORS
        //To-setup the view.
        public Call_View(bool toDisplay, ref Special_List<Emergency_Call> xECs, ref Special_List<Caller> xCallers) : this(toDisplay)
        {
            call_Control1.Setup_Control(ref xECs, ref xCallers, 0);

            call_Control1.AddEmergencyButton_Click -= new EventHandler(AddEmergency_Click);
            call_Control1.AddEmergencyButton_Click += new EventHandler(AddEmergency_Click);

            call_Control1.LinkEmergencyButton_Click -= new EventHandler(LinkEmergency_Click);
            call_Control1.LinkEmergencyButton_Click += new EventHandler(LinkEmergency_Click);
        }

        //To-display the view.
        public Call_View(bool toDisplay) : base(toDisplay, "Log Call", Color.Teal, false, "When all information is filled in, either add or link the Call to an Emergency.")
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
                call_Control1.SetOperator_ID(Current_Operator_ID);
            }
            else
            {
                // Setting up the View
                call_Control1.EnableControls(false);

                SendStatusUpdate(true, "To access, you must have Operator access level!", "urgent");
            }
        }
        //

        //EVENT HANDLERS
        private void AddEmergency_Click(object sender, EventArgs e)
        {
            AddEmergency?.Invoke(sender, e);
        }

        private void LinkEmergency_Click(object sender, EventArgs e)
        {
            LinkEmergency?.Invoke(sender, e);
        }
    }
}