using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class CGA
    {
        private UInt16 pID;
        public UInt16 PID
        {
            get { return pID; }
            set { pID = value; }
        }

        private UInt16 cID;
        public UInt16 CID
        {
            get { return cID; }
            set { cID = value; }
        }

        private UInt16 phyID;
        public UInt16 PHYID
        {
            get { return phyID; }
            set { phyID = value; }
        }
        private Physician physician;
        private string insurance;
        private string prefPlaCon;
        private PersonalHistory ph;
        private FamilyHistory fh;
        private SocialEnvironment se;
        private MedicalHistory mh;
        private MedicationList ml;
        private Immunization im;
        private FunctionalStatus fs;
        private GDScales gd;
        private MentalExam me;
        private Nutrition nu;
        private CGiverAssess ca;

        private int cgaId;

        public CGA()
        {
            pID = 0;
            ph = new PersonalHistory();
            fh = new FamilyHistory();
            se = new SocialEnvironment();
            mh = new MedicalHistory();
            ml = new MedicationList();
            im = new Immunization();
            fs = new FunctionalStatus();
            gd = new GDScales();
            me = new MentalExam();
            nu = new Nutrition();
            ca = new CGiverAssess();
        }

        public void setIns(String ins)
        {
            insurance = ins;
        }

        public String getIns()
        {
            return insurance;
        }
        
        public void setPpc(String ppc)
        {
            prefPlaCon = ppc;
        }

        public String getPpc()
        {
            return prefPlaCon;
        }

        public void setCid(int cid)
        {
            cgaId = cid;
        }
        public void setPH(PersonalHistory p)
        {
            ph = p;
        }

        public PersonalHistory getPH()
        {
            return ph;
        }

        public void setFH(FamilyHistory f)
        {
            fh = f;
        }
        public void setSE(SocialEnvironment s)
        {
            se = s;
        }
        public void setMH(MedicalHistory m)
        {
            mh = m;
        }
        public void setML(MedicationList m)
        {
            ml = m;
        }
        public void setIm(Immunization i)
        {
            im = i;
        }
        public void setFS(FunctionalStatus f)
        {
            fs = f;
        }
        public void setGD(GDScales g)
        {
            gd = g;
        }
        public void setME(MentalExam m)
        {
            me = m;
        }
        public void setNu(Nutrition n)
        {
            nu = n;
        }
        public void setCAss(CGiverAssess c)
        {
            ca = c;
        }

    }
}
