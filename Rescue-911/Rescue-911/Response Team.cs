using System;

namespace Rescue_911
{
    public class Response_Team
    {
        private int ID;
        private char Grade;
        private string Shift;
    
        public void SetID(int xID) { ID = xID; }
        public void SetGrade(char xGrade) { Grade = xGrade; }
        public void SetShift(string xShift) { Shift = xShift; }

        public int GetID() { return ID; }
        public char GetGrade() { return Grade; }
        public string GetShift() { return Shift; }

        public override string ToString()
        {
            return "Response Team ID " + ID.ToString();
        }
    }
}
