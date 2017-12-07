using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Patient : Person
    {

        private string PatientID;
        private string InsuranceID;
        private string Gender;
        private string BloodType;
        private string complication;
       
     
      
        private SUB Subscribtion =new SUB();

        public void setPatientID(string xPatientID) { PatientID = xPatientID; }
        public void setInsuranceID(string xInsuranceID) { InsuranceID = xInsuranceID; }
        public void setGender(string xGender) { Gender = xGender; }
        public void setbloodtype(string xbloodtype) { BloodType = xbloodtype; }
        public void setcomplication(string xComplication) { complication = xComplication; }
        public void setSubscribtion(SUB xSubscribtion) {Subscribtion = xSubscribtion; }

        public string getPatientID() { return PatientID; }
        public string getInsuranceID() { return InsuranceID; }
        public string getGender() { return Gender; }
        public string getbloodtype() {return BloodType;  }
        public string getComplication(){return complication; }
        public SUB getSubscribtion() { return Subscribtion; }
    }
}