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

        //Event Handlers
        public event EventHandler EmergencyCall_Updated;
        //


        public Emergency()
        { }


        public void SetEmergency_ID(int xEmergency_ID) { Emergency_ID = xEmergency_ID; }
        public void SetEType(string xeType) { eType = xeType; }
        public void AddLinked_Call(Emergency_Call xCall)
        {
            //Linked_Calls.Add(xCall);
            //Linked_Calls[Linked_Calls.Count - 1].Call_Updated += new EventHandler(UpdateEmergencyCalls);

            //EmergencyCall_Added?.Invoke(xCall, null);
        }

        private void UpdateEmergencyCalls(object sender, EventArgs e)
        {
            EmergencyCall_Updated?.Invoke((Emergency_Call)sender, null);
        }

        public int GetEmergency_ID() { return Emergency_ID; }
        public string GetEType() { return eType; }
    }
}