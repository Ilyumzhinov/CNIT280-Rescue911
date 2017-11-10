using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public abstract class Person
    {
        private string Name;
        private string Last_Name;
        private string Phone_Number;
        private string Address;

        public void SetName(string xName) { Name = xName; }
        public void SetLast_Name(string xLastName) { Last_Name = xLastName; }
        public void SetPhone_Number(string xPhoneNumber) { Phone_Number = xPhoneNumber; }
        public void SetAddress(string xAddress) { Address = xAddress; }

        public string GetName() { return Name; }
        public string GetLast_Name() { return Last_Name; }
        public string GetPhone_Number() { return Phone_Number; }
        public string GetAddress() { return Address; }
    }
}