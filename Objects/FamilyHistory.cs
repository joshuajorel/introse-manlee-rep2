using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FamilyHistory
    {
        private bool diabetes;
        private bool cancer;
        private bool tub;
        private bool bleDis;

        public FamilyHistory()
        {
            diabetes = new bool();
            cancer = new bool();
            tub = new bool();
            bleDis = new bool();
        }

        public void setFH(bool dbs, bool cnr, bool tbs, bool bdr)
        {
            diabetes = dbs;
            cancer = cnr;
            tub = tbs;
            bleDis = bdr;
        }

        public bool getDbs()
        {
            return diabetes;
        }

        public bool getCan()
        {
            return cancer;
        }

        public bool getTub()
        {
            return tub;
        }

        public bool getBD()
        {
            return bleDis;
        }
    }
}
