using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class CGiverAssess
    {
        private bool[] ans;

        public CGiverAssess()
        {
            ans = new bool[] { false, false, false, false };
        }

        public void setAns(int n, bool x)
        {
            ans[n] = x;
        }

        public bool getAns(int n)
        {
            return ans[n];
        }
    }
}
