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
    public partial class Dispatch_Report_View : Special_View
    {
        //To-Do: change it to dispatch object
        private Emergency CurrentDispatch;

        // CONSTRUCTORS
        //To-display the view.
        public Dispatch_Report_View(ref Shared_Data xSD) : base(ref xSD, "Dispatch Report", false, Color.PaleVioletRed)
        {
            //To-Do: Change this.
            CurrentDispatch = SD.GetEmergencies()[1];

            InitializeComponent();
        }

        //To-instantiate the view.
        public Dispatch_Report_View() : base("Dispatch Report", false, Color.PaleVioletRed)
        { }
        //

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

            else if (txtBill.Text.Trim() == string.Empty)
            {
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

                Dispatch_Report DispatchReport = new Dispatch_Report();

                DispatchReport.SetHospital(txtHospital.Text);


                SD.AddDispatchReport(DispatchReport);
            }
        }

        private void Dispatch_Report_Load(object sender, EventArgs e)
        {
            // To-Do: make it dynamic

            lbEmergencyID.Text = CurrentDispatch.GetEmergency_ID().ToString();
        }
    }
}
