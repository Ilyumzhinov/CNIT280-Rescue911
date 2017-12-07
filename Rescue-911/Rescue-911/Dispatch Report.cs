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
        private string Emergency_ID;
        private int rtID;
        public void SetrtID(int rtID)
        {
            this.rtID = rtID;
        }
        public void SetEmergency_ID(string Emergency_ID)
        {
            this.Emergency_ID = Emergency_ID;
        }
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
        public string GetEmergency_ID()
        {
            return Emergency_ID;
        }
        public int GetrtID()
        {
            return rtID;
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
