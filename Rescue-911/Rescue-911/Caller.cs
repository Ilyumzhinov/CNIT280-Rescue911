using System;

namespace Rescue_911
{
    public class Caller
    {
        private string Phone_Number;
        private string Name;

        public void SetPhone_Number(string xPhone_Number) { Phone_Number = xPhone_Number; }
        public void SetName(string xName) { Name = xName; }


        public string GetPhone_Number() { return Phone_Number; }
        public string GetName() { return Name; }
    }
}