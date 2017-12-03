using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Caller
    {
        private string Phone_Number;
        private string Name;
        private Patient Linked_Patient;

        public Caller()
        {
            Linked_Patient = new Patient();
        }

        public void SetPatient(Patient xPatient)
        {
            Linked_Patient = xPatient;
        }
        public void SetPhone_Number(string xPhone_Number) { Phone_Number = xPhone_Number; }
        public void SetName(string xName) { Name = xName; }

        public string GetPhone_Number() { return Phone_Number; }
        public string GetName() { return Name; }

        public Patient GetPatient() { return Linked_Patient; }
    }
}