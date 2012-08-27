using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FunctionalStatus
    {
        private Boolean[] stat;
        private int num = 0;
        private UInt16 ID;
        public const int size = 12;

        public FunctionalStatus()
        {
            ID = 0;
            stat = new Boolean[size];
        }

        public FunctionalStatus(Boolean[] ans)
        {
            stat = ans;
        }

        //int n corresponds to the order of stats based on the cga (starting from 0)
        //true = independent, false = dependent
        public void setStat(Boolean s, int n)
        {
            stat[n] = s;
        }

        public bool getStat(int n)
        {
            return stat[n];
        }
    }
}
