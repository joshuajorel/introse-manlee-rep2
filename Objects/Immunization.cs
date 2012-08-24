using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class Immunization
    {
        private DateTime Date;
        private string Desc;
        private UInt16 ID;

        public Immunization()
        {
            Date = new DateTime();
            ID = 0;
        }
        
        public Immunization(string dsc, DateTime dte)
        {
            Desc = dsc;
            Date = dte;
        }

        public void setDesc(string dsc)
        {
            Desc = dsc;
        }

        public void setDate(DateTime dte)
        {
            Date = dte;
        }

        public string getDesc()
        {
            return Desc;
        }

        public DateTime getDate()
        {
            return Date;
        }
    }
}
