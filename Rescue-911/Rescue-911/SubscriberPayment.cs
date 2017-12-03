using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class SubscriberPayment
    {
        private int SubscriberID;
        private string CreditCardNumber;
        private DateTime ExpiryDate;
        private string CVC;

        public SubscriberPayment()
        {
        }

        public int GetSubscriberID()
        {
            return SubscriberID;
        }

        public string GetCreditCardNumber()
        {
            return CreditCardNumber;
        }

        public DateTime GetExpiryDate()
        {
            return ExpiryDate;
        }

        public string GetCVC()
        {
            return CVC;
        }

        public void SetSubscriberID(int xSubscriberID)
        {
            this.SubscriberID = xSubscriberID;
        }

        public void SetCreditCardNumber(string xCreditCardNumber)
        {
            this.CreditCardNumber = xCreditCardNumber;
        }

        public void SetExpiryDate(DateTime xExpiryDate)
        {
            this.ExpiryDate = xExpiryDate;
        }

        public void SetCVC(string xCVC)
        {
            this.CVC = xCVC;
        }
    }
}
