using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class EMT : Employee
    {
        public EMT() { }
        private Response_Team RT;
        private TimeSpan TotalShifttime;
        private DateTime shiftLOGINTIME;
        private String shifttime;
        private string status;
        private int Teamnumber;

        // SETs & GETs

        public void SetTeamnumber(int xTeamnumber) { Teamnumber = xTeamnumber; }
        public int GetTeamNumber() { return Teamnumber; }

        public void SetResponseTeam(Response_Team xRT) { RT = xRT; }
        public TimeSpan getTotalShiftTime() { return TotalShifttime; }

        public void setShiftLoginTime(DateTime xshiftlogintime) {
            shiftLOGINTIME = xshiftlogintime;
        }
        public DateTime getshiftlogintime() { return shiftLOGINTIME; }
        public string getshifttime() { return shifttime; }
        public void setShifttime(string xshifttime) {

            shifttime = xshifttime;
}
        public void updatetotaolshifttime(TimeSpan xtime) {

            TotalShifttime+=xtime;
           
        }
        public void setstatus(string xstatus) {
            status = xstatus;
        }


        public Response_Team GetResponseTeam() { return RT; }
        public string getstatus() { return status; }
        //
    }
}
