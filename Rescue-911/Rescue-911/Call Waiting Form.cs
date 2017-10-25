using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Call_Waiting_Form : Form
    {
        private Emergency[] ExistingEmergencies;
        private Response_Team[] ResponseTeams;
        private Shared_Data SD;

        public Call_Waiting_Form(ref Shared_Data xSD)
        {
            SD = xSD;

            InitializeComponent();
        }

        public Call_Waiting_Form()
        {
        }

        private void Call_Waiting_Form_Load(object sender, EventArgs e)
        {
            // Receving Shared Data.
            ResponseTeams = SD.ResponseTeams;

            // Populating the listBox with the response teams.
            foreach (Response_Team RT in ResponseTeams)
            {
                lstTeams.Items.Add(new ListViewItem(RT.GetID().ToString()));
            }

            // TEST DATA
            ExistingEmergencies = SD.Emergencies;
            //

            foreach (Emergency existingEmergency in ExistingEmergencies)
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

        private void button1_Click(object sender, EventArgs e)
        {
            lstEmergencies.Visible = true;
        }



        private void btnCreateDispatch_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Emergency iEmergency in ExistingEmergencies)
                {
                    if (lstEmergencies.SelectedItems[0].Text != iEmergency.GetEmergency_ID().ToString())
                        continue;

                    // Create a new Receive Call Form and pass emergency into it
                    // Also, pass team information into it
                    SD.OpenForms[1, (int.Parse(lstTeams.SelectedItems[0].Text) - 1)] = new Receive_Call_Form(iEmergency, ResponseTeams[int.Parse(lstTeams.SelectedItems[0].Text) - 1], ref SD);

                    // Update the Shared Data values regarding the Forms.
                    ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

                    lbResult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in " + this + ": " + ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ListView GetLstEmergencies()
        {
            return lstEmergencies;
        }
    }
}