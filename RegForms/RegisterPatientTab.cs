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
        private const byte CLIENT_TAB =  1;
        private const byte REQUIREMENTS_TAB = 2;
        private const byte DETAILS_TAB = 3;

        private Patient patient;
        private Client  client;
        private FaceSheet fsheet;

        private UInt16 selID;
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
        
        public RegisterPatientTab()
        {
            InitializeComponent();

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
                int hvnum, cmnum;
                //INITIALIZE CHECK BOX LISTS WITH ITEMS FROM DATABASE.
                string query = "SELECT DESCRIPTION FROM CASE_MGMT_REF;";
                cmd = new MySqlCommand(query, conn);

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    caseMgmtBox.Items.Add(read.GetString(0));
                }

                read.Close();

                query = "SELECT DESCRIPTION FROM HVAC_REF;";
                cmd.CommandText = query;

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    hvacCoB.Items.Add(read.GetString(0));
                }

                read.Close();
                //INTITIALIZE FACE SHEET
                query = "SELECT COUNT(*) FROM CASE_MGMT_REF;";
                cmd.CommandText = query;
                read = cmd.ExecuteReader();

                read.Read();
                cmnum = read.GetInt16(0);
                Console.WriteLine("Number of CM Items: {0}",cmnum);
                read.Close();

                query = "SELECT COUNT(*) FROM HVAC_REF;";
                cmd.CommandText = query;
                read = cmd.ExecuteReader();

                read.Read();
                hvnum = read.GetInt16(0);
                Console.WriteLine("Number of HV Items: {0}", hvnum);
                read.Close();

                CloseConnection();

                patient = new Patient();
                client = new Client();
                fsheet = new FaceSheet(cmnum, hvnum);
            }
     
          }


        private bool OpenConnection()
        {
            try
            {
                conn.Open();
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
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private int checkName(string s, string f, string m)
        {
            

            return 0;
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

        //save inputs to respective classes
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == PATIENT_TAB)
            {   
                
        
            }
            else if (tabControl1.SelectedIndex == CLIENT_TAB)
            {

            }
            else if (tabControl1.SelectedIndex == REQUIREMENTS_TAB)
            {
                //Requirements tab
            }
            else if (tabControl1.SelectedIndex == DETAILS_TAB)
            {
                //Details tab
            }
        }
        //runs when the Add button for Contact information is clicked.

        private void caseMgmtCB_CheckedChanged(object sender, EventArgs e)
        {
            if (caseMgmtCB.Checked == false)
            {
                caseMgmtBox.Enabled = false;
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
            }
            else
            {
                hvacCoB.Enabled = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (primaryCB.Checked == true)
            {
                primaryIn.Enabled = false;
            }
            else
            {
                primaryIn.Enabled = true;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
           
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
            //commands below execute only when the Patient Information Tab is selected.

            desig = pdesigCoB.Text;
            fname = pfnameIn.Text;
            sname = psnameIn.Text;
            mname = pmnameIn.Text;

            checkName(fname, sname, mname); //replace error checking with regular expressions.
            birthdate = pbdayPick.Value;             //Get data from DateTime Picker

            //following fields must not be blank
            try
            {
                gender = pgenCoB.Text;
                nationality = pnatIn.Text;
                religion = prelIn.Text;
                civstat = pcivStatCoB.Text;
                educattain = pedattCoB.Text;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

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
            patient.setNumbers(homeNum,workNum,mobNum,otherNum);
            
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
            {
                RegisterPerson(client);

                OpenConnection();

                string query = "SELECT LAST_INSERT_ID() FROM PERSON;";
                cmd.CommandText = query;

                read = cmd.ExecuteReader();

                read.Read();

                Console.WriteLine(read.GetDecimal(0).ToString());

                UInt16 lastID = UInt16.Parse(read.GetDecimal(0).ToString());

                client.setID(lastID);

                read.Close();

                query = "INSERT INTO CLIENT (ClientID) VALUES(@cid);";

                cmd.CommandText = query;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cid", lastID);

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
            fsheet.registerClient(client.getID());
            fsheet.registerPatient(patient.getID());
            fsheet.setAmbWellness(ambCB.Checked);
            fsheet.setCareTraining(ctCB.Checked);
            fsheet.setSeniorResidential(senresCB.Checked);
            
            if (true)
            {


                tabControl1.SelectedIndex++;

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

                    cmd = new MySqlCommand(query,conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id",selID);

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
                    cbdayPick.Value = read.GetDateTime("BDate");
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


 


    }
}
