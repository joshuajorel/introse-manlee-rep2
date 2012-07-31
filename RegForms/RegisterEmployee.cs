using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class RegisterEmployee : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection conn;

        private Employee emp;
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

        public RegisterEmployee()
        {
            InitializeComponent();

            emp = new Employee();

            string server = "localhost";
            string user = "root";
            string database = "hhc-db";
            string password = "root";

            string connString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" +
                                "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connString);

        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("SQL Connection Opened.");
                return true;
            }
            catch (Exception err)
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

        private void empTypeCoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empTypeCoB.SelectedIndex != 0)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
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


        private void doneButton_Click(object sender, EventArgs e)
        {
            desig = edesigCoB.Text;
            fname = efnameIn.Text;
            sname = esnameIn.Text;
            mname = emnameIn.Text;

            birthdate = ebdayPick.Value;

            try
            {
                gender      = egenCoB.Text;
                nationality = enatIn.Text;
                religion    = erelIn.Text;
                civstat = ecivstatCoB.SelectedItem.ToString();
                Console.WriteLine(civstat);
                educattain  = eedattCoB.Text;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            addline = eaddIn.Text;
            city    = ecityIn.Text;
            region  = eregIn.Text;

            try
            {
                stnumber = UInt16.Parse(estnoIn.Text);
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
                workNum     = UInt16.Parse(eWorkIn.Text);
                homeNum     = UInt16.Parse(eHomeIn.Text);
                mobNum      = UInt16.Parse(eMobileIn.Text);
                otherNum    = UInt16.Parse(eOtherIn.Text);
            }
            catch (Exception err)
            {
            }

            //get email
            //needs regex based error checking
            email = eemailIn.Text;

            emp.setName(desig, fname, mname, sname);
            emp.setBday(birthdate);
            emp.setGender(gender);
            emp.setNationality(nationality);
            emp.setReligion(religion);
            emp.setCivilStatus(civstat);
            emp.setEducAttainment(educattain);
            emp.setEmail(email);
            emp.setAddress(stnumber, addline, city, region);
            emp.setNumbers(homeNum, workNum, mobNum, otherNum);

            if (true)
            {
                RegisterPerson(emp);

                OpenConnection();

                string query = "SELECT LAST_INSERT_ID() FROM PERSON;";
                cmd = new MySqlCommand(query, conn);

                read = cmd.ExecuteReader();

                read.Read();

                UInt16 lastID = UInt16.Parse(read.GetDecimal(0).ToString());

                emp.setID(lastID);

                read.Close();

                query = "INSERT INTO EMPLOYEE (EMPID) VALUES(@eid);";

                cmd.CommandText = query;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@eid", lastID);

                cmd.ExecuteNonQuery();

                CloseConnection();

            }
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
