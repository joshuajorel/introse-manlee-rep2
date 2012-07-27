using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class MentalExam
    {
        private int[] ori, reg, attCal, rec, lang;

        public MentalExam()
        {
            ori = new int[10];
            reg = new int[3];
            attCal = new int[5];
            rec = new int[3];
            lang = new int[8];
        }

        public void setOri(int n, int x)
        {
            ori[n] = x;
        }

        public void setReg(int n, int x)
        {
            reg[n] = x;
        }

        public void setAC(int n, int x)
        {
            attCal[n] = x;
        }

        public void setRec(int n, int x)
        {
            rec[n] = x;
        }

        public void setLang(int n, int x)
        {
            lang[n] = x;
        }

        public int getOri(int n)
        {
            return ori[n];
        }

        public int getReg(int n)
        {
            return reg[n];
        }

        public int getAC(int n)
        {
            return reg[n];
        }

        public int (int n)
        {
            return reg[n];
        }

        public int getLang(int n)
        {
            return lang[n];
        }

    }
}
