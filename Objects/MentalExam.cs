using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MentalExam
    {
        private Boolean[] ans;

        public MentalExam()
        {
            ans = new Boolean[30];
        }

        public void setAns(int n, bool a)
        {
            ans[n] = a;
        }

        public Boolean getAns(int n)
        {
            return ans[n];
        }

        public int getScore()
        {
            int score;
            score = ans.Where(c => c == true).Count();
            return score;
        }
    }
}