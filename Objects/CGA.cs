using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class CGA
    {
        private Patient patient;
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
            patient = new Patient();
            physician = new Physician();
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

        public void setPat(Patient pat)
        {
            patient = pat;
        }
        public void setIns(String ins)
        {
            insurance = ins;
        }
        public void setPhy(Physician phy)
        {
            physician = phy;
        }
        public void setPpc(String ppc)
        {
            prefPlaCon = ppc;
        }
        public void setCid(int cid)
        {
            cgaId = cid;
        }
        public void setPH(PersonalHistory p)
        {
            ph = p;
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
