using System;
using System.Collections.Generic;
namespace Rescue_911
{
    public class Response_Team
    {
        private int ID;
        private char Grade;
        private string Shift;
        private List<EMT> EMTs;
    
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
        public void setEMt(EMT xemt) {
            EMTs.Add(xemt);
        }
        public List<EMT> getEmt() {
            return EMTs;
        }
    }
}
