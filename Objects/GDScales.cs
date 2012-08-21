using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class GDScales
    {
        private Boolean[] stat;
        private int y = 0;
        public const int LENGTH = 15;
        public GDScales()
        {
            stat = new Boolean[LENGTH];
        }

        public GDScales(Boolean[] ans)
        {
            stat = ans;
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



        public int computeScore()
        {
            y = stat.Where(c => c == true).Count();
            return y;
        }

        public String assess()
        {
            if (y < 5)
            {
                return "Normal";
            }
            else if (y < 11)
            {
                return "Mild to moderate depression";
            }
            else
            {
                return "Score suggests severe depression";
            }
        }
    }
}
