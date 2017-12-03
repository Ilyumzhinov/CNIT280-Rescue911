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
        private Special_List<Dispatch_Report> DispatchReports;

        // CONSTRUCTORS
        //To-setup the view.
        public Dispatch_Report_View(bool toDisplay, ref Emergency xEmergency, ref Special_List<Dispatch_Report> xDRs) : this(toDisplay)
        {
            CurrentDispatch = xEmergency;
            DispatchReports = xDRs;
        }

        //To-display the view.
        public Dispatch_Report_View(bool toDisplay) : base(toDisplay, "Dispatch Report", Color.PaleVioletRed, false)
        {
            if (toDisplay)
            {
                InitializeComponent();
            }
        }
        //

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Existence checks
            if (txtHospital.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Hospital", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtHospital.Focus();
                return;

            }
            else if (txtProcedureDetails.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Procedure Details", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHospital.Focus();
                return;
            }

            else if (txtBill.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Bill Amount", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DispatchReport.SetProcedureDetail(txtProcedureDetails.Text);
                DispatchReport.SetVitalSign(chkVital.Checked);
                DispatchReport.SetBill(double.Parse(txtBill.Text));


                DispatchReports.AddItem(DispatchReport);
            }
        }

        private void Dispatch_Report_Load(object sender, EventArgs e)
        {
            // To-Do: make it dynamic

            lbEmergencyID.Text = CurrentDispatch.GetEmergency_ID().ToString();
        }
    }
}
