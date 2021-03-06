﻿using System;
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
        private string Address;
        private string DOB;
        
        public void SetName(string xName) { Name = xName; }
        public void SetLast_Name(string xLastName) { Last_Name = xLastName; }
   
        public void SetAddress(string xAddress) { Address = xAddress; }
        public void SetDOB(string xDOB) { DOB = xDOB; }

        public string GetName() { return Name; }
        public string GetLast_Name() { return Last_Name; }
      
        public string GetAddress() { return Address; }
        public string GetDOB() { return DOB; }
    }
}