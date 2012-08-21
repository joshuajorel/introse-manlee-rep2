using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using introseHHC.Objects;

namespace introseHHC.RegForms
{
    public partial class ViewClient : Form
    {
        private UInt16 clientID;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private Name tmp_Name;
        private Address tmp_Address;
        private Contact tmp_Contact;
        private bool personalEdit = false;
        private bool contactEdit = false;
        private Client client;

        private class Address
        {
            private UInt16 stno;

            public UInt16 Stno
            {
                get { return stno; }
                set { stno = value; }
            }
            private string addline;

            public string Addline
            {
                get { return addline; }
                set { addline = value; }
            }
            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }
            private string region;

            public string Region
            {
                get { return region; }
                set { region = value; }
            }

            public Address()
            {
                stno = 0;
                addline = "";
                city = "";
                region = "";

            }
            public Address(UInt16 n, string a, string c, string r)
            {
                stno = n;
                addline = a;
                city = c;
                region = r;
            }
        }
        private class Contact
        {
            private UInt16 home;

            public UInt16 Home
            {
                get { return home; }
                set { home = value; }
            }
            private UInt16 work;

            public UInt16 Work
            {
                get { return work; }
                set { work = value; }
            }
            private UInt16 mobile;

            public UInt16 Mobile
            {
                get { return mobile; }
                set { mobile = value; }
            }
            private UInt16 other;

            public UInt16 Other
            {
                get { return other; }
                set { other = value; }
            }

            private string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public Contact()
            {
            }
            public Contact(UInt16 h, UInt16 w, UInt16 m, UInt16 o)
            {
                home = h;
                work = w;
                mobile = m;
                other = o;
            }
        }

        public ViewClient(UInt16 id, string c)
        {
            InitializeComponent();
            conn = new MySqlConnection(c);
            clientID = id;
            client = new Client();
            if (OpenConnection())
            {
                string query;
                string fname, sname, mname;
                string d;
                string num, a, ct, r;
                UInt16 hnum, wnum, mnum, onum;
                string email;
                DateTime bday;
                //get person details
                query = "SELECT * FROM (SELECT * FROM PERSON RIGHT JOIN CLIENT ON PERSON.ID = CLIENTID) AS TAB WHERE ID = @id;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", id);
                read = cmd.ExecuteReader();
                read.Read();

                sname   = read.GetString("SName");
                fname   = read.GetString("FName");
                mname   = read.GetString("MName");
                d       = read.GetString("Designation");
                bday    = DateTime.Parse(read.GetString("BDate"));
                num     = read.GetString("StNum");
                a       = read.GetString("AddLine");
                ct      = read.GetString("City");
                r       = read.GetString("Region");
                hnum    = UInt16.Parse(read.GetString("HomeNum"));
                wnum    = UInt16.Parse(read.GetString("WorkNum"));
                mnum    = UInt16.Parse(read.GetString("MobNum"));
                onum    = UInt16.Parse(read.GetString("OtherNum"));
                email   = read.GetString("Email");

                nameField.Text      = sname+ ", " + fname + " " + mname;
                birthField.Text     = bday.ToShortDateString();
                genderField.Text    = read.GetString("Gender");
                civField.Text       = read.GetString("CivStat");
                natField.Text       = read.GetString("Nationality");
                relField.Text       = read.GetString("Religion");
                educField.Text      = read.GetString("EducAttain");
                addField1.Text      = num + " " + a;
                addField2.Text      = ct + ", " + r;
                homeField.Text      = hnum.ToString();
                workField.Text      = wnum.ToString();
                mobField.Text       = mnum.ToString();
                otherField.Text     = onum.ToString();
                emailField.Text     = email;

                //save values to Client object
                client.setID(id);
                client.setName(d,fname,mname,sname);
                client.setBday(bday);
                client.setCivilStatus(civField.Text);
                client.setNationality(natField.Text);
                client.setEducAttainment(educField.Text);
                client.setGender(genderField.Text);
                client.setReligion(relField.Text);
                client.setNumbers(hnum,wnum,mnum,onum);
                client.setEmail(email);
                client.setAddress(UInt16.Parse(num),a,ct,r);

                //save a copy of the Name
                tmp_Name = new Objects.Name(d, fname, mname, sname);
                //save a copy of address
                tmp_Address = new Address(UInt16.Parse(num), a, ct, r);
                //save a copy of contact details
                tmp_Contact = new Contact(hnum,wnum,mnum,onum);
                tmp_Contact.Email = email;

                if (homeField.Text.Equals("0"))
                    homeField.Text = "n/a";
                if (workField.Text.Equals("0"))
                    workField.Text = "n/a";
                if (mobField.Text.Equals("0"))
                    mobField.Text = "n/a";
                if (otherField.Text.Equals("0"))
                    otherField.Text = "n/a";
                if (String.IsNullOrEmpty(emailField.Text))
                    emailField.Text = "n/a";
                read.Close();
                cmd.Parameters.Clear();
                query = "SELECT PERSON.FNAME,PERSON.SNAME,REL.ISPRIMARY,REL.RELATIONSHIP "
                    + "FROM (SELECT PID,ISPRIMARY,RELATIONSHIP FROM RELATIONSHIP WHERE CID = @cID) AS REL  "
                    + "LEFT JOIN PERSON ON PERSON.ID = REL.PID;";
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cID",clientID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {   x = patientView.Rows.Add();
                    patientView.Rows[x].Cells[0].Value = read.GetString("FNAME") + " " + read.GetString("SNAME");
                    if (byte.Parse(read.GetString("ISPRIMARY")).Equals(1))
                    {
                        patientView.Rows[x].Cells[1].Value = "Yes";
                    }
                    else
                    {
                        patientView.Rows[x].Cells[1].Value = "No";
                    }
                    patientView.Rows[x].Cells[2].Value = read.GetString("RELATIONSHIP");

                }
                read.Close();


                CloseConnection();
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
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalEditButton_Click(object sender, EventArgs e)
        {
            if (!personalEdit)
            {
                personalEditButton.Text = "Done";
                editNameButton.Visible = true;
                personalCancelButton.Visible = true;
                
                birthField.Visible  = false;
                datePicker.Visible  = true;
                genderField.Visible = false;
                genderBox.Visible   = true;

                nameField.Enabled = true;
                relField.Enabled = true;

                civField.Visible = false;
                civStatBox.Visible = true;

                educField.Visible = false;
                educBox.Visible = true;

                personalEdit = true;

            }
            else //executes when user has clicked the Done button
            {
                personalEditButton.Text = "Edit";
                editNameButton.Visible = false;
                personalCancelButton.Visible = false;

                if (OpenConnection())
                {
                    //sql commands go here

                    CloseConnection();

                    birthField.Visible = true;
                    datePicker.Visible = false;
                    genderField.Visible = true;
                    genderBox.Visible = false;

                    nameField.Enabled = false;
                    relField.Enabled = false;

                    civField.Visible = true;
                    civStatBox.Visible = false;

                    educField.Visible = true;
                    educBox.Visible = false;

                    personalEdit = false;
                }
                else
                {
                }
            }
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            EditName ed = new EditName(client.getDesig(),client.getFirstName(),client.getMidName(),client.getSurname());
            ed.ShowDialog();
            
            if (ed.Status) //executes when the user presses OK in EditName Dialog box
            {
                string d, f, m, l;
                d = ed.Designation;
                f = ed.FirstName;
                m = ed.MiddleName;
                l = ed.LastName;
                nameField.Text = l + ", " + f + " " + m;
                client.setName(d, f, m, l);

                ed.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void personalCancelButton_Click(object sender, EventArgs e)
        {
            personalEditButton.Text = "Edit";
            editNameButton.Visible = false;
            personalCancelButton.Visible = false;

            birthField.Visible = true;
            datePicker.Visible = false;
            genderField.Visible = true;
            genderBox.Visible = false;

            nameField.Enabled = false;
            relField.Enabled = false;

            civField.Visible = true;
            civStatBox.Visible = false;

            educField.Visible = true;
            educBox.Visible = false;

            personalEdit = false;



        }
    }
}
