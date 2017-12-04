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
    public partial class Response_Teams_List : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        public int selectedIndex;

        //Associations
        private Special_List<Response_Team> RTs;

        //Event Handlers
        public event EventHandler RTSelected;
        //

        public Response_Teams_List()
        {
            InitializeComponent();
        }


        public void SetResponseTeams_List(ref Special_List<Response_Team> xExistingRTs, int xBS = -1)
        {
            // Setting up the values
            RTs = xExistingRTs;

            RTs.ItemAdded += new EventHandler(lstRTs_RTUpdateEvent);


            // Getting Base Stations
            List<BaseStation> BS = new List<BaseStation>();
            foreach (Response_Team iRT in RTs)
            {
                if (iRT.GetBaseStation() == null)
                    continue;

                if (BS.Contains(iRT.GetBaseStation()) == true)
                    continue;

                BS.Add(iRT.GetBaseStation());
            }


            // Setting up the interface
            if (BS.Count == 0)
            {
                cmbStation.Items.Add("failed to load");
                cmbStation.SelectedItem = "failed to load";
                cmbStation.Enabled = false;
            }
            else
            {
                cmbStation.Items.AddRange(BS.ToArray());
                xBS = -1;
                cmbStation.SelectedIndex = xBS;
            }

            lstRTs.Columns[0].Width = 100;
            lstRTs.Columns[1].Width = 100;
            lstRTs.Columns[2].Width = 100;
            lstRTs.Columns[3].Width = 100;
            lstRTs.Height = lstRTs.Font.Height * 25;
        }

        private void listRTsPopulate(int xBS, List<Response_Team> ExistingTeams)
        {
            lstRTs.Items.Clear();

            foreach (Response_Team iRT in ExistingTeams)
            {
                // Adding the events for initial calls
                lstRTs_RTUpdateEvent(iRT, null);
            }
        }

        private ListViewItem lstItemFetch(Response_Team xTeam)
        {
            ListViewItem lstItem = new ListViewItem(xTeam.GetID().ToString());

            lstItem.SubItems.Add(xTeam.GetBaseStation().GetBS_ID().ToString());
            lstItem.SubItems.Add(xTeam.GetGrade().ToString());
            lstItem.SubItems.Add(xTeam.GetTeamstatus());
            lstItem.Tag = xTeam;

            return lstItem;
        }

        private void lstRTs_RTUpdateEvent(object sender, EventArgs e)
        {
           ((Response_Team)sender).Team_Updated -= new EventHandler(lstTeam_Update);
           ((Response_Team)sender).Team_Updated += new EventHandler(lstTeam_Update);

            if (((Response_Team)sender).GetBaseStation().GetBS_ID() != ((BaseStation)cmbStation.SelectedItem).GetBS_ID())
                return;

            lstRTs.Items.Add(lstItemFetch((Response_Team)sender));
        }

        private void lstTeam_Update(object sender, EventArgs e)
        {
            int index = -1;

            for (int i = 0; i < lstRTs.Items.Count; i++)
            {
                if (((Response_Team)(lstRTs.Items[i].Tag)).GetID() == ((Response_Team)sender).GetID())
                {
                    index = i;

                    break;
                }
            }

            if (((Response_Team)sender).GetBaseStation().GetBS_ID() != ((BaseStation)cmbStation.SelectedItem).GetBS_ID())
            {
                if (index != -1)
                {
                    lstRTs.Items[index].Remove();
                    return;
                }
                else
                    return;
            }

            if (((Response_Team)sender).GetTeamstatus() != "Available")
            {
                if (index != -1)
                {
                    lstRTs.Items[index].Remove();
                    return;
                }
                else
                    return;
            }

            ListViewItem lstItem = lstItemFetch((Response_Team)sender);
            if (index == -1)
            {
                lstRTs.Items.Add(lstItem);
            }
            else
            {
                lstRTs.Items[index] = lstItem;
            }


        }

        private void lstRTs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = lstRTs.SelectedIndices[0];

                RTSelected?.Invoke(lstRTs.SelectedItems[0].Tag, e);
            }
            catch
            {
                selectedIndex = -1;
            }
        }

        private void Emergency_List_SizeChanged(object sender, EventArgs e)
        {
            //lstRTs.Columns[4].Width = lstRTs.Width - 100 * 4 - SystemInformation.VerticalScrollBarWidth;
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStation.SelectedItem.ToString() == "failed to load")
                return;

            listRTsPopulate(((BaseStation)cmbStation.SelectedItem).GetBS_ID(), RTs);
        }
    }
}