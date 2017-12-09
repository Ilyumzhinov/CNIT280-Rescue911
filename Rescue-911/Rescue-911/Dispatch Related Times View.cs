using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Dispatch_Related_Times_View : Special_View
    {
        // COMPOSITE DATA
        private Special_List<Dispatch> Dispatchs;
        private Emergency_Call mSelectedCall;
        private Special_List<Emergency> Emgergency = new Special_List<Emergency>();

        // CONSTRUCTORS
        //To-setup the view.
        public Dispatch_Related_Times_View(bool toDisplay, ref Special_List<Dispatch> xDispatchs, ref Special_List<Emergency_Call> xcalls) : this(toDisplay)
        {

            Dispatchs = xDispatchs;
            foreach (Dispatch idispatch in Dispatchs)
            {
                Emgergency.AddItem(idispatch.GetEmergency());
            }

            if (Emgergency != null)
            {
                if (Dispatchs.Count != 0)
                {
                    emergencyControl.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                    emergencyControl.Setup_Control(ref xcalls, "Accepted", false);
                }
                else
                {
                    panel1.Visible = false;
                    emergencyControl.Visible = false;

                    SendStatusUpdate(true, "No data available");
                }
            }
        }


        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {
            mSelectedCall = (Emergency_Call)sender;
        }
        //To-display the view.
        public Dispatch_Related_Times_View(bool toDisplay) : base(toDisplay)
        {
            InitializeComponent();
        }
        //

        private void btnDispatchTime_Click(object sender, EventArgs e)
        {
            foreach (Dispatch d in Dispatchs)
            {
                if (mSelectedCall.GetEmergency() == d.GetEmergency())
                {

                    d.setdispatchtime(dtPicker.ToString());
                    SendStatusUpdate(true, "The dispatch's starting time is recored", "success");
                }
            }
        }

        private void btnRecordArrival_Click(object sender, EventArgs e)
        {
            foreach (Dispatch d in Dispatchs)
            {
                if (mSelectedCall.GetEmergency() == d.GetEmergency())
                {
                    d.setdispatchtime(dtPicker.ToString());
                    SendStatusUpdate(true, "The dispatch's arrive time is recored", "success");
                }
            }
        }
    }
}