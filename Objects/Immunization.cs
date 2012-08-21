using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class Immunization
    {
        private DateTime tet, pne, inf, oth;

        public Immunization()
        {
            tet = new DateTime();
            pne = new DateTime();
            inf = new DateTime();
            oth = new DateTime();
        }

        public Immunization(DateTime t, DateTime p, DateTime i, DateTime o)
        {
            tet = t;
            pne = p;
            inf = i;
            oth = o;
        }

        public void setTet(DateTime t)
        {
            tet = t;
        }

        public void setPne(DateTime p)
        {
            pne = p;
        }

        public void setInf(DateTime i)
        {
            inf = i;
        }

        public void setOth(DateTime o)
        {
            oth = o;
        }

        public DateTime getTet()
        {
            return tet;
        }

        public DateTime getPne()
        {
            return pne;
        }        

        public DateTime getInf()
        {
            return inf;
        }

        public DateTime getOth()
        {
            return oth;
        }
    }
}
