using System;

namespace Rescue_911
{
    public class Emergency_Call
    {
        public Emergency_Call()
        {
            Emergency_Caller = new Caller();
        }

        private Caller Emergency_Caller;
        private DateTime DateTime;
        private string Address;
        private string Landmark;
        private string Description;
        private int Priority;
        private string State;
        private int Teams_Required;

        public void SetEmergency_Caller(Caller xCaller) { Emergency_Caller = xCaller; }
        public void SetDateTime(DateTime xDateTime) { DateTime = xDateTime; }
        public void SetAddress(string xAddress) { Address = xAddress; }
        public void SetLandmark(string xLandmark) { Landmark = xLandmark; }
        public void SetDescription(string xDesc) { Description = xDesc; }
        public void SetPriority(int xPriority) { Priority = xPriority; }
        public void SetState(string xState) { State = xState; }
        public void SetTeams_Required(int xTeamsReq) { Teams_Required = xTeamsReq; }

        public Caller GetEmergency_Caller() { return Emergency_Caller; }
        public DateTime GetDateTime() { return DateTime; }
        public string GetAddress() { return Address; }
        public string GetLandmark() { return Landmark; }
        public string GetDescription() { return Description; }
        public int GetPriority() { return Priority; }
        public string GetState() { return State; }
        public int GetTeams_Required() { return Teams_Required; }
    }
}
