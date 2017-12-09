using System;

namespace Rescue_911
{
    public class Dispatch
    {
        private Response_Team RT;
        private Emergency Emergency;
        private string dispatchtime = "";
        private string dispatcharrivetime = "";
        private string Status;
        public void SetStatus(string xStatus) { Status = xStatus; }
        public string getStatus() { return Status; }
        public void SetResponseTeam(Response_Team xRT) { RT = xRT; }
        public void SetEmergency(Emergency xEmergency) { Emergency = xEmergency; }

        public Response_Team GetResponseTeam() { return RT; }
        public Emergency GetEmergency() { return Emergency; }


        public void setdispatchtime(string temp) {
            dispatchtime = temp;

        }
        public void setdispatcharrivetime(string temp)
        {
            dispatcharrivetime = temp;

        }
        public string getdispatch() {

            return dispatchtime;
        }
        public string getdispatcharrivetime()
        {

            return dispatcharrivetime;
        }

    }
}
