using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class Nutrition
    {
        //private float bmi, mac, cc, wgt, ind, pre, psy, mob, neu, neuP, preS, mel, pro, veg, app, flu, fed;

        private float[] nut;
        private Boolean[] proteinIntake;     

        //check score at specific index to determine answer
        public Nutrition()
        {
            nut = new float[] { 3, 1, 1, 3, 0, 1, 2, 2, 2, 2, 1, 2, 0, 0, 2, 1, 2 };
            proteinIntake = new Boolean[] { false, false, false };
        }

      

        //n = index for the corresponding part of the assessment
        public void setNut(int n, float x)
        {
            nut[n] = x;
        }

        public float getNut(int n)
        {
            return nut[n];
        }

        public void proSet1(Boolean b)
        {
            proteinIntake[0] = b;
        }

        public void proSet2(Boolean b)
        {
            proteinIntake[1] = b;
        }

        public void proSet3(Boolean b)
        {
            proteinIntake[2] = b;
        }

        public float getScore()
        {
            int y = proteinIntake.Where(c => c == true).Count();
            if (y < 2)
            {
                nut[12] = 0;
            }
            else if (y == 2)
            {
                nut[12] = 0.5f;
            }
            else
                nut[12] = 1;

            return nut.Sum();
        }

        public String assess()
        {
            if (nut.Sum() < 17)
            {
                return "Malnourished";
            }
            else if (nut.Sum() < 24)
            {
                return "Risk for malnutrition";
            }
            else
                return "WELL NOURSIHED";
        }

    }
}
