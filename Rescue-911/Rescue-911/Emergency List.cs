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
        public int emergencySelected;

        //Associations
        private List<Emergency> Emergencies;

        //Event Handlers
        public event EventHandler EmergencySelected;
        //

        public Emergency_List()
        {
            InitializeComponent();
        }

        public void SetEmergency_List(ref List<Emergency> xExistingEmergencies, string xState = "ALL", bool xStateCanChange = false)
        {
            // Setting up the values
            Emergencies = xExistingEmergencies;
            foreach(Emergency iEmergency in xExistingEmergencies)
            {
                iEmergency.EmergencyCall_Added += new EventHandler(lstEmergencies_Update);
            }

            // Setting up the interface
            cmbState.Enabled = xStateCanChange;
            cmbState.SelectedItem = xState;
            lstEmergencies.Columns[0].Width = 80;
            lstEmergencies.Columns[1].Width = 80;
            lstEmergencies.Columns[2].Width = 80;
            lstEmergencies.Columns[3].Width = 80;
            lstEmergencies.Columns[4].Width = lstEmergencies.Width - 80 * 4 - (int)(SystemInformation.VerticalScrollBarWidth* 1.5);

            // Populating the listView.
            listEmergenciesPopulate(xState, Emergencies);
        }

        private void listEmergenciesPopulate(string state, List<Emergency> ExistingEmergencies)
        {
            lstEmergencies.Items.Clear();
            List<ListViewItem> lstItem = new List<ListViewItem>();

            int i = 0;

            foreach (Emergency iEmergency in ExistingEmergencies)
            {
                int j = 0;

                foreach (Emergency_Call EC in iEmergency.GetLinkedCalls())
                {
                    if (state != "ALL")
                        if (EC.GetState() != state)
                            continue;

                    if (j == 0)
                    {
                        lstItem.Add(new ListViewItem(iEmergency.GetEmergency_ID().ToString()));

                        lstItem[i].SubItems.Add(iEmergency.GetEType());
                        lstItem[i].SubItems.Add(EC.GetPriority().ToString());
                        lstItem[i].SubItems.Add(EC.GetState());
                        lstItem[i].SubItems.Add(EC.GetDescription());
                        lstItem[i].Tag = iEmergency;
                    }
                    else
                    {
                        lstItem.Add(new ListViewItem(iEmergency.GetEmergency_ID().ToString()));

                        lstItem[i].SubItems.Add(iEmergency.GetEType());
                        lstItem[i].SubItems.Add(EC.GetPriority().ToString());
                        lstItem[i].SubItems.Add(EC.GetState());
                        lstItem[i].SubItems.Add(EC.GetDescription());
                        lstItem[i].Tag = iEmergency;
                    }

                    j++;
                    i++;
                }

                
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
            listEmergenciesPopulate((string)cmbState.SelectedItem, Emergencies);
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                emergencySelected = lstEmergencies.SelectedIndices[0];

                EmergencySelected?.Invoke(lstEmergencies.SelectedItems[0].Tag, e);
            }
            catch
            {

            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEmergenciesPopulate((string)cmbState.SelectedItem, Emergencies);
        }

        private void Emergency_List_SizeChanged(object sender, EventArgs e)
        {
            lstEmergencies.Columns[4].Width = lstEmergencies.Width - 80 * 4 - SystemInformation.VerticalScrollBarWidth;
        }
    }
}