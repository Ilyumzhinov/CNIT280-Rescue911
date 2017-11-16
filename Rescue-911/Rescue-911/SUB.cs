using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class SUB
    {
        private string SubscriberMembershipNumber;
        private DateTime SubscriptionDate;
        private DateTime RenewalDate;
        private double MonthlyFee;
        private string TotalMonths;
        private string Subtitle;
        private Provider provider;

    
        public SUB(string SubscriberMembershipNumber,
         DateTime SubscriptionDate,
         DateTime RenewalDate,
         double MonthlyFee,
         string TotalMonths,
         string Subtitle,Provider provider
        )
        {
         this.provider = provider;
         this.SubscriberMembershipNumber = SubscriberMembershipNumber;
         this.SubscriptionDate = SubscriptionDate;
         this.RenewalDate = RenewalDate;
         this.TotalMonths = TotalMonths;
         this.Subtitle = Subtitle;
        }
        public SUB(string SubscriberMembershipNumber,
        DateTime SubscriptionDate,
        DateTime RenewalDate,
        double MonthlyFee,
        string TotalMonths,
        string Subtitle
        )
        {
          
            this.SubscriberMembershipNumber = SubscriberMembershipNumber;
            this.SubscriptionDate = SubscriptionDate;
            this.RenewalDate = RenewalDate;
            this.TotalMonths = TotalMonths;
            this.Subtitle = Subtitle;
        }

        public void setSubscriberMembershipNumber(string SubscriberMembershipNumber) { this.SubscriberMembershipNumber = SubscriberMembershipNumber; }
        public void setSubscriptionDate(DateTime SubscriptionDate) { this.SubscriptionDate = SubscriptionDate; }
        public void setRenewalDate(DateTime RenewalDate) { this.RenewalDate = RenewalDate; }
        public void setMonthlyFee(double MonthlyFee) { this.MonthlyFee = MonthlyFee; }
        public void setTotalMonths(string TotalMonths) { this.TotalMonths = TotalMonths; }
        public void setSubtitle(string Subtitle) { this.Subtitle = Subtitle; }
        public void setProvider(Provider provider) { this.provider = provider; }


        public string GetSubscriberMembershipNumber() { return SubscriberMembershipNumber; }
        public DateTime GetSubscriptionDate() { return SubscriptionDate; }
        public DateTime GetRenewalDate() { return RenewalDate; }
        public double GetMonthlyFee() { return MonthlyFee; }
        public string GetTotalMonths() { return TotalMonths; }
        public string GetSubtitle() { return Subtitle; }
        public Provider Getprovider() { return provider; }


    }
}
