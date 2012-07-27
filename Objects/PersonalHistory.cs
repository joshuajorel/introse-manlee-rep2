using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace introseHHC.Objects
{
    class PersonalHistory
    {
        private String allergy;
        private String smoke;              //in years
        private String drink;
        private String hobby;

        public PersonalHistory()
        {
        }
        
        //add string to array list
        /*
        public void setAlg(String alg)
        {
            allergy.Add(alg);

        }

        public void setSmk(String smk)
        {
            smoke = smk;
        }

        public void setDnk(String dnk)
        {
            drink = dnk;
        }

        public void setHby(ArrayList hby)
        {
            hobby = hby;
        }
        */

        public void setPH(String alg, String smk, String dnk, String hby)
        {
            allergy = alg;
            smoke = smk;
            drink = dnk;
            hobby = hby;
        }

        public string getAlg()
        {
            return allergy;
        }

        public string getSmk()
        {
            return smoke;
        }

        public string getDnk()
        {
            return drink;
        }

        public string getHby()
        {
            return hobby;
        }
    }
}
