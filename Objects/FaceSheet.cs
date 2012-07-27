﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FaceSheet
    {
        private UInt16 patientID;
        private UInt16 clientID;
        private UInt16 physicianID;
        private UInt16[] casMan, homVac;
        private bool carTra, ambWel, senRes;
        private CostTable cost;
        private string action;

        public FaceSheet()
        {
            physicianID = 0;
            clientID = 0;
            patientID = 0;
            cost = new CostTable();
            casMan = new UInt16[4];
            homVac = new UInt16[4];
            carTra = new bool();
            ambWel = new bool();
            senRes = new bool();
        }
       public void registerPatient(UInt16 id)
       {
           patientID = id;
       }
       public void registerClient(UInt16 id)
       {
           clientID = id;
       }
       public void registerPhysician(UInt16 id)
       {
           physicianID = id;
       }

        


    }
}