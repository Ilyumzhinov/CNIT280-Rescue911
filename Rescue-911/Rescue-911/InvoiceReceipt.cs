using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
   public class InvoiceReceipt
    {
        private int SubscriberID;
        private DateTime RenewalDate;
        private double MonthlyFee;

        public InvoiceReceipt()
        {
        }

        public int GetSubscriberID()
        {
            return SubscriberID;
        }

        public DateTime GetRenewalDate()
        {
            return RenewalDate;
        }

        public double GetMonthlyBill()
        {
            return MonthlyFee;
        }

        public void SetSubscriberID(int xSubscriberID)
        {
            this.SubscriberID = xSubscriberID;
        }

        public void SetRenewalDate(DateTime xRenewalDate)
        {
            this.RenewalDate = xRenewalDate;
        }

        public void SetMonthlyFee(double XMonthlyFee)
        {
            this.MonthlyFee = XMonthlyFee;
        }
    }
}
