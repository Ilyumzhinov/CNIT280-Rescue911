using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Management_View : Special_View
    {
        private Emergency mSelectedEmergency;

        // CONSTRUCTORS
        //To-display the view.
        public Emergency_Management_View(ref Shared_Data xSD) : base(ref xSD, "Emergency Management", false, Color.IndianRed)
        {
            InitializeComponent();

            // Emergency list set-up.
            if (SD.Emergencies[0] != null)
            {
                Emergency_Management_View_SizeChanged(this, null);
                emergencyList.EmergencySelected += new EventHandler(Emergency_List_Item_Selected);
                emergencyList.SetEmergency_List(ref SD.Emergencies);
            }
        }

        //To-instantiate the view.
        public Emergency_Management_View() : base("Emergency Management", false, Color.IndianRed)
        { }
        //

        private void Emergency_List_Item_Selected(object sender, EventArgs e)
        {


            try
            {
                mSelectedEmergency = (Emergency)sender;

                // Populating the listBox with the response teams.
                foreach (Response_Team RT in SD.ResponseTeams)
                {
                    // To-Do: get the actual emergency call selected
                    if (mSelectedEmergency.GetLinkedCalls()[0].GetPriority() <= 2)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }

                    if (mSelectedEmergency.GetLinkedCalls()[0].GetPriority() <= 3 && RT.GetGrade() > 1)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }

                    if (mSelectedEmergency.GetLinkedCalls()[0].GetPriority() <= 4 && RT.GetGrade() > 2)
                    {
                        ListViewItem lstItem = new ListViewItem(RT.GetID().ToString());

                        lstItem.SubItems.Add(RT.GetGrade().ToString());
                        lstTeams.Items.AddRange(new ListViewItem[1] { lstItem });
                        continue;
                    }
                }



                lbResult.Visible = true;
                rbYes.Visible = true;
                rbNo.Visible = true;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emergencyList.Visible = true;
        }



        private void btnCreateDispatch_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Emergency iEmergency in SD.Emergencies)
                {
                   // if (lstEmergencies.SelectedItems[0].Text != iEmergency.GetEmergency_ID().ToString())
                   //     continue;

                    // Update the Shared Data values regarding the Forms.
                    SD.UpdateSD(ref SD);

                    lbResult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in " + this + ": " + ex.Message);
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Accepted");
                //SD.UpdateSD(ref SD);

                //lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                //rbYes.Checked = false;
                //lstEmergenciesFetch("Logged", SD.Emergencies);



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
                //SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].SetState("Waiting");
                ////SD.UpdateSD(ref SD);

                //lstEmergencies.Items[emergencySelected].SubItems[2].Text = SD.Emergencies[int.Parse(lstEmergencies.SelectedItems[0].Text)].GetLinkedCalls()[0].GetState();
                //rbNo.Checked = false;

                //lstEmergenciesFetch("Logged", SD.Emergencies);


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

        private void Emergency_Management_View_SizeChanged(object sender, EventArgs e)
        {
            emergencyList.Width = this.Width;
        }
    }
}