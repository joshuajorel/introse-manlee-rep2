using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class PersonalHistory
    {
        private ArrayList allergy;
        private String smoke;              //in years
        private String drink;
        private ArrayList hobby;

        public PersonalHistory()
        {
            allergy = new ArrayList();
            hobby = new ArrayList();
        }

        public void setPH(ArrayList alg, String smk, String dnk, ArrayList hby)
        {
            allergy = alg;
            smoke = smk;
            drink = dnk;
            hobby = hby;
        }

    }
}
