using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Emergency
    {
        // DATA STRUCTURE
        //Primitives
        private int Emergency_ID;
        private string eType;

        //Associations
        private List<Emergency_Call> Linked_Calls;
        //

        //Event Handlers
        public event EventHandler EmergencyCall_Added;
        //


        public Emergency()
        {
            Linked_Calls = new List<Emergency_Call>();
        }


        public void SetEmergency_ID(int xEmergency_ID) { Emergency_ID = xEmergency_ID; }
        public void SetLinked_Calls(List<Emergency_Call> xCalls) { Linked_Calls = xCalls; }
        public void SetEType(string xeType) { eType = xeType; }
        public void AddLinked_Call(Emergency_Call xCall)
        {
            Linked_Calls.Add(xCall);
            EmergencyCall_Added?.Invoke(xCall, null);
        }

        public int GetEmergency_ID() { return Emergency_ID; }
        public string GetEType() { return eType; }
        public List<Emergency_Call> GetLinkedCalls() { return Linked_Calls; }
    }
}