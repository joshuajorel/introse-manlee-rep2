using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FaceSheet
    {
        private UInt16 fID;
        public UInt16 FID
        {
            get { return fID; }
            set { fID = value; }
        }
        private UInt16 patientID;
        public UInt16 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        private UInt16 clientID;
        public UInt16 ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        private UInt16 physicianID;
        public UInt16 PhysicianID
        {
            get { return physicianID; }
            set { physicianID = value; }
        }
        private UInt16[] casMan, homVac;
        private bool carTra;
        public bool CarTra
        {
            get { return carTra; }
            set { carTra = value; }
        }
        private bool ambWel;
        public bool AmbWel
        {
            get { return ambWel; }
            set { ambWel = value; }
        }
        private bool senRes;
        public bool SenRes
        {
            get { return senRes; }
            set { senRes = value; }
        }
        private CostTable cost;
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        private DateTime effectivityDate;

        public DateTime EffectivityDate
        {
            get { return effectivityDate; }
            set { effectivityDate = value; }
        }

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
            action = "";
        }

         public FaceSheet(int cmnum, int hvnum)
        {
            physicianID = 0;
            clientID = 0;
            patientID = 0;
            cost = new CostTable();
            casMan = new UInt16[cmnum];
            homVac = new UInt16[hvnum];
            carTra = new bool();
            ambWel = new bool();
            senRes = new bool();
            action = "";
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
        public void registerCostTable(CostTable c)
        {
            cost = c;
        }

        public void setCareTraining(bool option)
        {
            carTra = option;
        }
        public void setAmbWellness(bool option)
        {
            ambWel = option;
        }
        public void setSeniorResidential(bool option)
        {
            senRes = option;
        }
        public void setHomeVaccination(int option)
        {

        }

        


    }
}