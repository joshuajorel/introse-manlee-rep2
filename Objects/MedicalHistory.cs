using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MedicalHistory
    {
        private string diag;
        private string place;
        private DateTime inc;
        private UInt16 ID;

        public MedicalHistory()
        {
            diag = place = "";
            ID = 0;
        }

        public void setMH(String d, String p, DateTime dt)
        {
            diag = d;
            place = p;
            inc = dt;
        }

        public String getDiag()
        {
            return diag;
        }

        public String getPla()
        {
            return place;
        }

        public DateTime getDate()
        {
            return inc;
        }

        public void setDiag(string d)
        {
            diag = d;
        }

        public void setPla(string p)
        {
            place = p;
        }

        public void setDate(DateTime dt)
        {
            inc = dt;
        }
    }
}
