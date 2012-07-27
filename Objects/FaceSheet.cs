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
        private bool[] casMan, homVac;
        private bool carTra, ambWel, senRes;
        private CostTable cost;

        public FaceSheet()
        {
            physicianID = 0;
            clientID = 0;
            patientID = 0;
            casMan = new bool[4];
            homVac = new bool[4];
            carTra = new bool();
            ambWel = new bool();
            senRes = new bool();
        }

        


    }
}