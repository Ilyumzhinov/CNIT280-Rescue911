using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Form : Form
    {
        private Emergency_Call Current_Call;

        public Emergency_Form()
        {
            InitializeComponent();

            Current_Call = new Emergency_Call();
        }
        int Teamsavalible = 120;
        private void btnCreateEmergency_Click(object sender, EventArgs e)
        {

            Current_Call.SetState("ready");
            Emergency Emergencies = new Emergency();
            Emergencies.SetEmergency_ID(11112);
            btnCreateEmergency1.Visible = true;
            btnCreateEmergency.Visible = false;
            btnLinkEmergency.Visible = false;
            lbTitle.Text = "Creat a Emergency Record";
            lstEmergencies.Location = new System.Drawing.Point(20, 40);
            lbemergencyid.Visible = true;
            lbemergencylocation.Visible = true;
            lvemergencydecreption.Visible = true;
        
            lbemergencystats.Visible = true;
            txtemergencyd.Visible = true;
            lbel.Visible = true;
            lbemergencyid1.Visible = true;
           
            lbes.Visible = true;
     
            lbes.Text = Current_Call.GetTeams_Required().ToString();
            lbel.Text = Current_Call.GetAddress().ToString();
            lbemergencyid1.Text = Emergencies.GetEmergency_ID().ToString();
            txtemergencyd.Text = Current_Call.GetDescription();
            lbes.Text = Current_Call.GetState();
           

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

        private void Emergency_Form_Load(object sender, EventArgs e)
        {

        }

        public void SetEmergency_Call(Emergency_Call xEmergency_Call) {
            Current_Call = xEmergency_Call; }

        private void btnCreateEmergency1_Click(object sender, EventArgs e)
        {
           
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
