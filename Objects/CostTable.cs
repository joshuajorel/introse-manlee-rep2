using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class CostTable
    {
        private float mdNightPay;
        private float mdMeals;
        private float mdOvertime;
        private float mdNightDiff;
        private float mdHolidayPay;
        private float mdTransportation;
        private float mdSomething;
        private float mdLessWtTax;
        private float mdNoPax;
        private float mdTotal;
        private float mdSubTotal;

        private float hcNightPay;
        private float hcMeals;
        private float hcOvertime;
        private float hcNightDiff;
        private float hcHolidayPay;
        private float hcTransportation;
        private float hcSomething;
        private float hcLessWtTax;
        private float hcNoPax;
        private float hcTotal;
        private float hcSubTotal;


        public CostTable()
        {
            mdHolidayPay = mdLessWtTax = 0;
            mdMeals = mdNightDiff = 0;
            mdNightPay = mdNoPax = 0;
            mdOvertime = mdSomething = 0;
            mdTransportation = 0;
            mdTotal = mdSubTotal = 0;

            hcHolidayPay = hcLessWtTax = 0;
            hcMeals = hcNightDiff = 0;
            hcNightPay = hcNoPax = 0;
            hcOvertime = hcSomething = 0;
            hcTransportation = 0;
            hcTotal = hcSubTotal = 0;

        }

        public void setMDParams(float np,float m, float o, float nd, float h, float t, float s, float lwt, float pax)
        {
            mdNightPay = np;
            mdMeals = m;
            mdOvertime = o;
            mdNightDiff = nd;
            mdHolidayPay = h;
            mdTransportation = t;
            mdSomething = s;
            mdLessWtTax = lwt;
            mdNoPax = pax;
        }
        public void setHCParams(float np, float m, float o, float nd, float h, float t, float s, float lwt, float pax)
        {
            hcNightPay = np;
            hcMeals = m;
            hcOvertime = o;
            hcNightDiff = nd;
            hcHolidayPay = h;
            hcTransportation = t;
            hcSomething = s;
            hcLessWtTax = lwt;
            hcNoPax = pax;
        }

        public float getNightPay(bool option)
        {
            if (option)
            {
                return mdNightPay;
            }
            else
            {
                return hcNightPay;
            }

        }
        public float getMeals(bool option)
        {
            if (option)
            {
                return mdMeals;
            }
            else
            {
                return hcMeals;
            }

        }
        public float getOvertime(bool option)
        {
            if (option)
            {
                return mdOvertime;
            }
            else
            {
                return hcOvertime;
            }

        }
        public float getNightDifferential(bool option)
        {
            if (option)
            {
                return mdNightDiff;
            }
            else
            {
                return hcNightDiff;
            }

        }
        public float getHolidayPay(bool option)
        {
            if (option)
            {
                return mdHolidayPay;
            }
            else
            {
                return hcHolidayPay;
            }

        }
        public float getTransportation(bool option)
        {
            if (option)
            {
                return mdTransportation;
            }
            else
            {
                return hcTransportation;
            }

        }
        public float getSomething(bool option)
        {
            if (option)
            {
                return mdSomething;
            }
            else
            {
                return hcSomething;
            }

        }
        public float getLessWTTax(bool option)
        {
            if (option)
            {
                return mdLessWtTax;
            }
            else
            {
                return hcLessWtTax;
            }

        }
        public float getNoPax(bool option)
        {
            if (option)
            {
                return mdNoPax;
            }
            else
            {
                return hcNoPax;
            }

        }



    }
}
