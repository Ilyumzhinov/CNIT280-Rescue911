using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Emergency_Call
    {
        // DATA STRUCTURE
        //Primitives
        private DateTime DateTime;
        private string Address;
        private string Landmark;
        private string Description;
        private int Priority;
        private string State;
        private int Teams_Required;

        //Associations
        private Caller Emergency_Caller;
        private Emergency EmergencyLinked;
        //

        //Event Handlers
        public event EventHandler Call_Updated;
        //


        public Emergency_Call()
        {
            Emergency_Caller = new Caller();
            EmergencyLinked = new Emergency();
        }

        public void SetEmergency_Caller(Caller xCaller)
        {
            Emergency_Caller = xCaller;
            Call_Updated?.Invoke(this, null);
        }
        public void SetDateTime(DateTime xDateTime)
        {
            DateTime = xDateTime;
            Call_Updated?.Invoke(this, null);
        }
        public void SetAddress(string xAddress)
        {
            Address = xAddress;
            Call_Updated?.Invoke(this, null);
        }
        public void SetLandmark(string xLandmark)
        {
            Landmark = xLandmark;
            Call_Updated?.Invoke(this, null);
        }
        public void SetDescription(string xDesc)
        {
            Description = xDesc;
            Call_Updated?.Invoke(this, null);
        }
        public void SetPriority(int xPriority)
        {
            Priority = xPriority;
            Call_Updated?.Invoke(this, null);
        }
        public void SetState(string xState)
        {
            State = xState;
            Call_Updated?.Invoke(this, null);
        }
        public void SetTeams_Required(int xTeamsReq)
        {
            Teams_Required = xTeamsReq;
            Call_Updated?.Invoke(this, null);
        }
        public void SetEmergency(Emergency xEmergency)
        {
            EmergencyLinked = xEmergency;
            Call_Updated?.Invoke(this, null);
        }


        public Caller GetEmergency_Caller() { return Emergency_Caller; }
        public Emergency GetEmergency() { return EmergencyLinked; }
        public DateTime GetDateTime() { return DateTime; }
        public string GetAddress() { return Address; }
        public string GetLandmark() { return Landmark; }
        public string GetDescription() { return Description; }
        public int GetPriority() { return Priority; }
        public string GetState() { return State; }
        public int GetTeams_Required() { return Teams_Required; }
    }
}