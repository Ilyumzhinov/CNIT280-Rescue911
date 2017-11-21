using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Response_Team_Information_View : Special_View
    {
        private Response_Team Response_Team;
        private Emergency_Management_View[] CWFs;
        private Emergency Emergency;

        // CONSTRUCTORS
        //To-display the view.
        public Response_Team_Information_View(ref Shared_Data xSD) : base(ref xSD, "Response Team Info", false, Color.SandyBrown)
        {
            InitializeComponent();

            // CHANGE
            Response_Team = xSD.ResponseTeams[0];
            SD = xSD;
        }

        //To-instantiate the view.
        public Response_Team_Information_View() : base("Response Team Info", false, Color.SandyBrown)
        { }

        //To-display a context-aware view.
        public Response_Team_Information_View(Emergency xEmergency, Response_Team xRT, ref Shared_Data xSD) : this(ref xSD)
        {
            InitializeComponent();

            Emergency = xEmergency;
            Response_Team = xRT;

            // RE-DO THIS
            int j = 0;
            //for (int i = 0; i < SD.OpenViews.GetLength(0); i++)
            //{
            //    if (SD.OpenViews[0, i] != null)
            //        j++;
            //}

            CWFs = new Emergency_Management_View[j];

            //for (int i = 0; i < SD.OpenViews.GetLength(0); i++)
            //{
            //    if (SD.OpenViews[0, i] != null)
            //        CWFs[i] = (Emergency_Management_View)SD.OpenViews[0, i];
            //}
        }
        //

        private void Receive_Call_Form_Load(object sender, EventArgs e)
        {
            lbRT_ID.Text = Response_Team.GetID().ToString();

            lstEmergencies_Fetch();
        }

        // If a team approves an emergency.
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        // If a team rejects an emergency.
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {

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


        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void Receive_Call_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
