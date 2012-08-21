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
        private bool closeStatus = false;

        public bool CloseStatus
        {
            get { return closeStatus; }
            set { closeStatus = value; }
        }
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
                datePicker.Value    = bday;
                genderField.Text    = read.GetString("Gender");
                genderBox.Text      = genderField.Text;
                civField.Text       = read.GetString("CivStat");
                civStatBox.Text     = civField.Text;
                natField.Text       = read.GetString("Nationality");
                relField.Text       = read.GetString("Religion");
                educField.Text      = read.GetString("EducAttain");
                educBox.Text        = educField.Text;
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
            closeStatus = true;
            this.Hide();
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
                                
                relField.Enabled = true;
                natField.Enabled = true;

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

                bool gen, ed, rel, civ,nat;

                gen = genderBox.Items.Contains(genderBox.Text);
                ed = educBox.Items.Contains(educBox.Text);
                rel = introseHHC.Objects.Checker.check(relField.Text);
                civ = civStatBox.Items.Contains(civStatBox.Text);
                nat = introseHHC.Objects.Checker.check(natField.Text);

                if (gen && ed && rel && civ && nat)
                {
                    if (OpenConnection())
                    {
                        Console.WriteLine("Correct Values");
                        string query;
                        //sql commands go here
                        cmd.Parameters.Clear();
                        query = string.Format("UPDATE PERSON SET SNAME = '{0}',FNAME = '{1}', MNAME = '{2}', "
                        + "GENDER = '{3}', CIVSTAT = '{4}', NATIONALITY = '{5}', RELIGION = '{6}', "
                        + "EDUCATTAIN = '{7}',BDATE=@bday WHERE ID = @cid;", client.getSurname(), client.getFirstName(),
                        client.getMidName(), genderBox.Text, civStatBox.Text, natField.Text,
                        relField.Text, educBox.Text);

                        cmd.CommandText = query;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@cid", clientID);
                        cmd.Parameters.AddWithValue("@bday", client.getBDay());
                        cmd.ExecuteNonQuery();

                        CloseConnection();

                        birthField.Visible = true;
                        birthField.Text = client.getBDay().ToShortDateString();
                        datePicker.Visible = false;
                        genderField.Visible = true;
                        genderField.Text = genderBox.Text;
                        genderBox.Visible = false;

                        nameField.Enabled = false;
                        relField.Enabled = false;
                        natField.Enabled = false;

                        civField.Visible = true;
                        civField.Text = civStatBox.Text;
                        civStatBox.Visible = false;

                        educField.Visible = true;
                        educField.Text = educBox.Text;
                        educBox.Visible = false;

                        personalEdit = false;

                        MessageBox.Show("Personal Info: Update Successful!");
                    }
                    else
                    {

                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder("Incorrect Values:\n");
                    //rel civ nat
                    if (!gen)
                        sb.Append("Gender not in selection.\n");
                    if(!ed)
                        sb.Append("Educational Attainment not in selection.\n");
                    if(!rel)
                        sb.Append("Invalid format in Religion.\n");
                    if (!civ)
                        sb.AppendLine("Civil Status not in selection.");
                    if(!nat)
                        sb.Append("Invalid format in Nationality.\n");

                    MessageBox.Show(sb.ToString());
                    sb.Clear();
                    birthField.Visible = true;
                    datePicker.Visible = false;
                    genderField.Visible = true;
                    genderBox.Visible = false;

                    relField.Enabled = false;
                    natField.Enabled = false;

                    civField.Visible = true;
                    civStatBox.Visible = false;

                    educField.Visible = true;
                    educBox.Visible = false;

                     personalEdit = false;
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
            natField.Enabled = false;

            civField.Visible = true;
            civStatBox.Visible = false;

            educField.Visible = true;
            educBox.Visible = false;

            //restore past values
            nameField.Text = tmp_Name.getLastName() + ", " + tmp_Name.getFirstName() + " " + tmp_Name.getMiddleName();
            birthField.Text = client.getBDay().ToShortDateString();
            genderField.Text = client.getGender();
            relField.Text = client.getReligion();
            natField.Text = client.getNationality();
            civField.Text = client.getCivilStatus();
            educField.Text = client.getEducAttainment();

            personalEdit = false;

        }

        private void ViewClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeStatus = true;
            this.Hide();
        }

        private void contactEditButton_Click(object sender, EventArgs e)
        {
            if (!contactEdit)
            {
                contactEditButton.Text = "Done";
                contactCancelButton.Visible = true;
                editAddButton.Visible = true;

                //setup contact number fields + email field
                if (homeField.Text.Equals("n/a"))
                    homeField.Text = "0";
                if (workField.Text.Equals("n/a"))
                    workField.Text = "0";
                if (mobField.Text.Equals("n/a"))
                    mobField.Text = "0";
                if (otherField.Text.Equals("n/a"))
                    otherField.Text = "0";
                if (emailField.Text.Equals("n/a"))
                    emailField.Text = "";
                //make contacts and email fields editable
                homeField.Enabled = true;
                workField.Enabled = true;
                mobField.Enabled = true;
                otherField.Enabled = true;
                emailField.Enabled = true;

                contactEdit = true;
                
            }
            else //user has finished changes. Will now attempt to insert to database.
            {
                contactEditButton.Text = "Edit";
                contactCancelButton.Visible = false;
                editAddButton.Visible = false;

                //error checking
                bool a, b, c, d, em;
                UInt16 h, w, m, o;
                //check if contact numbers entered are correct
                a = Checker.check2(homeField.Text);
                b = Checker.check2(workField.Text);
                c = Checker.check2(mobField.Text);
                d = Checker.check2(otherField.Text);
                if (string.IsNullOrEmpty(emailField.Text))
                    em = true;
                else
                {
                    em = Checker.email(emailField.Text);
                }

                if (a && b && c && d && em)
                {

                    if (OpenConnection())
                    {
                        h = UInt16.Parse(homeField.Text);
                        w = UInt16.Parse(workField.Text);
                        m = UInt16.Parse(mobField.Text);
                        o = UInt16.Parse(otherField.Text);

                        string query;

                        query = string.Format("UPDATE PERSON SET STNUM = @stno, ADDLINE = '{0}', "
                            + " CITY = '{1}', REGION = '{2}',"
                            + "HOMENUM = '{3}',WORKNUM = '{4}',MOBNUM = '{5}',OTHERNUM = '{6}',EMAIL = '{7}'"
                            + "WHERE ID = @cid;"
                            , client.getAddLine(), client.getCity(), client.getRegion(),
                             h, w, m, o
                             , emailField.Text);
                        cmd.Parameters.Clear();
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@cid", clientID);
                        cmd.Parameters.AddWithValue("@stno", client.getStNum());

                        try
                        {

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception merr)
                        {
                            Console.WriteLine(merr.Message);
                        }

                        contactEditButton.Text = "Edit";
                        contactCancelButton.Visible = false;
                        editAddButton.Visible = false;

                        homeField.Enabled = false;
                        workField.Enabled = false;
                        mobField.Enabled = false;
                        otherField.Enabled = false;
                        emailField.Enabled = false;

                        homeField.Text = h.ToString();
                        workField.Text = w.ToString();
                        mobField.Text = m.ToString();
                        otherField.Text = o.ToString();

                        MessageBox.Show("Contact Info: Update Successful!");

                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder("Errors:");

                    if(!a)
                        sb.AppendLine("-Invalid Home number.");
                    if(!b)
                        sb.AppendLine("-Invalud Work Number.");
                    if(!c)
                        sb.AppendLine("-Invalid Mobile Number.");
                    if(!d)
                        sb.AppendLine("-Invalid Other Number.");
                    if(!em)
                        sb.AppendLine("-Invalid Email Address.");
                    MessageBox.Show(sb.ToString());
                    sb.Clear();
                }
                //setup contact and email fields
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
                homeField.Enabled = false;
                workField.Enabled = false;
                mobField.Enabled = false;
                otherField.Enabled = false;
                emailField.Enabled = false;

                contactEdit = false;
            }
        }

        private void editAddButton_Click(object sender, EventArgs e)
        {
            EditAddress ed = new EditAddress(UInt16.Parse(client.getStNum().ToString()), client.getAddLine(), client.getCity(), client.getRegion());
            ed.ShowDialog();
            if (ed.Status)
            {
                UInt16 n;
                string a, c, r;
                n = ed.Num;
                a = ed.Addline;
                c = ed.City;
                r = ed.RegionVar;
                addField1.Text = n.ToString() + " " + a;
                addField2.Text = c + ", " + r;
                client.setAddress(n, a, c, r);
                ed.Close();
            }
            else
            {
                ed.Close();
            }
        }

        private void contactCancelButton_Click(object sender, EventArgs e)
        {
            //setup contact and email fields
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
            homeField.Enabled = false;
            workField.Enabled = false;
            mobField.Enabled = false;
            otherField.Enabled = false;
            emailField.Enabled = false;

            contactEdit = false;
        }
    }
}
