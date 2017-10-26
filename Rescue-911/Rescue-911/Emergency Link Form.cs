using System;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Emergency_Link_Form : Form
    {
        private Shared_Data SD;
        private Emergency_Call Current_Call;

        public Emergency_Link_Form(ref Shared_Data xSD, Emergency_Call xCurrent_Call)
        {
            SD = xSD;
            Current_Call = xCurrent_Call;

            InitializeComponent();
        }

        private void btnLinkEmergency_Click(object sender, EventArgs e)
        {

        }

        private void Emergency_Link_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
