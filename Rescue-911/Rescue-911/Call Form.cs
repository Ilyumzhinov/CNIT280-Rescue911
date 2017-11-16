using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class CallForm : Special_Form
    {
        private Shared_Data SD;
        Emergency_Call Current_Call;
        List<Patient> Suggested_Patients = new List<Patient>();
        Call_View CV;

        public CallForm(ref Shared_Data xSD)
        {
            SD = xSD;
            Current_Call = new Emergency_Call();
            Current_Call.SetDateTime(DateTime.Now);

            Current_Call.SetState("Not Logged");

            SD.Calls.Add(Current_Call);
            // Update the Shared Data values regarding the Calls.
            ((Login_Form)SD.LoginForm).UpdateSD(SD);

            InitializeComponent();
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            CV = new Call_View(ref SD);
            CV.Dock = DockStyle.Fill;
            CV.OnUserControlButtonClicked += new EventHandler(btnEmergency_click);
            CV.Show();

            this.Controls.Add(CV);
        }

        private void btnEmergency_click(object sender, EventArgs e)
        {
            Emergency_Link_View EmergencyLinkControl = new Emergency_Link_View(ref SD);
            EmergencyLinkControl.Dock = DockStyle.Fill;
            EmergencyLinkControl.Show();

            this.Controls.Add(EmergencyLinkControl);

            CV.Hide();
        }
    }
}