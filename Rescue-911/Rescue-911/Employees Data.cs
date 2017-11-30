using System;
using System.Collections.Generic;

namespace Rescue_911
{
    class Employees_Data
    {
        // 0.Employee object,
        // 1.Employee_ID,
        // 2.Password.
        private Tuple<EMT, int, string>[] EMTs;

        public Employees_Data(ref Shared_Data xSD)
        {
            SetupEMTs(xSD.GetEMTs());
        }

        private void SetupEMTs(List<EMT> EMTs_Existing)
        {
            EMTs = new Tuple<EMT, int, string>[4];

            // Jane
            EMTs[0] = Tuple.Create(EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "qwerty");
            // Tyler
            EMTs[1] = Tuple.Create(EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "123");
            // John
            EMTs[2] = Tuple.Create(EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "john");
            // Shawn
            EMTs[3] = Tuple.Create(EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "111");
        }
    }
}