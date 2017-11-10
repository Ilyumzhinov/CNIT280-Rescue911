using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Patient:Person
    {

        private string Bloodtype;
        private DateTime birthday;
        private string name;
        private double weight;
        
        public Patient(string xBloodtype,DateTime xbirthday, Caller xcaller,double xweight ) {

            birthday = xbirthday;           
            Bloodtype = xBloodtype;
            weight = xweight;
        }
      
        public string getbloodtype() {

            return Bloodtype;
        }
        public DateTime getbirthday() {

            return birthday;
        }



        





    }
    
}
