using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MedicationList
    {
        private ArrayList medL;

        public MedicationList()
        {
            medL = new ArrayList();
        }

        public void setML(string med, float dose, string freq)
        {
            meds m = new meds();
            m.med = med;
            m.dose = dose;
            m.freq = freq;

            medL.Add(m);
        }

        public string getMed(int n)
        {
            meds temp = new meds();
            temp = (meds)medL[n];

            return temp.med;
        }

        public float getDos(int n)
        {
            meds temp = new meds();
            temp = (meds)medL[n];

            return temp.dose;
        }

        public string getFre(int n)
        {
            meds temp = new meds();
            temp = (meds)medL[n];

            return temp.freq;
        }
    }

    class meds
    {
        public string med;
        public float dose;
        public string freq;
    }
}
