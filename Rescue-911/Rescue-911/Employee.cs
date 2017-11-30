using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Employee : Person
    {
        // DATA STRUCTURE
        //Primitives
        private int Employee_ID;
        private DateTime HireDate;
        private DateTime ReleaseDate;
        private string Email;
        private string Phone_Number;
        private int Manager_ID;
        //


        // SETs & GETs
        public void SetEmployee_ID(int xEmployee_ID) { Employee_ID = xEmployee_ID; }
        public void SetHireDate(DateTime xHireDate) { HireDate = xHireDate; }
        public void SetReleaseDate(DateTime xReleaseDate) { ReleaseDate = xReleaseDate; }
        public void SetEmail(string xEmail) { Email = xEmail; }
        public void SetPhone_Number(string xPhone_Number) { Phone_Number = xPhone_Number; }
        public void SetManager_ID(int xManager_ID) { Manager_ID = xManager_ID; }

        public int GetEmployee_ID() { return Employee_ID; }
        public DateTime GetHireDate() { return HireDate; }
        public DateTime GetReleaseDate() { return ReleaseDate; }
        public string GetEmail() { return Email; }
        public string GetPhone_Number() { return Phone_Number; }
        public int GetManager_ID() { return Manager_ID; }
        //
    }
}
