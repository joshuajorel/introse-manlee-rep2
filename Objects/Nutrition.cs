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
        private int proteinCtr = 0;

        public Nutrition()
        {
            nut = new float[] { 3, 1, 1, 3, 0, 1, 2, 2, 2, 2, 1, 2, 0, 0, 2, 1, 2 };
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

        public void proAdd()
        {
            if(proteinCtr < 3)
                proteinCtr++;
            Console.WriteLine(proteinCtr);
        }

        public void proSub()
        {
            if (proteinCtr != 0)
                proteinCtr--;
            Console.WriteLine(proteinCtr);
        }

        public float getScore()
        {
            if (proteinCtr < 2)
            {
                nut[12] = 0;
            }
            else if (proteinCtr == 2)
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
