using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class GDScales
    {
        private Boolean[] stat;

        public GDScales()
        {
            stat = new Boolean[15];
        }

        //int n corresponds to the order of scales based on the cga (starting from 0)
        //true = yes, false = no

        public void setScale(int n, bool s)
        {
            stat[n] = s;
        }

        public bool getScale(int n)
        {
            return stat[n];
        }
    }
}
