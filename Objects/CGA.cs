using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class CGA
    {
        private Patient patient;
        private String insurance;
        private Physician physician;
        private String prefPlaCon;
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
     

    }
}
