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
        public Sub_Payment_View(bool toDisplay) : base(toDisplay)
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
                SendStatusUpdate(true, "To access, you must have Manager access level!", "urgent");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Int64 CVC;
            Int64 CardNumber;
           

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

            //Length Check

           if (txtCreditCardNumber.Text.Length < 16 || txtCreditCardNumber.Text.Length > 16)
            {
                MessageBox.Show("Credit Card Number length should be 16 characters.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCreditCardNumber.Focus();
                return;
            }

            if (txtCVC.Text.Length < 3 || txtCVC.Text.Length > 3)
            {
                MessageBox.Show("CVC code length should be 3 characters.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCreditCardNumber.Focus();
                return;
            }



            //Type check
            if (Int64.TryParse(txtCVC.Text, out CVC) == false)
            {
                MessageBox.Show("Enter real numbers for CVC field.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCVC.Focus();
                return;
            }

            if (Int64.TryParse(txtCreditCardNumber.Text, out CardNumber) == false)
            {
                MessageBox.Show("Enter real numbers for Credit Card Number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCreditCardNumber.Focus();
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
