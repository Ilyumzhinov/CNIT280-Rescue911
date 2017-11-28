using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Employee : Person
    {
        private int Employee_ID;
        private string Password;

        public void SetEmployee_ID(int xEmployee_ID) { Employee_ID = xEmployee_ID; }

        public int GetEmployee_ID() { return Employee_ID; }

        public void SetPassword(string xPassword) { Password = xPassword; }

        public string GetPassword() { return Password; }
    }
}
