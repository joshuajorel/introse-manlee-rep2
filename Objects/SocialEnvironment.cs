using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class SocialEnvironment
    {
        
        private SEGroup seg;

        static List<SEGroup> segList;

        public SocialEnvironment()
        {
            SEGroup seg = new SEGroup();
            segList = new List<SEGroup>();
        }

        public void setSEG(string nme, string rlp, string fv)
        {
            seg.name = nme;
            seg.rel = rlp;
            seg.freVis = fv;

            segList.Add(seg);
        }
            
    }

    class SEGroup
    {
        public string name;
        public string rel;
        public string freVis;
    }
}
