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
    public partial class Invoice_View : Special_View, IUserDependent
    {
        private Special_List<InvoiceReceipt> InvoiceReceipts;
        private InvoiceReceipt InvoicePayment;

        // CONSTRUCTORS
        //To-setup the view      
        public Invoice_View(bool toDisplay, ref Special_List<InvoiceReceipt> xIVs) : this(toDisplay)
        {
            InvoiceReceipts = xIVs;
        }

        //To-display the view.
        public Invoice_View(bool toDisplay) : base(toDisplay, "Invoice", Color.DeepPink, false)
        {
            if (toDisplay)
            {
                InitializeComponent();              
            }
        }

        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Manager)
            {
                // To-Do: Set up the view with the appropriate user data
            }
            else
            {
                btnGenerate.Enabled = false;
               

                lstInvoice.Enabled = false;

                SendStatusUpdate(true, "To access, you must have Manager access level!", "urgent");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double monthlyfee;

            // Existence checks
            if (txtMonthlyFee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Monthly Fee", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMonthlyFee.Focus();
                return;
            }

            if (double.TryParse(txtMonthlyFee.Text, out monthlyfee) == false)
            {
                MessageBox.Show("Enter a number for Fee.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMonthlyFee.Focus();
                return;
            }
            

            else // All checks are satisfied
            {
                InvoiceReceipt InvoicePayment = new InvoiceReceipt();

                InvoicePayment.SetSubscriberID((int)NUDSubID.Value);                
                InvoicePayment.SetMonthlyFee(double.Parse(txtMonthlyFee.Text));
                InvoicePayment.SetRenewalDate(DTPRenewalDate.Value);

                lstInvoice.Items.Add(lstInvoiceFetch(InvoicePayment));
                SendStatusUpdate(true, "Records Generated!", "success");

            }
        }
            private ListViewItem lstInvoiceFetch(InvoiceReceipt xInvoice)
        {
            ListViewItem lstInvoice = new ListViewItem(xInvoice.GetSubscriberID().ToString());            
            lstInvoice.SubItems.Add(xInvoice.GetMonthlyBill().ToString());
            lstInvoice.SubItems.Add(xInvoice.GetRenewalDate().ToLongDateString());

            return lstInvoice;
        }
    


    }
}
