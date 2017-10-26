using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Link_Form : Form
    {
        private Shared_Data SD;
        private Emergency_Call Current_Call;
        private int emergencySelected;

        public Emergency_Link_Form(ref Shared_Data xSD, Emergency_Call xEC)
        {
            SD = xSD;
            Current_Call = xEC;

            InitializeComponent();
        }

        private void Emergency_Link_Form_Load(object sender, EventArgs e)
        {
            lstEmergencies_Fetch();
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                emergencySelected = lstEmergencies.SelectedIndices[0];
            }
            catch
            {

            }
        }


        public void lstEmergencies_Fetch()
        {
            if (SD.Emergencies[0] == null)
            {
                lstEmergencies.Visible = false;
                return;
            }
            lstEmergencies.Visible = true;

            foreach (Emergency existingEmergency in SD.Emergencies)
            {
                int j = 0;

                foreach (Emergency_Call EC in existingEmergency.GetLinkedCalls())
                {
                    if (j == 0)
                    {
                        ListViewItem lstItem = new ListViewItem(existingEmergency.GetEmergency_ID().ToString());

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

        //To-Do: Change the method name.
        private void btnCreateEmergency1_Click(object sender, EventArgs e)
        {
            if (emergencySelected == 0)
                return;

            Emergency_Call[] ECs = SD.Emergencies[emergencySelected].GetLinkedCalls();


            SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Declined");
            ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

            lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();

        }
    }
}
