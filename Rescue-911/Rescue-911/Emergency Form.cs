using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Form : Form
    {
        public Emergency_Form()
        {
            InitializeComponent();
        }

        private void btnCreateEmergency_Click(object sender, EventArgs e)
        {

        }

        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {
            if (lstEmergencies.Visible)
            {
                this.Close();
                
            }

            // Adjust GUI
            btnCreateEmergency.Visible = false;
            btnLinkEmergency.Visible = false;
            lbTitle.Text = "Link to exsiting Emergency";
            lstEmergencies.Location = new System.Drawing.Point(20, 40);
            //

            // Initializing Emergency object
            Emergency Emergencies = new Emergency();
            Emergencies.SetEmergency_ID(111);

            // TEST DATA
            ListViewItem lstItem = new ListViewItem(Emergencies.GetEmergency_ID().ToString());

            lstItem.SubItems.Add(Emergencies.GetLinkedCalls()[0].GetDateTime().ToString("h:mm:ss MM/dd/yyyy "));
            lstItem.SubItems.Add(Emergencies.GetLinkedCalls()[0].GetState());
            lstItem.SubItems.Add(Emergencies.GetLinkedCalls()[0].GetDescription());

            lstEmergencies.Items.AddRange(new ListViewItem[] { lstItem });
            //

            // Final GUI adjustments
            lstEmergencies.Visible = true;
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLinkEmergency.Top = lstEmergencies.Bottom + 20;
            btnLinkEmergency.Text = "Link";

            btnLinkEmergency.Visible = true;
        }
    }
}
