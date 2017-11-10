using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    class patient:Person
    {
       private string age { get; set; }
        private string bd { get; set; }
        private string bloodtype { get; set; }
        private string complication { get; set; }
        public patient(string age, string bd,string bloodtype, string complication) {

            this.age = age;
            this.bd = bd;
            this.bloodtype = bloodtype;
            this.complication = complication;
        }
    }
}
