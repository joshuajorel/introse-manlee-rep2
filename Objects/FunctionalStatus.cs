using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FunctionalStatus
    {
        private Boolean[] stat;

        public FunctionalStatus()
        {
            stat = new Boolean[13];
        }

        public FunctionalStatus(Boolean[] ans)
        {
            stat = ans;
        }

        //int n corresponds to the order of stats based on the cga (starting from 0)
        //true = independent, false = dependent
        public void setStat(int n, bool s)
        {
            stat[n] = s;
        }

        public bool getStat(int n)
        {
            return stat[n];
        }
    }
}
