using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_List : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        public int selectedIndex;

        //Associations
        private Special_List<Emergency_Call> Calls;

        //Event Handlers
        public event EventHandler EmergencySelected;
        //

        public Emergency_List()
        {
            InitializeComponent();
        }


        public void SetEmergency_List(ref Special_List<Emergency_Call> xExistingCalls, string xState = "Logged", bool xStateCanChange = false)
        {
            // Setting up the values
            Calls = xExistingCalls;
            Calls.ItemAdded += new EventHandler(lstEmergencies_CallUpdateEvent);

            // Setting up the interface
            cmbState.Items.AddRange(new object[] {
            "Logged",
            "Waiting",
            "Accepted",
            "Actioned",
            "Declined"});
            cmbState.Enabled = xStateCanChange;
            cmbState.SelectedItem = xState;
            lstEmergencies.Columns[0].Width = 80;
            lstEmergencies.Columns[1].Width = 80;
            lstEmergencies.Columns[2].Width = 80;
            lstEmergencies.Columns[3].Width = 80;
            lstEmergencies.Columns[4].Width = 80;
            lstEmergencies.Columns[5].Width = lstEmergencies.Width - 80 * 5 - (int)(SystemInformation.VerticalScrollBarWidth * 1.5);
            lstEmergencies.Height = lstEmergencies.Font.Height * 25;
        }

        private void listEmergenciesPopulate(string state, List<Emergency_Call> ExistingCalls)
        {
            lstEmergencies.Items.Clear();

            foreach (Emergency_Call iEC in ExistingCalls)
            {
                // Adding the events for initial calls
                lstEmergencies_CallUpdateEvent(iEC, null);
            }
        }

        private ListViewItem lstItemFetch(Emergency_Call xCall)
        {
            ListViewItem lstItem = new ListViewItem(xCall.GetEmergency().GetEmergency_ID().ToString());

            lstItem.SubItems.Add(xCall.GetEmergency().GetEType());
            lstItem.SubItems.Add(xCall.GetTeams_Required().ToString());
            lstItem.SubItems.Add(xCall.GetPriorityString());
            lstItem.SubItems.Add(xCall.GetState());
            lstItem.SubItems.Add(xCall.GetDescription());
            lstItem.Tag = xCall;

            return lstItem;
        }

        private void lstEmergencies_CallUpdateEvent(object sender, EventArgs e)
        {
            ((Emergency_Call)sender).Call_Updated -= new EventHandler(lstEmergencies_Update);
            ((Emergency_Call)sender).Call_Updated += new EventHandler(lstEmergencies_Update);

            if (((Emergency_Call)sender).GetState() != (string)cmbState.SelectedItem)
                return;

            lstEmergencies.Items.Add(lstItemFetch((Emergency_Call)sender));
        }

        private void lstEmergencies_Update(object sender, EventArgs e)
        {
            int index = -1;

            for (int i = 0; i < lstEmergencies.Items.Count; i++)
            {
                if (((Emergency_Call)(lstEmergencies.Items[i].Tag)).GetDateTime() == ((Emergency_Call)sender).GetDateTime() || ((Emergency_Call)(lstEmergencies.Items[i].Tag)).GetEmergency_Caller().GetPhone_Number() == ((Emergency_Call)sender).GetEmergency_Caller().GetPhone_Number())
                {
                    index = i;

                    break;
                }
            }

            if (((Emergency_Call)sender).GetState() != (string)cmbState.SelectedItem)
            {
                if (index != -1)
                {
                    lstEmergencies.Items[index].Remove();
                    return;
                }
                else
                    return;
            }

            ListViewItem lstItem = lstItemFetch((Emergency_Call)sender);
            if (index == -1)
            {
                lstEmergencies.Items.Add(lstItem);
            }
            else
            {
                lstEmergencies.Items[index] = lstItem;
            }
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = lstEmergencies.SelectedIndices[0];

                EmergencySelected?.Invoke(lstEmergencies.SelectedItems[0].Tag, e);
            }
            catch
            {
                selectedIndex = -1;
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, Calls);
        }


        private void Emergency_List_SizeChanged(object sender, EventArgs e)
        {
            lstEmergencies.Columns[5].Width = lstEmergencies.Width - 80 * 5 - SystemInformation.VerticalScrollBarWidth;
        }
    }
}