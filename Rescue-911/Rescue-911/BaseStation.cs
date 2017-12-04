using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class BaseStation
    {
        private int BS_ID;
        private string BS_Name;
        private string BS_Location;

        public BaseStation()
        {
        }

        public int GetBS_ID()
        {
            return BS_ID;
        }

        public string GetBS_Name()
        {
            return BS_Name;
        }

        public string GetBS_Location()
        {
            return BS_Location;
        }

        public void SetBS_ID(int xBS_ID)
        {
            this.BS_ID = xBS_ID;
        }

        public void SetBS_Name(string xBS_Name)
        {
            this.BS_Name = xBS_Name;
        }

        public void SetBS_Location(string xBS_Location)
        {
            this.BS_Location = xBS_Location;
        }


    }
}
