using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Operator : Employee
    {
        // DATA STRUCTURE
        //Primitives
        private int Operator_ID;
        //

        // SETs & GETs
        public void SetOperator_ID(int xOperator_ID)
        {
            Operator_ID = xOperator_ID;
        }

        public int GetOperator_ID()
        {
            return Operator_ID;
        }
        //
    }
}
