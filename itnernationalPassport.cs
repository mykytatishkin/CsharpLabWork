using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelStatement
{
    internal class itnernationalPassport
    {
        protected String ? NSL = null;
        protected String ? beginDate = null;
        protected String ? endDate = null;

        public itnernationalPassport()
        {
            NSL = "empty";
            beginDate = "empty";
            endDate = "empty";
        }
        public itnernationalPassport(String NSL)
        {
            this.NSL = NSL;
            beginDate = "empty";
            endDate = "empty";
        }
        public itnernationalPassport(String NSL, String beginDate)
        {
            this.NSL = NSL;
            this.beginDate = beginDate;
            endDate = "empty";
        }
        public itnernationalPassport(String NSL, String beginDate, String endDate)
        {
            this.NSL = NSL;
            this.beginDate = beginDate;
            this.endDate = endDate;
        }

        public string nsl
        {
            get { return NSL; }
            set { NSL = value; }
        }
        public string BeginDate
        {
            get { return beginDate; }
            set { beginDate = value; }
        }
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

    }
}
