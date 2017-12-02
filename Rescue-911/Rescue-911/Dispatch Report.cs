using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Dispatch_Report
    {
        private string Hospital;
        private string ProcedureDetail;
        private bool VitalSign;
        private double Bill;

        public Dispatch_Report()
        {           
        }
        public String GetHospital()
        {
            return Hospital;
        }

        public string GetProcedureDetail()
        {
            return ProcedureDetail;
        }

        public bool GetVitalSign()
        {
            return VitalSign;
        }

        public double GetBill()
        {
            return Bill;
        }
            

        public void SetHospital(string xHos)
        {
            this.Hospital = xHos;
        }

        public void SetProcedureDetail(String XProcedureDetail)
        {
            this.ProcedureDetail = XProcedureDetail;
        }

        public void SetVitalSign(bool XVitalSign)
        {
            this.VitalSign = XVitalSign;
        }

        public void SetBill(double XBill)
        {
            this.Bill = XBill;
        }
    }
}
