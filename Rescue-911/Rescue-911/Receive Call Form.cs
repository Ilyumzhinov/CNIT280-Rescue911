using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Receive_Call_Form : General_Form
    {
        private Response_Team Response_Team;
        private Emergency_Management_Form[] CWFs;
        private Emergency Emergency;
        private int emergencySelected;
        public Receive_Call_Form(ref Shared_Data xSD) : base(ref xSD)
        {
            InitializeComponent();

            // CHANGE
            Response_Team = xSD.ResponseTeams[0];
            SD = xSD;
        }

        public Receive_Call_Form(Emergency xEmergency, Response_Team xRT, ref Shared_Data xSD) : this(ref xSD)
        {
            InitializeComponent();

            Name = "Receive Call";
            Emergency = xEmergency;
            Response_Team = xRT;

            // RE-DO THIS
            int j = 0;
            for (int i = 0; i < SD.OpenForms.GetLength(0); i++)
            {
                if (SD.OpenForms[0, i] != null)
                    j++;
            }

            CWFs = new Emergency_Management_Form[j];

            for (int i = 0; i < SD.OpenForms.GetLength(0); i++)
            {
                if (SD.OpenForms[0, i] != null)
                    CWFs[i] = (Emergency_Management_Form)SD.OpenForms[0, i];
            }
        }

        private void Receive_Call_Form_Load(object sender, EventArgs e)
        {
            lbRT_ID.Text = Response_Team.GetID().ToString();

            lstEmergencies_Fetch();
        }

        // If a team approves an emergency.
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Accepted");
            ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

            lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();

            foreach (Emergency_Management_Form CWF in CWFs)
            {
                for (int i = 0; i < CWF.GetLstEmergencies().Items.Count; i++)
                {
                    if (CWF.GetLstEmergencies().Items[i].Text == Emergency.GetEmergency_ID().ToString())
                    {
                        CWF.GetLstEmergencies().Items[i].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                    }
                }
            }

            lstEmergencies.Enabled = false;
            rbYes.Enabled = false;
            rbNo.Enabled = false;
        }

        // If a team rejects an emergency.
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Declined");
            ((Form1)SD.OpenForms[2, 0]).UpdateSD(SD);

            lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();


            foreach (Emergency_Management_Form CWF in CWFs)
            {
                for (int i = 0; i < CWF.GetLstEmergencies().Items.Count; i++)
                {
                    if (CWF.GetLstEmergencies().Items[i].Text == Emergency.GetEmergency_ID().ToString())
                    {
                        CWF.GetLstEmergencies().Items[i].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                    }
                }
            }


            lstEmergencies.Enabled = false;
            rbYes.Enabled = false;
            rbNo.Enabled = false;
        }

        public void lstEmergencies_Fetch()
        {
            if (Emergency != null)
            {
                int j = 0;

                foreach (Emergency_Call EC in Emergency.GetLinkedCalls())
                {
                    if (j == 0)
                    {
                        ListViewItem lstItem = new ListViewItem(Emergency.GetEmergency_ID().ToString());

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
                lstEmergencies.Visible = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Receive_Call_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
