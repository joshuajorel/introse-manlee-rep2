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

        //scores are based on CGA form.
       /* public int computeScore()
        {
            int y = 0;
            
            for (int x = 0; x < 15; x++)
            {
                if (x == 0 || x == 4 || x == 6 || x == 10 || x == 11 || x == 12)
                {
                    if (stat[x] == false)
                        y++;
                }

                if (x == 1 || x == 2 || x == 3 || x == 5 || x == 7 || x == 8 || x == 9 || x == 13 || x == 14)
                {
                    if (stat[x] == true)
                        y++;
                }
            }

            return y;
        }*/

        public int computeScore()
        {
            int y = 0;
            y = stat.Where(c => c == true).Count();
            return y;
        }
    }
}
