using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class SocialEnvironment
    {
        private string name;
        private string relation;
        private string freq;
        private UInt16 ID;

        public SocialEnvironment()
        {
            name = relation = freq = "";
            ID = 0;
        }

        public SocialEnvironment(string nme, string rlp, string fv)
        {
            name = nme;
            relation = rlp;
            freq = fv;
        }
        
        public void setNme(string nme)
        {
            name = nme;
        }

        public void setRlp(string rlp)
        {
            relation = rlp;
        }

        public void setFv(string fv)
        {
            freq = fv;
        }

        public string getNme()
        {
            return name;
        }

        public string getRlp()
        {
            return relation;
        }

        public string getFv()
        {
            return freq;
        }
    }
}
