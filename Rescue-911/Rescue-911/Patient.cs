using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class patient : Person
    {
        private string age;
        private string bd;
        private string bloodtype;
        private string complication;
        private string subscribe;
        public void setsubsc(string sub) {
            subscribe = sub;
        }

        public string getsubsc()
        {
            return subscribe;
        }

        public patient()
        {


        }
        public void setage(string xage)
        {
            age = xage;

        }
        public void setbd(string xbd)
        {
            bd = xbd;

        }
        public void setbloodtype(string xbloodtype)
        {
            bloodtype = xbloodtype;

        }
        public void setcomplication(string xcomplication)
        {
            complication = xcomplication;

        }
        public string getage()
        {
            return age;

        }
        public string getbd()
        {
            return bd;

        }
        public string getbloodtype()
        {
            return bloodtype;

        }
        public string getcomplication()
        {
            return complication;

        }
    }
}
