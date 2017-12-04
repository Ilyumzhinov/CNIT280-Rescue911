using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    class Response_Team_Status
    {
        private int RT_ID;
        private DateTime RT_DateTime;
        private string RT_State;
        private int RT_ShiftGrade;

        public Response_Team_Status()
        {
        }

        public int GetRT_ID()
        {
            return RT_ID;
        }

        public DateTime GetRT_DateTime()
        {
            return RT_DateTime;
        }

        public string GetRT_State()
        {
            return RT_State;
        }

        public int GetRT_ShiftGrade()
        {
            return RT_ShiftGrade;
        }

        public void SetRT_ID(int xRT_ID)
        {
            this.RT_ID = xRT_ID;
        }

        public void SetRT_DateTime(DateTime xRT_DateTime)
        {
            this.RT_DateTime = xRT_DateTime;
        }

        public void SetRT_State(string xRT_State)
        {
            this.RT_State = xRT_State;
        }

        public void SetRT_ShiftGrade(int xRT_ShiftGrade)
        {
            this.RT_ShiftGrade = xRT_ShiftGrade;
        }

    }
}
