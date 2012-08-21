using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MentalExam
    {
        private Boolean[] stat;

        public MentalExam()
        {
            stat = new Boolean[30];
        }

        public MentalExam(Boolean[] ans)
        {
            stat = ans;
        }

        public void setAns(int n, bool a)
        {
            stat[n] = a;
        }

        public Boolean getAns(int n)
        {
            return stat[n];
        }

        public int getScore()
        {
            int score;
            score = stat.Where(c => c == true).Count();
            if (score == 29)
                score = 30;
            return score;
        }
    }
}