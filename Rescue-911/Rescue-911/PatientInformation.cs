using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class PatientInformation
    {
        private string PatientName;
        private DateTime Birthdate;
        private string BloodType;
        private string complication;
        private int age;

        public PatientInformation()
        {
        }

        public string GetPatientName()
        {
            return PatientName;
        }

        public DateTime GetBirthDate()
        {
            return Birthdate;
        }

        public string GetBloodType()
        {
            return BloodType;
        }

        public string Getcomplication()
        {
            return complication;
        }

        public int Getage()
        {
            return age;
        }

        public void SetPatientName(string xPatientName)
        {
            this.PatientName = xPatientName;
        }

        public void SetBirthdate(DateTime xBirthdate)
        {
            this.Birthdate = xBirthdate;
        }

        public void SetBloodType(string xBloodType)
        {
            this.BloodType = xBloodType;
        }

        public void Setcomplication(string xComplication)
        {
            this.complication = xComplication;
        }

        public void Setage(int xage)
        {
            this.age = xage;
        }
    }
}
