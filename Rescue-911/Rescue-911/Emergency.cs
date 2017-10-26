using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Emergency
    {
        private int Emergency_ID;
        private List<Emergency_Call> Linked_Calls = new List<Emergency_Call>();
        public Emergency()
        { 

        }

        public void SetEmergency_ID(int xEmergency_ID) { Emergency_ID = xEmergency_ID; }
        public void SetLinked_Calls(List<Emergency_Call> xCalls) { Linked_Calls = xCalls; }
        public void AddLinked_Call(Emergency_Call xCall) { Linked_Calls.Add(xCall); }

        public int GetEmergency_ID() { return Emergency_ID; }
        public List<Emergency_Call> GetLinkedCalls() { return Linked_Calls; }
    }
}
