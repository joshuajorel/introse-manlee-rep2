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
        private int cgaId;

        public CGA()
        {
            patient = new Patient();
            physician = new Physician();
        }

        public void setCGA(Patient pat, String ins, Physician phy, String ppc, int cid)
        {
            patient = pat;
            insurance = ins;
            physician = phy;
            prefPlaCon = ppc;
            cgaId = cid;
        }

     

    }
}
