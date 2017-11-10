using System;

namespace Rescue_911
{
    public class Caller : Person
    {
        private int Caller_ID;

        public void SetCaller_ID(int xCaller_ID) { Caller_ID = xCaller_ID; }

        public int GetCaller_ID() { return Caller_ID; }
    }
}
