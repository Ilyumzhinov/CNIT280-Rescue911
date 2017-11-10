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
        private String ResponseTeamID;
        private TimeSpan TotalShifttime;
        private DateTime shiftLOGINTIME;
        private String shifttime;
        private string status;

        public String getResponseTeamID() { return ResponseTeamID; }
        public void setResponseTeamID(string XResponseTeamID) { ResponseTeamID = XResponseTeamID; }
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
        public string getstatus() { return status; }
    }
}
