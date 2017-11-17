using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Management_Form : Special_Form
    {
        private int emergencySelected;

        public Emergency_Management_Form(ref Shared_Data xSD) : base(ref xSD, "Emergency Management")
        {
            InitializeComponent();
        }

        private void Call_Waiting_Form_Load(object sender, EventArgs e)
        {
         
            lstEmergenciesFetch("Logged", SD.Emergencies);
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
                        lstItem.SubItems.Add(EC.GetPriority().ToString());
                        lstItem.SubItems.Add(EC.GetState());
                        lstItem.SubItems.Add(EC.GetDescription());

                        lstEmergencies.Items.AddRange(new ListViewItem[1] { lstItem });
                    }
                    else
                    {
                        ListViewItem lstItem = new ListViewItem();

                        lstItem.SubItems.Add(EC.GetDateTime().ToString("h:mm:ss MM/dd/yyyy "));
                        lstItem.SubItems.Add(EC.GetPriority().ToString());
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

                lstTeams.Items.Clear();
                // Populating the listBox with the response teams.
                foreach (Response_Team RT in SD.ResponseTeams)
                {
                    if (int.Parse(lstEmergencies.SelectedItems[0].SubItems[2].Text) <= 2)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }

                    if (int.Parse(lstEmergencies.SelectedItems[0].SubItems[2].Text) <=3 && RT.GetGrade() > 1)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }

                    if (int.Parse(lstEmergencies.SelectedItems[0].SubItems[2].Text) <= 4 && RT.GetGrade() > 2)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }
                }



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
                foreach (Emergency iEmergency in SD.Emergencies)
                {
                    if (lstEmergencies.SelectedItems[0].Text != iEmergency.GetEmergency_ID().ToString())
                        continue;

                    // Create a new Receive Call Form and pass emergency into it
                    // Also, pass team information into it
                    SD.OpenForms[1, (int.Parse(lstTeams.SelectedItems[0].Text) - 1)] = new Response_Team_Information_Form(iEmergency, SD.ResponseTeams[int.Parse(lstTeams.SelectedItems[0].Text) - 1], ref SD);

                    // Update the Shared Data values regarding the Forms.
                    ((Login_Form)SD.LoginForm).UpdateSD(SD);

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
                ((Login_Form)SD.LoginForm).UpdateSD(SD);

                lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                rbYes.Checked = false;
                lstEmergenciesFetch("Logged", SD.Emergencies);



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
                ((Login_Form)SD.LoginForm).UpdateSD(SD);

                lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                rbNo.Checked = false;

                lstEmergenciesFetch("Logged", SD.Emergencies);


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