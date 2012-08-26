using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FunctionalStatus
    {
        private bool[] stat;
        private int num;
        private UInt16 ID;

        public FunctionalStatus()
        {
            ID = 0;
            bool[] stat = new bool[12];
        }

        public FunctionalStatus(bool ans, int n)
        {
            stat[n] = ans;
            num = n;
        }

        //int n corresponds to the order of stats based on the cga (starting from 0)
        //true = independent, false = dependent
        public void setStat(bool s, int n)
        {
            stat[n] = s;
        }

        public void setNum(int n)
        {
            num = n;
        }

        public bool getStat(int n)
        {
            return stat[n];
        }

        public int getNum()
        {
            return num;
        }
    }
}
