using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MedicalHistory
    {
        private ArrayList medH;

        public MedicalHistory()
        {
            medH = new ArrayList();
        }

        public void setMH(String d, String p, DateTime dt)
        {
            bio b = new bio();
            b.diag = d;
            b.place = p;
            b.date = dt;
            medH.Add(b);
        }

        public String getDiag(int n)
        {
            bio temp = new bio();
            temp = (bio)medH[n];

            return temp.diag;
        }

        public String getPla(int n)
        {
            bio temp = new bio();
            temp = (bio)medH[n];

            return temp.place;
        }

        public DateTime getDate(int n)
        {
            bio temp = new bio();
            temp = (bio)medH[n];

            return temp.date;
        }
    }

    class bio
    {
        public String diag;
        public String place;
        public DateTime date;
    }

}
