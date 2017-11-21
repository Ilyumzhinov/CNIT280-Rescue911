using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Link_View : Special_View
    {
        private Emergency_Call Current_Call;
        private int emergencySelected;

        public Emergency_Link_View(ref Shared_Data xSD, Emergency_Call xCurrentCall) : base(ref xSD, "Link to Emergency", false, Color.Green)
        {
            // Change it
            Current_Call = xCurrentCall;

            InitializeComponent();

            lbCallState.Text = Current_Call.GetState();
            lbAddress.Text = Current_Call.GetAddress();
            txtDescription.Text = Current_Call.GetDescription();

            if (SD.Emergencies[0] != null)
            {
                lstEmergencies.Visible = true;
                lstEmergenciesFetch("Logged", SD.Emergencies);
            }
        }

        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            try
            {
                SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].AddLinked_Call(Current_Call);

                SD.UpdateSD(ref SD);

                lstEmergenciesFetch("Logged", SD.Emergencies);

                btnLinkEmergency.Visible = false;

                // To-Do: Update listViews in other forms.
                // foreach (Emergency_Management_Form CWF in CWFs)
                // {
                //    for (int i = 0; i < CWF.GetLstEmergencies().Items.Count; i++)
                //    {
                //        if (CWF.GetLstEmergencies().Items[i].Text == Emergency.GetEmergency_ID().ToString())
                //        {
                //            CWF.GetLstEmergencies().Items[i].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                //        }
                //    }
                //}
            }
            catch { }
        }

        private void lstEmergenciesFetch(string state, List<Emergency> ExistingEmergencies)
        {
            lstEmergencies.Items.Clear();

            foreach (Emergency iEmergency in ExistingEmergencies)
            {
                int j = 0;

                if (iEmergency.GetLinkedCalls()[0].GetState() != state)
                    continue;

                foreach (Emergency_Call EC in iEmergency.GetLinkedCalls())
                {
                    if (EC == null)
                        break;

                    if (j == 0)
                    {
                        ListViewItem lstItem = new ListViewItem(iEmergency.GetEmergency_ID().ToString());

                        lstItem.SubItems.Add(EC.GetDateTime().ToString("h:mm:ss MM/dd/yyyy "));
                        lstItem.SubItems.Add(EC.GetState());
                        lstItem.SubItems.Add(EC.GetDescription());

                        lstEmergencies.Items.AddRange(new ListViewItem[1] { lstItem });
                    }
                    else
                    {
                        ListViewItem lstItem = new ListViewItem();

                        lstItem.SubItems.Add(EC.GetDateTime().ToString("h:mm:ss MM/dd/yyyy "));
                        lstItem.SubItems.Add(EC.GetState());
                        lstItem.SubItems.Add(EC.GetDescription());

                        lstEmergencies.Items.AddRange(new ListViewItem[1] { lstItem });
                    }
                    j++;
                }
            }
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                emergencySelected = lstEmergencies.SelectedIndices[0];

                btnLinkEmergency.Visible = true;
            }
            catch
            {

            }
        }
    }
}
