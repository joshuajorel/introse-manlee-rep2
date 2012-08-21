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
        public GDScales()
        {
            stat = new Boolean[15];
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
