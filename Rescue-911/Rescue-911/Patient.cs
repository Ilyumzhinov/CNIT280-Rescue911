using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Patient : Person
    {
        private string age;
        private string bloodtype;
        private string complication;
        private string subscribe;
        private List<Caller> AssociatedPNumbers;

        public Patient()
        {
            AssociatedPNumbers = new List<Caller>(); }

        public void setsubsc(string sub) {
            subscribe = sub;
        }

        public void setage(string xage)
        {
            age = xage;

        }

        public void setbloodtype(string xbloodtype)
        {
            bloodtype = xbloodtype;

        }

        public void setcomplication(string xcomplication)
        {
            complication = xcomplication;

        }

        public void AddAssociatedPNumber(Caller xPhoneNumber)
        {
            AssociatedPNumbers.Add(xPhoneNumber);
        }

        public List<Caller> GetAssociatedPNumber()
        {
            return AssociatedPNumbers;

        }

        public string getage()
        {
            return age;

        }
        public string getbloodtype()
        {
            return bloodtype;

        }
        public string getcomplication()
        {
            return complication;

        }

        public string getsubsc()
        {
            return subscribe;
        }
    }
}