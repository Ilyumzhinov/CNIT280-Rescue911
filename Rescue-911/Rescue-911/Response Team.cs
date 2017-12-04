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
        private bool[] Status = new bool[5];
        private string TeamStatus;
        private BaseStation BaseStation;

        public void SetBaseStation(BaseStation xBaseStation) { BaseStation = xBaseStation; }
        public BaseStation GetBaseStation() { return BaseStation; }
        public void SetStatusByEmt(bool xstatus,int EMTInTeam) {
            Status[EMTInTeam] = xstatus;
            int temp = 0;
            for (int a = 0; a < 5; a++) {
                if (Status[a] == true) {
                    temp++;
                }
            }
            if (temp >= 3||TeamStatus != "Dispatched") {
              TeamStatus = "Avalible";
            }else if (temp < 3)
            {
                TeamStatus = "Non-Avalible";
            }
            
        }
        public void SetStatusByDispatch(string xstatus) {
            TeamStatus = xstatus;
        }
        public string GetTeamstatus() { return TeamStatus; }
    
        

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
