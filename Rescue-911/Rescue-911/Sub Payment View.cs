using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Sub_Payment_View : Special_View, IUserDependent
    {
        private Special_List<SubscriberPayment> SubscriberPayments;
        private SubscriberPayment creditpayment;

        // CONSTRUCTORS
        //To setup the view
        public Sub_Payment_View(bool toDisplay, ref Special_List<SubscriberPayment> xSPs) : this(toDisplay)
        {
            SubscriberPayments = xSPs;
        }

        //To-display
        public Sub_Payment_View(bool toDisplay) : base(toDisplay, "Sub Payment", Color.PowderBlue, false)
        {
            if (toDisplay)
            {
                InitializeComponent();

                DTPExpiryDate.Format = DateTimePickerFormat.Custom;
                DTPExpiryDate.CustomFormat = "MM/yy";
            }
        }



        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Manager)
            {

            }
            else
            {
                btnPay.Enabled = false;
                SendStatusUpdate(true, "To access, you must have Manager acess level!", "urgent");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int CVC;
           

            // Existence checks
            if (txtCreditCardNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Credit Card Number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCreditCardNumber.Focus();
                return;
            }

            if (txtCVC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter CVC Code.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCVC.Focus();
                return;
            }

            //Type check
            if (int.TryParse(txtCVC.Text, out CVC) == false)
            {
                MessageBox.Show("Enter real numbers for CVC field.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCVC.Focus();
                return;
            }
         
            else // All checks are satisfied
            {
                SubscriberPayment creditpayment = new SubscriberPayment();

                creditpayment.SetSubscriberID((int)numSubID.Value);
                creditpayment.SetCreditCardNumber(txtCreditCardNumber.Text);
                creditpayment.SetExpiryDate(DTPExpiryDate.Value);
                creditpayment.SetCVC(txtCVC.Text);

                SendStatusUpdate(true, "Payment Received, Thank you for your Payment!", "success");

            }
        }

        
    }
}
