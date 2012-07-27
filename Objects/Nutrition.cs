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

        /*
        public void setNut(float bmi, float mac, float cc, float wgt, float ind, float pre, float psy, float mob, float neu, float neuP, float preS, float mel, float pro, float veg, float app, float flu, float fed)
        {
            this.bmi = bmi;
            this.mac = mac;
            this.cc = cc;
            this.wgt = wgt;
            this.ind = ind;
            this.pre = pre;
            this.psy = psy;
            this.mob = mob;
            this.neu = neu;
            this.neuP = neuP;
            this.preS = preS;
            this.mel = mel;
            this.pro = pro;
            this.veg = veg;
            this.app = app;
            this.flu = flu;
            this.fed = fed;
        }
        */

        //n = index x = score for the corresponding index
        public void setNut(int n, float x)
        {
            nut[n] = x;
        }

        public float getNut(int n)
        {
            return nut[n];
        }

        

     
    }
}
