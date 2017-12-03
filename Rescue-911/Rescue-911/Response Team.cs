using System;
using System.Collections.Generic;
namespace Rescue_911
{
    public class Response_Team
    {
        private int ID;
        private int Grade;
        private string Shift;
        private List<EMT> EMTs;
        
        public void SetID(int xID) { ID = xID; }
        public void SetGrade(int xGrade) { Grade = xGrade; }
        public void SetShift(string xShift) { Shift = xShift; }

        public int GetID() { return ID; }
        public int GetGrade() { return Grade; }
        public string GetShift() { return Shift; }

        public override string ToString()
        {
            return "Response Team ID " + ID.ToString();
        }
        public void SetEMt(List<EMT> xEMTs) {
            EMTs = xEMTs;
        }
        public List<EMT> GetEmt() {
            return EMTs;
        }
    }
}
