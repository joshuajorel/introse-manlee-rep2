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
