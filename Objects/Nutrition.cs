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

        public Nutrition()
        {
            nut = new float[17];
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

        public float getScore()
        {
            return nut.Sum();
        }

    }
}
