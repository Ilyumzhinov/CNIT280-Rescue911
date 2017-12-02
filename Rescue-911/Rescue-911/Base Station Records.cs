using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Base_Station_Records
    {     
        public Base_Station_Records()
        {
        }

        private string Record;
        public String GetRecord()
        {
            return Record;
        }

        private DateTime Date;

        public DateTime GetDate()
        {
            return Date;
        }

        public void SetDate(DateTime xDate)
        {
            this.Date = xDate;
        }
        public void SetRecord(string xRecord)
        {
            this.Record = xRecord;
        }
    }
}
