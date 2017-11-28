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


        public void SetEmergency_List(ref Special_List<Emergency_Call> xExistingCalls, string xState = "ALL", bool xStateCanChange = false)
        {
            // Setting up the values
            Calls = xExistingCalls;
            Calls.ItemAdded += new EventHandler(lstEmergencies_CallUpdateEvent);
            lstEmergencies_CallUpdateEvent(null, null);

            // Setting up the interface
            cmbState.Items.AddRange(new object[] {
            "ALL",
            "Not logged",
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
            lstEmergencies.Columns[4].Width = lstEmergencies.Width - 80 * 4 - (int)(SystemInformation.VerticalScrollBarWidth* 1.5);

            // Populating the listView.
            listEmergenciesPopulate(xState, Calls);
        }

        private void listEmergenciesPopulate(string state, List<Emergency_Call> ExistingCalls)
        {
            lstEmergencies.Items.Clear();

            List<ListViewItem> lstItem = new List<ListViewItem>();
            int i = 0;
            foreach (Emergency_Call iEC in ExistingCalls)
            {
                if (state != "ALL")
                    if (iEC.GetState() != state)
                        continue;

                lstItem.Add(new ListViewItem(iEC.GetEmergency().GetEmergency_ID().ToString()));

                lstItem[i].SubItems.Add(iEC.GetEmergency().GetEType());
                lstItem[i].SubItems.Add(iEC.GetPriority().ToString());
                lstItem[i].SubItems.Add(iEC.GetState());
                lstItem[i].SubItems.Add(iEC.GetDescription());
                lstItem[i].Tag = iEC;

                i++;
            }

            // Setting the height
            if (((lstItem.Count + 2) * (int)(lstEmergencies.Font.Height * 1.5)) < lstEmergencies.Font.Height * 50)
            {
                lstEmergencies.Height = (lstItem.Count + 2) * (int)(lstEmergencies.Font.Height * 1.5);
            }
            else
                lstEmergencies.Height = lstEmergencies.Font.Height * 50;

            // Adding the values
            lstEmergencies.Items.AddRange(lstItem.ToArray());
        }

        private void lstEmergencies_Update(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, Calls);
        }

        private void lstEmergencies_CallUpdateEvent(object sender, EventArgs e)
        {
            foreach (Emergency_Call iEC in Calls)
            {
                iEC.Call_Updated -= new EventHandler(lstEmergencies_Update);
                iEC.Call_Updated += new EventHandler(lstEmergencies_Update);
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

            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, Calls);
        }

        private void Emergency_List_SizeChanged(object sender, EventArgs e)
        {
            lstEmergencies.Columns[4].Width = lstEmergencies.Width - 80 * 4 - SystemInformation.VerticalScrollBarWidth;
        }
    }
}