using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Dispatch_Report : Special_Form
    {
        //To-Do: change it to dispatch object
        private Emergency CurrentDispatch;

        public Dispatch_Report(ref Shared_Data xSD) : base(ref xSD, "Dispatch Report")
        {
            CurrentDispatch = SD.Emergencies[1];

            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Existence checks
            if (txtHospital.Text.Trim() == string.Empty)
            {
                txtHospital.Focus();
                return;

            }
            else if (txtProcedureDetails.Text.Trim() == string.Empty)
            {
                txtHospital.Focus();
                return;
            }
            else if (txtBill.Text.Trim() == string.Empty) {
                txtBill.Focus();
                return;
            }
            else // All checks are satisfied
            {
                txtHospital.Enabled = false;
                txtProcedureDetails.Enabled = false;
                chkVital.Enabled = false;
                txtBill.Enabled = false;

                btnSubmit.Visible = false;
            }
        }

        private void Dispatch_Report_Load(object sender, EventArgs e)
        {
            // To-Do: make it dynamic
            lbCallID.Text = CurrentDispatch.GetLinkedCalls()[0].GetEmergency_Caller().GetCaller_ID().ToString();

            lbEmergencyID.Text = CurrentDispatch.GetEmergency_ID().ToString();
        }
    }
}
