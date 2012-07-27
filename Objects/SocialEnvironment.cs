using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class SocialEnvironment
    {
        private ArrayList segList;

        public SocialEnvironment()
        {        
            segList = new ArrayList();
        }

        public void setSEG(string nme, string rlp, string fv)
        {
            SEGroup seg = new SEGroup();
            seg.name = nme;
            seg.rel = rlp;
            seg.freVis = fv;

            segList.Add(seg);
        }
        
        //int refers to which arraylist

        public string getNme(int n)
        {
            SEGroup seg = new SEGroup();
            seg = (SEGroup)segList[n];

            return seg.name;
        }

        public string getRlp(int n)
        {
            SEGroup seg = new SEGroup();
            seg = (SEGroup)segList[n];

            return seg.rel;
        }

        public string getFv(int n)
        {
            SEGroup seg = new SEGroup();
            seg = (SEGroup)segList[n];

            return seg.freVis;
        }
    }

    class SEGroup
    {
        public string name;
        public string rel;
        public string freVis;
    }
}
