using System;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Emergency
    {
        private int Emergency_ID;
        private Emergency_Call[] Linked_Calls;
        public Emergency()
        { 

        }

        public void SetEmergency_ID(int xEmergency_ID) { Emergency_ID = xEmergency_ID; }
        public void SetLinked_Calls(Emergency_Call[] xCalls) { Linked_Calls = xCalls; }

        public int GetEmergency_ID() { return Emergency_ID; }
        public Emergency_Call[] GetLinkedCalls() { return Linked_Calls; }
    }
}
