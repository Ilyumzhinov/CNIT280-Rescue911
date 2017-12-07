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
    public partial class Dispatch_Report_View : Special_View, IUserDependent
    {
        //To-Do: change it to dispatch object
        private Special_List<Dispatch_Report> DispatchReports;

        // CONSTRUCTORS
        //To-setup the view.
        public Dispatch_Report_View(bool toDisplay, ref Special_List<Dispatch_Report> xDRs) : this(toDisplay)
        {
            DispatchReports = xDRs;
        }

        //To-display the view.
        public Dispatch_Report_View(bool toDisplay) : base(toDisplay)
        {
            if (toDisplay)
            {
                InitializeComponent();
            }
        }
        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is EMT)
            {

            }
            else
            {
                btnSubmit.Enabled = false;
                SendStatusUpdate(true, "To access, you must have EMT access level!", "urgent");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double Bill;

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

            //Type Check
            if (double.TryParse(txtBill.Text, out Bill) == false)
            {
                MessageBox.Show("Enter a number for Fee.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                SendStatusUpdate(true, "Report Saved!", "success");
            }
        }
    }
}
