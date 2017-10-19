using System;

namespace Rescue_911
{
    class Emergency
    {
        private int Emergency_ID;
        private Emergency_Call[] Linked_Calls = new Emergency_Call[1];

        public Emergency()
        {
            //TEST DATA
            Linked_Calls[0] = new Emergency_Call();
            Linked_Calls[0].SetDateTime(DateTime.Now);
            Linked_Calls[0].SetDescription("Something happened");
            Linked_Calls[0].SetState("Logged");
            //
        }

        public void SetEmergency_ID(int xEmergency_ID) { Emergency_ID = xEmergency_ID; }

        public int GetEmergency_ID() { return Emergency_ID; }
        public Emergency_Call[] GetLinkedCalls() { return Linked_Calls; }
    }
}
