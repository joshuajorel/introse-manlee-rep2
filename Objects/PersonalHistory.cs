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
            allergy = "";
            smoke = "";
            drink = "";
            hobby = "";
        }

        public PersonalHistory(String alg, String smk, String dnk, String hby)
        {
            allergy = alg;
            smoke = smk;
            drink = dnk;
            hobby = hby;
        }
        
        //add string to array list

        public void setAllergy(String alg)
        {
            allergy = alg;
        }

        public void setSmoke(String smk)
        {
            smoke = smk;
        }

        public void setDrink(String dnk)
        {
            drink = dnk;
        }

        public void setHobby(String hby)
        {
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
