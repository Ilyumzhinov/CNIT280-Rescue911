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
            if (Emgergency != null) {
                if (Dispatchs.Count !=0)
                {
                    emergencyControl.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);

                    emergencyControl.Setup_Control(ref xcalls, "Actioned", false);
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

        private void Dispatch_Related_Times_Load(object sender, EventArgs e)
        {
            lstEmergenciesFetch("Accepted", Dispatchs);
        }

        private void btnDispatchTime_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (lstEmergencies.SelectedItems[0] == null)
            //        return;

            //    lstEmergencies.SelectedItems[0].SubItems.Add(dtPicker.Value.ToString("h:mm:ss MM/dd/yyyy "));
            //}
            //catch
            //{

            //}
        }

        private void btnRecordArrival_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (lstEmergencies.SelectedItems[0] == null)
            //        return;

            //    lstEmergencies.SelectedItems[0].SubItems.Add(dtPicker.Value.ToString("h:mm:ss MM/dd/yyyy "));
            //}
            //catch
            //{

            //}
        }

        private void lstEmergenciesFetch(string state, List<Dispatch> Dispatchs)
        {
                //lstEmergencies.Items.Clear();

                //foreach (Emergency iEmergency in ExistingEmergencies)
                //{
                //    int j = 0;

                //    if (iEmergency.GetLinkedCalls()[0].GetState() != state)
                //        continue;

                //    foreach (Emergency_Call EC in iEmergency.GetLinkedCalls())
                //    {
                //        if (EC == null)
                //            break;

                //        if (j == 0)
                //        {
                //            ListViewItem lstItem = new ListViewItem(iEmergency.GetEmergency_ID().ToString());

                //            lstItem.SubItems.Add(EC.GetAddress());

                //            lstEmergencies.Items.AddRange(new ListViewItem[1] { lstItem });
                //        }
                //        else
                //        {
                //            ListViewItem lstItem = new ListViewItem();

                //            lstItem.SubItems.Add(EC.GetAddress());

                //            lstEmergencies.Items.AddRange(new ListViewItem[1] { lstItem });
                //        }
                //        j++;
                //    }
                //}
        }
    }
}
