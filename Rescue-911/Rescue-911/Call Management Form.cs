using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Management_Form : Form
    {
        private Emergency[] ExistingEmergencies;
        private Response_Team[] ResponseTeams;
        private Shared_Data SD;
        private int emergencySelected;

        public Emergency_Management_Form(ref Shared_Data xSD)
        {
            SD = xSD;

            InitializeComponent();
        }

        public Emergency_Management_Form()
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

            lstEmergenciesFetch("Logged");
        }

        private void lstEmergenciesFetch(string state)
        {
            // TEST DATA
            ExistingEmergencies = SD.Emergencies;
            //
            lstEmergencies.Items.Clear();

            foreach (Emergency existingEmergency in ExistingEmergencies)
            {
                int j = 0;

                if (existingEmergency.GetLinkedCalls()[0].GetState() != state)
                    continue;

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

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                emergencySelected = lstEmergencies.SelectedIndices[0];

                lbDecision.Visible = true;
                rbYes.Visible = true;
                rbNo.Visible = true;
            }
            catch
            {

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

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Accepted");
                ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

                lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                rbYes.Checked = false;
                lstEmergenciesFetch("Logged");



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

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Waiting");
                ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

                lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                rbNo.Checked = false;

                lstEmergenciesFetch("Logged");


                //foreach (Emergency_Management_Form CWF in CWFs)
                //{
                //    for (int i = 0; i < CWF.GetLstEmergencies().Items.Count; i++)
                //    {
                //        if (CWF.GetLstEmergencies().Items[i].Text == Emergency.GetEmergency_ID().ToString())
                //        {
                //            CWF.GetLstEmergencies().Items[i].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                //        }
                //    }
                //}
            }
            catch
            {

            }
        }
    }
}