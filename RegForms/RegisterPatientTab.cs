
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class RegisterPatientTab : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string server;
        private string database;
        private string user;
        private string password;

        private const byte PATIENT_TAB = 0;
        private const byte CLIENT_TAB = 1;
        private const byte REQUIREMENTS_TAB = 2;
        private const byte DETAILS_TAB = 3;

        private Patient patient;
        private Client client;
        private FaceSheet fsheet;
        private CostTable cost;

        private UInt16 selID;
        private UInt16 gatherID;
        private UInt16 endorseID;

        private string desig;
        private string fname;
        private string sname;
        private string mname;
        private string gender;
        private string nationality;
        private string religion;
        private string civstat;
        private string educattain;
        private string email;
        //holders for birthdate fields
        private DateTime birthdate;
        //holders for address fields
        private string addline;
        private UInt16 stnumber;
        private string region;
        private string city;
        //holders for contact number fields
        private UInt16 homeNum;
        private UInt16 workNum;
        private UInt16 mobNum;
        private UInt16 otherNum;
        //holders for facesheet
        private string posrel;
        private bool isPrimary;
        

        public RegisterPatientTab()
        {
            InitializeComponent();

            gatherID = endorseID = 0;
            
            patient = new Patient();
            client = new Client();
            fsheet = new FaceSheet();
            cost = new CostTable();

            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            string connString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" +
                                "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connString);

            if (OpenConnection())
            {
                int hvnum = 0, cmnum = 0;
                //INITIALIZE CHECK BOX LISTS WITH ITEMS FROM DATABASE.
                string query = "SELECT DESCRIPTION FROM CASE_MGMT_REF;";
                cmd = new MySqlCommand(query, conn);

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    cmnum++;
                    caseMgmtBox.Items.Add(read.GetString(0));
                }

                read.Close();

                query = "SELECT DESCRIPTION FROM HVAC_REF;";
                cmd.CommandText = query;

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    hvnum++;
                    hvacCoB.Items.Add(read.GetString(0));
                }

                read.Close();
                //INTITIALIZE FACE SHEET
                Console.WriteLine("Number of CM Items: {0}", cmnum);
                Console.WriteLine("Number of HV Items: {0}", hvnum);
                CloseConnection();
                fsheet = new FaceSheet(cmnum, hvnum);
              
            }


        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("SQL Connection Opened.");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("SQL Connection Closed.");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private void RegisterPerson(Person p)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO PERSON(DESIGNATION,SNAME,FNAME,MNAME,BDATE,GENDER,CIVSTAT,NATIONALITY,RELIGION," +
                 "EDUCATTAIN,EMAIL,HOMENUM,WORKNUM,MOBNUM,OTHERNUM,STNUM,ADDLINE,CITY,REGION) VALUES "
                 + "(@desig,@sur,@first,@mid,@bday,@gen,@cstat,@nat,@rel,@edatt,@mail,@hnum,@wnum,@mnum,@onum,@stno,@aline,@ct,@reg)";

                cmd = new MySqlCommand(query, conn);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@desig", p.getDesig());
                cmd.Parameters.AddWithValue("@sur", p.getSurname());
                cmd.Parameters.AddWithValue("@first", p.getFirstName());
                cmd.Parameters.AddWithValue("@mid", p.getMidName());
                cmd.Parameters.AddWithValue("@bday", p.getBDay());
                cmd.Parameters.AddWithValue("@gen", p.getGender());
                cmd.Parameters.AddWithValue("@cstat", p.getCivilStatus());
                cmd.Parameters.AddWithValue("@nat", p.getNationality());
                cmd.Parameters.AddWithValue("@rel", p.getReligion());
                cmd.Parameters.AddWithValue("@edatt", p.getEducAttainment());
                cmd.Parameters.AddWithValue("@mail", p.getEmail());
                cmd.Parameters.AddWithValue("@hnum", p.getHomeNum());
                cmd.Parameters.AddWithValue("@mnum", p.getMobNum());
                cmd.Parameters.AddWithValue("@wnum", p.getWorkNum());
                cmd.Parameters.AddWithValue("@onum", p.getOtherNum());
                cmd.Parameters.AddWithValue("@stno", p.getStNum());
                cmd.Parameters.AddWithValue("@aline", p.getAddLine());
                cmd.Parameters.AddWithValue("@ct", p.getCity());
                cmd.Parameters.AddWithValue("@reg", p.getRegion());

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
        private void caseMgmtCB_CheckedChanged(object sender, EventArgs e)
        {
            if (caseMgmtCB.Checked == false)
            {
                caseMgmtBox.Enabled = false;
                for (int i = 0; i < caseMgmtBox.Items.Count; i++)
                {
                    caseMgmtBox.SetItemChecked(i,false);
                }
            }
            else
            {
                caseMgmtBox.Enabled = true;
            }

        }
        private void hvacCB_CheckedChanged(object sender, EventArgs e)
        {
            if (hvacCB.Checked == false)
            {
                hvacCoB.Enabled = false;
                for (int i = 0; i < hvacCoB.Items.Count; i++)
                {
                    hvacCoB.SetItemChecked(i,false);
                }
            }
            else
            {
                hvacCoB.Enabled = true;
            }
        }
        private void RegisterPatientTab_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseConnection())
                Console.WriteLine("SQL Connection Closed");

        }
        private void pNextButton_Click(object sender, EventArgs e)
        {

            //Patient Tab
            //get all the values in the fields & perform error checking
            //currently, clicking this button will register the Patient details into
            //the database. Will change this in the future so that if the user cancels the
            //registration, all table entries related to the cancelled registration
            //will be removed from the database.

            desig = pdesigCoB.Text;
          
            fname = pfnameIn.Text;
            sname = psnameIn.Text;
            mname = pmnameIn.Text;

            birthdate = pbdayPick.Value;             //Get data from DateTime Picker

            if (Checker.check(fname))
                Console.WriteLine("FNAME IS GOOD");
            else
                Console.WriteLine("FNAME IS SHIT");

            if (Checker.check(sname))
                Console.WriteLine("SNAME IS GOOD");
            else
                Console.WriteLine("SNAME IS SHIT");

            if (Checker.check(mname))
                Console.WriteLine("MNAME IS GOOD");
            else
                Console.WriteLine("MNAME IS SHIT");

            //following fields must not be blank
          
                gender = pgenCoB.Text;
                nationality = pnatIn.Text;
                religion = prelIn.Text;
                civstat = pcivStatCoB.Text;
                educattain = pedattCoB.Text;
      

            //fields for address. must not be blank!
            addline = paddlineIn.Text;
            city = pcityIn.Text;
            region = pregIn.Text;

            try
            {
                stnumber = UInt16.Parse(pstnoIn.Text);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Street #: " + err.Message);
            }
            catch (OverflowException of)
            {
                Console.WriteLine("Street #: " + of.Message);
            }

            try
            {
                workNum = UInt16.Parse(pWorkIn.Text);
                homeNum = UInt16.Parse(pHomeIn.Text);
                mobNum = UInt16.Parse(pMobileIn.Text);
                otherNum = UInt16.Parse(pOtherIn.Text);
            }
            catch (Exception err)
            {
            }

            //get email
            //needs regex based error checking
            email = pemailIn.Text;

            //add fields to Patient Object
            patient.setName(desig, fname, mname, sname);
            patient.setBday(birthdate);
            patient.setGender(gender);
            patient.setNationality(nationality);
            patient.setReligion(religion);
            patient.setCivilStatus(civstat);
            patient.setEducAttainment(educattain);
            patient.setEmail(email);
            patient.setAddress(stnumber, addline, city, region);
            patient.setNumbers(homeNum, workNum, mobNum, otherNum);

            //displayStuff(patient);

            //open connection to database
            if (true)
            {
                RegisterPerson(patient);

                //insert into patient table

                OpenConnection();

                string query = "SELECT LAST_INSERT_ID() FROM PERSON;";
                cmd.CommandText = query;

                read = cmd.ExecuteReader();

                read.Read();

                Console.WriteLine(read.GetDecimal(0).ToString());

                UInt16 lastID = UInt16.Parse(read.GetDecimal(0).ToString());

                patient.setID(lastID);

                read.Close();

                query = "INSERT INTO PATIENT(PatID) VALUES(@pid);";

                cmd.CommandText = query;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@pid", lastID);

                cmd.ExecuteNonQuery();

                CloseConnection();

                tabControl1.SelectedIndex++;

            }
            else
            {

            }

            //move to next tab

        }
        private void cNextButton_Click(object sender, EventArgs e)
        {
            desig = cdesigCoB.Text;
            fname = cfnameIn.Text;
            sname = csnameIn.Text;
            mname = cmnameIn.Text;

            

            birthdate = cbdayPick.Value;

            try
            {
                gender = cgenCoB.Text;
                nationality = cnatIn.Text;
                religion = crelIn.Text;
                civstat = ccivstatCoB.SelectedText;
                educattain = cedattCoB.Text;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            addline = caddIn.Text;
            city = ccityIn.Text;
            region = cregIn.Text;

            try
            {
                stnumber = UInt16.Parse(pstnoIn.Text);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Street #: " + err.Message);
            }
            catch (OverflowException of)
            {
                Console.WriteLine("Street #: " + of.Message);
            }

            try
            {
                workNum = UInt16.Parse(cWorkIn.Text);
                homeNum = UInt16.Parse(cHomeIn.Text);
                mobNum = UInt16.Parse(cMobileIn.Text);
                otherNum = UInt16.Parse(cOtherIn.Text);
            }
            catch (Exception err)
            {
            }

            //get email
            //needs regex based error checking
            email = cemailIn.Text;
            //get position/relationship of client to patient
            posrel = posIn.Text;
            isPrimary = primaryCB.Checked;


            client.setName(desig, fname, mname, sname);
            client.setBday(birthdate);
            client.setGender(gender);
            client.setNationality(nationality);
            client.setReligion(religion);
            client.setCivilStatus(civstat);
            client.setEducAttainment(educattain);
            client.setEmail(email);
            client.setAddress(stnumber, addline, city, region);
            client.setNumbers(homeNum, workNum, mobNum, otherNum);

            if (true)//implement error checking flags here
            {   string query;
                UInt16 lastID;

                if(selID == 0)
                 RegisterPerson(client);

                OpenConnection();

                if (selID == 0)
                {
                    query = "SELECT LAST_INSERT_ID() FROM PERSON;";
                    cmd = new MySqlCommand(query, conn);
                    read = cmd.ExecuteReader();
                    read.Read();
                    Console.WriteLine(read.GetDecimal(0).ToString());
                   lastID = UInt16.Parse(read.GetDecimal(0).ToString());
                    client.setID(lastID);
                    read.Close();

                    query = "INSERT INTO CLIENT (ClientID) VALUES(@cid);";
                    cmd.CommandText = query;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@cid", lastID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    client.setID(selID);
                }

                query = "INSERT INTO RELATIONSHIP VALUES (@pd,@cd,@ip,@rel);";
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@pd", patient.getID());
                cmd.Parameters.AddWithValue("@cd", client.getID());
                cmd.Parameters.AddWithValue("@ip", isPrimary);
                cmd.Parameters.AddWithValue("@rel", posrel);
                cmd.ExecuteNonQuery();

                CloseConnection();
                tabControl1.SelectedIndex++;
            }
            else
            {
            }


        }
        private void rNextButton_Click(object sender, EventArgs e)
        {
            float np, m, o, nd, h, t, s, lwt, pax;
            System.Text.StringBuilder cmgmt = new StringBuilder();
            System.Text.StringBuilder hv = new StringBuilder();

            fsheet.registerClient(client.getID());
            fsheet.registerPatient(patient.getID());
            fsheet.setAmbWellness(ambCB.Checked);
            fsheet.setCareTraining(ctCB.Checked);
            fsheet.setSeniorResidential(senresCB.Checked);
            fsheet.ReqDetails = detIn.Text;

            if (caseMgmtCB.Checked)
            {
                int cnt = caseMgmtBox.CheckedItems.Count;

                for (int i = 0; i < cnt; i++)
                {
                    cmgmt.Append("'" + caseMgmtBox.CheckedItems[i].ToString() + "'");
                    if (i < cnt - 1)
                        cmgmt.Append(",");
                }

                Console.WriteLine(cmgmt);
            }
            if (hvacCB.Checked)
            {
                int num = hvacCoB.CheckedItems.Count;
                Console.WriteLine("Number of items checked for HVAC: {0}",num);

                for (int i = 0; i < num; i++)
                {
                    hv.Append("'"+hvacCoB.CheckedItems[i].ToString()+"'");
                    if (i < num - 1)
                        hv.Append(",");

                }
                Console.WriteLine(hv);
            }

            //initialize cost table parameters
            try
            {  //get MD Parameters first
                np = float.Parse(mdNPIn.Text);
                m = float.Parse(mdmealsIn.Text);
                o = float.Parse(mdoverIn.Text);
                nd = float.Parse(mdndIn.Text);
                h = float.Parse(mdhpIn.Text);
                t = float.Parse(mdTranspoIn.Text);
                s = float.Parse(mdSomethingIn.Text);
                lwt = float.Parse(mdLWTIn.Text);
                pax = float.Parse(mdNoPaxIn.Text);
                cost.setMDParams(np, m, o, nd, h, t, s, lwt, pax);
            }
            catch (Exception err)
            {
                Console.WriteLine("Cost Table Field Error(MD): " + err.Message);
            }

            try
            { //get MD Parameters first
                np = float.Parse(hcNPIn.Text);
                m = float.Parse(hcmealsIn.Text);
                o = float.Parse(hcoverIn.Text);
                nd = float.Parse(hcndIn.Text);
                h = float.Parse(hchpIn.Text);
                t = float.Parse(hcTranspoIn.Text);
                s = float.Parse(hcSomethingIn.Text);
                lwt = float.Parse(hcLWTIn.Text);
                pax = float.Parse(hcNoPaxIn.Text);

                cost.setHCParams(np, m, o, nd, h, t, s, lwt, pax);
            }
            catch (Exception err)
            {
                Console.WriteLine("Cost Table Field Error(HCP): " + err.Message);
            }


            if (true)
            {
                if (OpenConnection())
                {
                    string query = "INSERT INTO FACESHEET(PATID,CLIENTID,CTRAINING,AMBWELLNESS,SENIORRES,REQDETAILS) " +
                    "VALUES (@ptid,@ctid,@cty,@amb,@sen,@rqdet)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ptid", fsheet.PatientID);
                    cmd.Parameters.AddWithValue("@ctid", fsheet.ClientID);
                    cmd.Parameters.AddWithValue("@cty", fsheet.CarTra);
                    cmd.Parameters.AddWithValue("@amb", fsheet.AmbWel);
                    cmd.Parameters.AddWithValue("@sen", fsheet.SenRes);
                    cmd.Parameters.AddWithValue("@rqdet", fsheet.ReqDetails);

                    cmd.ExecuteNonQuery();

                    query = "SELECT LAST_INSERT_ID() FROM FACESHEET;";
                    cmd.CommandText = query;
                    read = cmd.ExecuteReader();
                    read.Read();
                    fsheet.FID = UInt16.Parse(read.GetDecimal(0).ToString());

                    read.Close();

                    //insert values to case mgmt map

                    if (caseMgmtBox.CheckedItems.Count > 0)
                    {

                        string caseQuery = "SELECT CASEID FROM CASE_MGMT_REF WHERE DESCRIPTION IN (" + cmgmt + ");";
                        cmd = new MySqlCommand(caseQuery, conn);
                        UInt16[] ctmp = new UInt16[caseMgmtBox.CheckedItems.Count];

                        read = cmd.ExecuteReader();
                        int x = 0;
                        while (read.Read())
                        {

                            Console.WriteLine(read.GetDecimal(0).ToString());
                            ctmp[x] = UInt16.Parse(read.GetDecimal(0).ToString());
                            x++;
                        }
                        fsheet.addCaseMgmtIndex(ctmp);
                        read.Close();

                        query = "INSERT INTO CASE_MGMT_MAP VALUES (@fcID,@cmgmtID);";
                        cmd.CommandText = query;

                        for (int ccnt = 0; ccnt < ctmp.Length; ccnt++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@fcID", fsheet.FID);
                            cmd.Parameters.AddWithValue("@cmgmtID", ctmp[ccnt]);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (hvacCoB.CheckedItems.Count > 0)
                    {
                        string HVacquery = "SELECT HVACID FROM HVAC_REF WHERE DESCRIPTION IN (" + hv + ");";
                        cmd = new MySqlCommand(HVacquery,conn);
                        UInt16[] htmp = new UInt16[hvacCoB.CheckedItems.Count];

                        read = cmd.ExecuteReader();
                        int x = 0;
                        while (read.Read())
                        {

                            Console.WriteLine(read.GetDecimal(0).ToString());
                            htmp[x] = UInt16.Parse(read.GetDecimal(0).ToString());
                            x++;
                        }
                        fsheet.addHomeVacIndex(htmp);
                        read.Close();

                        query = "INSERT INTO HVAC_MAP VALUES (@fcID,@hvacID);";
                        cmd.CommandText = query;

                        for (int hcnt = 0; hcnt < htmp.Length; hcnt++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@fcID", fsheet.FID);
                            cmd.Parameters.AddWithValue("@hvacID",htmp[hcnt]);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            
                        }
                        
                    }

                    CloseConnection();
                    tabControl1.SelectedIndex++;
                }
            }

        }
        private void resetButton_Click(object sender, EventArgs e)
        {

        }
        private void clientSelectButton_Click(object sender, EventArgs e)
        {
            ClientSelect csel = new ClientSelect();

            csel.ShowDialog();
            selID = csel.Sel;
            Console.WriteLine(selID);
            csel.Close();

            if (selID != 0)
            {
                client.setID(selID);

                if (OpenConnection())
                {
                    string query = "SELECT * FROM PERSON WHERE ID=@id;";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", selID);

                    read = cmd.ExecuteReader();

                    read.Read();

                    cdesigCoB.Enabled = false;
                    csnameIn.Enabled = false;
                    cfnameIn.Enabled = false;
                    cmnameIn.Enabled = false;
                    cbdayPick.Enabled = false;
                    cgenCoB.Enabled = false;
                    crelIn.Enabled = false;
                    cnatIn.Enabled = false;
                    ccivstatCoB.Enabled = false;
                    cedattCoB.Enabled = false;
                    cstNoIn.Enabled = false;
                    caddIn.Enabled = false;
                    ccityIn.Enabled = false;
                    cregIn.Enabled = false;
                    cemailIn.Enabled = false;
                    cHomeIn.Enabled = false;
                    cWorkIn.Enabled = false;
                    cMobileIn.Enabled = false;
                    cOtherIn.Enabled = false;

                    cdesigCoB.Text = read.GetString("Designation");
                    csnameIn.Text = read.GetString("SName");
                    cfnameIn.Text = read.GetString("FName");
                    cmnameIn.Text = read.GetString("MName");
                    cbdayPick.Value = DateTime.Parse(read.GetString("BDate"));
                    cgenCoB.Text = read.GetString("Gender");
                    crelIn.Text = read.GetString("Religion");
                    cnatIn.Text = read.GetString("Nationality");
                    ccivstatCoB.Text = read.GetString("CivStat");
                    cedattCoB.Text = read.GetString("EducAttain");
                    cstNoIn.Text = read.GetString("StNum");
                    caddIn.Text = read.GetString("AddLine");
                    ccityIn.Text = read.GetString("City");
                    cregIn.Text = read.GetString("Region");
                    cemailIn.Text = read.GetString("Email");
                    cHomeIn.Text = read.GetString("HomeNum");
                    cWorkIn.Text = read.GetString("WorkNum");
                    cMobileIn.Text = read.GetString("MobNum");
                    cOtherIn.Text = read.GetString("OtherNum");

                    read.Close();

                    CloseConnection();

                }
                else
                {
                }
            }

        }

        private void selClearButton_Click(object sender, EventArgs e)
        {
            if (selID != 0)
            {

                cdesigCoB.Enabled = true;
                csnameIn.Enabled = true;
                cfnameIn.Enabled = true;
                cmnameIn.Enabled = true;
                cbdayPick.Enabled = true;
                cgenCoB.Enabled = true;
                crelIn.Enabled = true;
                cnatIn.Enabled = true;
                ccivstatCoB.Enabled = true;
                cedattCoB.Enabled = true;
                cstNoIn.Enabled = true;
                caddIn.Enabled = true;
                ccityIn.Enabled = true;
                cregIn.Enabled = true;
                cemailIn.Enabled = true;
                cHomeIn.Enabled = true;
                cWorkIn.Enabled = true;
                cMobileIn.Enabled = true;
                cOtherIn.Enabled = true;
                cOtherIn.Enabled = true;


                cdesigCoB.Text = "";
                csnameIn.Text = "Surname";
                cfnameIn.Text = "First Name";
                cmnameIn.Text = "Middle Name";
                cgenCoB.Text = "";
                crelIn.Text = "";
                cnatIn.Text = "";
                ccivstatCoB.Text = "";
                cedattCoB.Text = "";
                cstNoIn.Text = "Street #";
                caddIn.Text = "Address Line";
                ccityIn.Text = "City";
                cregIn.Text = "Region";
                cemailIn.Text = "";
                cHomeIn.Text = "";
                cWorkIn.Text = "";
                cMobileIn.Text = "";
                cOtherIn.Text = "";

                selID = 0;

            }
        }

        private void fsheetFinishButton_Click(object sender, EventArgs e)
        {
            fsheet.EffectivityDate = effectPicker.Value;
            fsheet.Action = actionsTextBox.Text;

            if (true) //error checking
            {
                if (OpenConnection())
                {
                    string query = "UPDATE FACESHEET SET GID =@gid,EID =@eid,ACTION =@act,EFFECTDATE=@edate WHERE FACEID=@fid;";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@gid", fsheet.GatherID);
                    cmd.Parameters.AddWithValue("@eid", fsheet.EndorseID);
                    cmd.Parameters.AddWithValue("@act", fsheet.Action);
                    cmd.Parameters.AddWithValue("@edate", fsheet.EffectivityDate);
                    cmd.Parameters.AddWithValue("@fid", fsheet.FID);

                    cmd.ExecuteNonQuery();

                    CloseConnection();

                    this.Close();
                }
            }
            else
            {
            }

        }

        private void gatherButton_Click(object sender, EventArgs e)
        {
            SelectEmployee sel = new SelectEmployee();
            sel.ShowDialog();
            gatherID = sel.Sel;
            gatherTextBox.Text = sel.Fname + " " + sel.Sname;
            Console.WriteLine("Gathered by: {0}", gatherID);
            sel.Close();
            if (endorseID != gatherID)
                fsheet.GatherID = gatherID;
            else
                Console.WriteLine("Gather and Endorse cannot be the same.");
            
        }

        private void endorseButton_Click(object sender, EventArgs e)
        {
            SelectEmployee sel = new SelectEmployee();
            sel.ShowDialog();
            endorseID = sel.Sel;
            endorseTextBox.Text = sel.Fname + " " + sel.Sname;
            Console.WriteLine("Endorsed by: {0}", endorseID);
            sel.Close();
            if (endorseID != gatherID)
                fsheet.EndorseID = endorseID;
            else
                Console.WriteLine("Gather and Endorse cannot be the same.");
        }

    }
}