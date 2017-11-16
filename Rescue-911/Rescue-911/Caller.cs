using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Caller
    {
        private string Phone_Number;
        private string Name;
        private List<Patient> patients;
        private int temp = 0;

        public void setPatient(Patient xpatient) {
            patients.Add(new Patient());
            patients[temp] = xpatient;
            temp++;
        }
        public void SetPhone_Number(string xPhone_Number) { Phone_Number = xPhone_Number; }
        public void SetName(string xName) { Name = xName; }


        public string GetPhone_Number() { return Phone_Number; }
        public string GetName() { return Name; }
    }
}