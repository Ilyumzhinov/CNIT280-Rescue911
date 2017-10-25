using System;

namespace Rescue_911
{
    public class Dispatch
    {
        private Response_Team RT;
        private Emergency Emergency;

        public void SetRT(Response_Team xRT) { RT = xRT; }
        public void SetEmergency(Emergency xEmergency) { Emergency = xEmergency; }

        public Response_Team GetRT() { return RT; }
        public Emergency GetEmergency() { return Emergency; }
    }
}
