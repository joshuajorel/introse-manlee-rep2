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
   

    public partial class ViewPatient : Form
    {
        private UInt16 patID;
        private UInt16 clientID;
        private UInt16 faceID;
        private UInt16 gatherID;
        private UInt16 endorseID;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private Name tmp_Name;
        private Address tmp_Address;
        private Contact tmp_Contact;
        private bool personalEdit = false;
        private bool contactEdit = false;
        private bool clientEdit = false;
        private EditName ed;
        private Patient patient;

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
            public Contact(UInt16 h,UInt16 w,UInt16 m, UInt16 o )
            {
                home = h;
                work = w;
                mobile = m;
                other = o;
            }
        }

        public ViewPatient(UInt16 id, string c)
        {   InitializeComponent();

            patient = new Patient();

            //initialize database connection
            conn = new MySqlConnection(c);

            patID = id;

            if (OpenConnection())
            {   string query;
                string fname, sname, mname;
                string d;
                string num, a, ct, r;
                DateTime bday;
                UInt16 ID;
                //get patient personal details
                query = "SELECT * FROM (SELECT * FROM PERSON RIGHT JOIN PATIENT ON PERSON.ID = PATID) AS TAB WHERE ID = @id;";
                cmd = new MySqlCommand(query,conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id",id);

                read = cmd.ExecuteReader();
                read.Read();
                ID = UInt16.Parse(read.GetString("ID"));
                d = read.GetString("Designation");
                fname = read.GetString("FName");
                mname = read.GetString("MName");
                sname = read.GetString("SName");
                bday = DateTime.Parse(read.GetString("BDate"));
                num = read.GetString("StNum");
                a = read.GetString("AddLine");
                ct = read.GetString("City");
                r = read.GetString("Region");

                nameField.Text = sname+", "+fname+" "+mname;
                birthField.Text = bday.ToShortDateString();
                genderField.Text = read.GetString("Gender");
                civField.Text = read.GetString("CivStat");
                natField.Text = read.GetString("Nationality");
                relField.Text = read.GetString("Religion");
                educField.Text = read.GetString("EducAttain");
                addField1.Text = num + " " + a;
                addField2.Text = ct + ", " + r;
                homeField.Text = read.GetString("HomeNum");
                workField.Text = read.GetString("WorkNum");
                mobField.Text = read.GetString("MobNum");
                otherField.Text = read.GetString("OtherNum");
                emailField.Text = read.GetString("Email");

                //save a copy of the Name
                tmp_Name = new Objects.Name(d, fname, mname, sname);
                //save a copy of address
                tmp_Address = new Address(UInt16.Parse(num), a, ct, r);
                //save a copy of contact details
                tmp_Contact = new Contact(UInt16.Parse(homeField.Text), UInt16.Parse(workField.Text), UInt16.Parse(mobField.Text), UInt16.Parse(otherField.Text));
                tmp_Contact.Email = emailField.Text;

                //place values into Patient Class.
                patient.setID(ID);
                patient.setName(d, fname, mname, sname);
                patient.setBday(bday);
                patient.setCivilStatus(civField.Text);
                patient.setNationality(natField.Text);
                patient.setGender(genderField.Text);
                patient.setReligion(relField.Text);
                patient.setEducAttainment(educField.Text);
                patient.setNumbers(UInt16.Parse(homeField.Text), UInt16.Parse(workField.Text),
                    UInt16.Parse(mobField.Text), UInt16.Parse(otherField.Text));
                patient.setEmail(emailField.Text);
                patient.setAddress(UInt16.Parse(num), a, ct, r);

                //change contact number values if data retrieved from DB  == 0
                if (homeField.Text.Equals("0"))
                    homeField.Text = "n/a";
                if(workField.Text.Equals("0"))
                    workField.Text = "n/a";
                if(mobField.Text.Equals("0"))
                    mobField.Text = "n/a";
                if(otherField.Text.Equals("0"))
                    otherField.Text = "n/a";
                if(String.IsNullOrEmpty(emailField.Text))
                    emailField.Text = "n/a";
                read.Close();

                //get client information
                cmd.Parameters.Clear();
                query = "SELECT REL.CID,REL.ISPRIMARY,REL.RELATIONSHIP,PERSON.SNAME,PERSON.FNAME,PERSON.MNAME "
                    + "FROM(SELECT CID,ISPRIMARY,RELATIONSHIP FROM RELATIONSHIP WHERE PID = @pid) AS REL "
                    + "LEFT JOIN PERSON ON PERSON.ID = REL.CID";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@pid", patID);

                read = cmd.ExecuteReader();
                read.Read();

                clienNameIn.Text = read.GetString("SName") + ", " + read.GetString("FName") + " " + read.GetString("MName");

                clientIDIn.Text = read.GetString("CID");
                clientID = UInt16.Parse(clientIDIn.Text);

                posRelIn.Text = read.GetString("Relationship");
                if (byte.Parse(read.GetString("IsPrimary")).Equals(1))
                    primaryLabel.Text = "Yes";
                else
                    primaryLabel.Text = "No";
              

                read.Close();

                //get face sheet information
                cmd.Parameters.Clear();
                query = "SELECT * FROM FACESHEET WHERE PATID = @pid;";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@pid", patID);

                read = cmd.ExecuteReader();
                read.Read();

                faceID = UInt16.Parse(read.GetString("FaceID"));
                gatherID = UInt16.Parse(read.GetString("GID"));
                endorseID = UInt16.Parse(read.GetString("EID"));
                effDateLabel.Text = DateTime.Parse(read.GetString("EffectDate")).ToShortDateString();
                detIn.Text = read.GetString("ReqDetails");
                actBoxIn.Text = read.GetString("Action");

                if (byte.Parse(read.GetString("AmbWellness")).Equals(1))
                    ambCB.Checked = true;
                else
                  ambCB.Checked = false;
           
                if (byte.Parse(read.GetString("SeniorRes")).Equals(1)) 
                    senresCB.Checked = true;
                else
                    senresCB.Checked = false;
              

                read.Close();

                //get case managment options
                cmd.Parameters.Clear();
                query = "SELECT * FROM " +
                    "(SELECT CM.FACEID, DESCRIPTION FROM CASE_MGMT_MAP AS CM LEFT JOIN CASE_MGMT_REF AS CR ON CM.CASEID = CR.CASEID) AS CMGMT "
                    + "WHERE FACEID = @fId;";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@fId", faceID);

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    cmIn.AppendText(read.GetString("Description")+"\n");
                }

                read.Close();
                //get gather
                query = "SELECT ID,SNAME,FNAME,MNAME FROM PERSON WHERE ID=@gID;";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@gid",gatherID);

                read = cmd.ExecuteReader();
                read.Read();
                gatherLabel.Text = read.GetString("SName") + ", " + read.GetString("FName") + " " + read.GetString("MName");
                read.Close();
                //get endorse
                cmd.Parameters.Clear();
                query = "SELECT ID,SNAME,FNAME,MNAME FROM PERSON WHERE ID=@eID;";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@eID", endorseID);

                read = cmd.ExecuteReader();
                read.Read();
                endorseLabel.Text = read.GetString("SName") + ", " + read.GetString("FName") + " " + read.GetString("MName");
                read.Close();

                //get home vaccination options
                cmd.Parameters.Clear();
                query = "SELECT * FROM " +
                    "(SELECT HM.FID, DESCRIPTION FROM HVAC_MAP AS HM LEFT JOIN HVAC_REF AS HR ON HM.HID = HR.HVACID) AS HVAC" +
                    " WHERE FID = @fId";
                cmd.CommandText = query;
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@fId", faceID);

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    hvacIn.AppendText(read.GetString("Description")+"\n");
                   
                }

                read.Close();

                //get cost table 
                cmd.Parameters.Clear();
                query = "SELECT * FROM COST_TABLE WHERE FACEID = @fId;";
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@fId",faceID);
                read = cmd.ExecuteReader();
                read.Read();

                mdNPIn.Text = read.GetString("mdnp");
                mdmealsIn.Text = read.GetString("mdm");
                mdoverIn.Text = read.GetString("mdo");
                mdndIn.Text = read.GetString("mdnd");
                mdhpIn.Text = read.GetString("mdhp");
                mdTranspoIn.Text = read.GetString("mdt");
                mdSomethingIn.Text = read.GetString("mds");
                mdLWTIn.Text = read.GetString("mdlwt");
                mdNoPaxIn.Text = read.GetString("mdpax");
                mdSub.Text = read.GetString("mdsubt");
                mdTotal.Text = read.GetString("mdtotal");

                hcNPIn.Text = read.GetString("hcnp");
                hcmealsIn.Text = read.GetString("hcm");
                hcoverIn.Text = read.GetString("hco");
                hcndIn.Text = read.GetString("hcnd");
                hchpIn.Text = read.GetString("hchp");
                hcTranspoIn.Text = read.GetString("hct");
                hcSomethingIn.Text = read.GetString("hcs");
                hcLWTIn.Text = read.GetString("hclwt");
                hcNoPaxIn.Text = read.GetString("hcpax");
                hcSub.Text = read.GetString("hcsubt");
                hcTotal.Text = read.GetString("hctotal");

                read.Close();
                CloseConnection();
            }
            else
            {
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
        private void ViewPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void ViewPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
        }

        private void personalEditButton_Click(object sender, EventArgs e)
        {
            if (!personalEdit) //enable editing of personal information
            {
                personalEditButton.Text = "Done";
                personalCancelButton.Visible = true;
                //set fields to Enabled and hide some.
                //make editable fields reflect current entity values.
               
                editNameButton.Visible = true;
                
                genderField.Visible = false;
                genderBox.Visible = true;
                genderBox.SelectedText = genderField.Text;
                
                natField.Enabled = true;
                relField.Enabled = true;
                civField.Enabled = true;

                birthField.Visible = false;
                datePicker.Visible = true;
                datePicker.Value = DateTime.Parse(birthField.Text);

                educField.Visible = false;
                educBox.Visible = true;
                educBox.SelectedText = "";
                educBox.SelectedText = educField.Text;

                genderField.Visible = false;
                genderBox.Visible = true;

                civField.Visible = false;
                civStatBox.Visible = true;
                civStatBox.SelectedText = "";
                civStatBox.SelectedText = civField.Text;

                personalEdit = true;
            }
            else //finalizes updates. Edit button == Done
            {
                patient.setGender(genderBox.Text);
                patient.setEducAttainment(educBox.Text);
                patient.setNationality(natField.Text);
                patient.setReligion(relField.Text);
                patient.setCivilStatus(civStatBox.Text);
                patient.setBday(datePicker.Value);

                if (OpenConnection())
                {
                    string query;
                    //sql operations go here.

                    query = string.Format("UPDATE PERSON SET SNAME = '{0}',FNAME = '{1}', MNAME = '{2}', " 
                        +"GENDER = '{3}', CIVSTAT = '{4}', NATIONALITY = '{5}', RELIGION = '{6}', "
                        +"EDUCATTAIN = '{7}',BDATE=@bday WHERE ID = @pid;",patient.getSurname(),patient.getFirstName(),
                        patient.getMidName(), patient.getGender(),patient.getCivilStatus(),patient.getNationality(),
                        patient.getReligion(),patient.getEducAttainment());

                    cmd.CommandText = query;
                    cmd.Prepare();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pid", patient.getID());
                    cmd.Parameters.AddWithValue("@bday",patient.getBDay());
                    cmd.ExecuteNonQuery();

                    personalEditButton.Text = "Edit";
                                       
                    editNameButton.Visible = false;

                    genderField.Visible = true;
                    genderField.Text = patient.getGender();
                    genderBox.Visible = false;

                    birthField.Visible = true;
                    birthField.Text = patient.getBDay().ToShortDateString();
                    datePicker.Visible = false;
     
                    educField.Visible = true;
                    educField.Text = patient.getEducAttainment();
                    educBox.Visible = false;

                    genderField.Visible = true;
                    genderField.Text = patient.getGender();
                    genderBox.Visible = false;

                    natField.Enabled = false;
                    natField.Text = patient.getNationality();
                    
                    relField.Enabled = false;
                    relField.Text = patient.getReligion();
                    
                    civField.Enabled = false;
                    civField.Visible = true;
                    civField.Text = patient.getCivilStatus();
                    civStatBox.Visible = false;
                    
                    personalEdit = false;
                    personalCancelButton.Visible = false;

                    CloseConnection();
                }

            }
        }

        private void contactEditButton_Click(object sender, EventArgs e)
        {
            if (!contactEdit)
            {
                contactEditButton.Text = "Done";

                editAddButton.Visible = true;
                contactCancelButton.Visible = true;

                homeField.Enabled = true;
                workField.Enabled = true;
                mobField.Enabled = true;
                otherField.Enabled = true;
                emailField.Enabled = true;

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

                contactEdit = true;
            }
            else
            {
                bool a, b, c, d,em;
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
        
                         patient.setNumbers(h, w, m, o);
                         patient.setEmail(emailField.Text);

                        string query;
                        query = string.Format("UPDATE PERSON SET STNUM = @stno, ADDLINE = '{0}', "
                            +" CITY = '{1}', REGION = '{2}',"
                            +"HOMENUM = '{3}',WORKNUM = '{4}',MOBNUM = '{5}',OTHERNUM = '{6}',EMAIL = '{7}'" 
                            + "WHERE ID = @pid;"
                            ,patient.getAddLine(),patient.getCity(),patient.getRegion(),
                             patient.getHomeNum(),patient.getWorkNum(),patient.getMobNum(),patient.getOtherNum()
                             ,patient.getEmail());
                        cmd.Parameters.Clear();
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@pid",patient.getID());
                        cmd.Parameters.AddWithValue("@stno",patient.getStNum());

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

                        if (String.IsNullOrEmpty(patient.getEmail()))
                            emailField.Text = "n/a";
                        else
                        {
                            emailField.Text = patient.getEmail();
                        }

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

                        contactEdit = false;
                        CloseConnection();
                    }
                    else
                    {
                    }
                }
                else
                {
                    Console.WriteLine("Errors"); 
                }
                
            }

        }

        private void personalCancelButton_Click(object sender, EventArgs e)
        {
            string d, f, m, l;
            d = tmp_Name.getDesignation();
            f = tmp_Name.getFirstName();
            m = tmp_Name.getMiddleName();
            l = tmp_Name.getLastName();
            patient.setName(d,f,m,l);
            nameField.Text = l + ", " + f + " " + m;
            birthField.Text = patient.getBDay().ToShortDateString();
            genderField.Text = patient.getGender();
            natField.Text = patient.getNationality();
            relField.Text = patient.getReligion();
            civField.Text = patient.getCivilStatus();
            educField.Text = patient.getEducAttainment();
            
            personalEditButton.Text = "Edit";

            nameField.Enabled = false;
            editNameButton.Visible = false;

            genderField.Visible = true;
            genderBox.Visible = false;

            birthField.Visible = true;
            datePicker.Visible = false;

            birthField.Visible = true;
            datePicker.Visible = false;

            educField.Visible = true;
            educBox.Visible = false;

            genderField.Visible = true;
            genderBox.Visible = false;

            natField.Enabled = false;
            relField.Enabled = false;
            civField.Enabled = false;

            civField.Visible = true;
            civStatBox.Visible = false;

            personalEdit = false;
            personalCancelButton.Visible = false;
        }

        private void contactCancelButton_Click(object sender, EventArgs e)
        {
            contactEditButton.Text = "Edit";
            contactCancelButton.Visible = false;
            editAddButton.Visible = false;

            addField1.Text = tmp_Address.Stno.ToString()+" "+tmp_Address.Addline;
            addField2.Text = tmp_Address.City + ", " + tmp_Address.Region;

            homeField.Enabled = false;
            workField.Enabled = false;
            mobField.Enabled = false;
            otherField.Enabled = false;
            emailField.Enabled = false;

            homeField.Text = tmp_Contact.Home.ToString();
            workField.Text = tmp_Contact.Work.ToString();
            mobField.Text = tmp_Contact.Mobile.ToString();
            otherField.Text = tmp_Contact.Other.ToString();
            emailField.Text = tmp_Contact.Email;

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
            

            contactEdit = false;

        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            ed = new EditName(patient.getDesig(),patient.getFirstName(),patient.getMidName(),patient.getSurname());
            ed.ShowDialog();
            if (ed.Status)
            {
                string d, f, m, l;
                d = ed.Designation;
                f = ed.FirstName;
                m = ed.MiddleName;
                l = ed.LastName;
                nameField.Text = l + ", " + f+ " " + m;
                patient.setName(d, f, m, l);
                //save updated name to temp
                //tmp_Name = new Objects.Name(d, f, m, l);
                ed.Close();
                
            }
            else
            {
                ed.Close();
            }

        }

        private void editAddButton_Click(object sender, EventArgs e)
        {
            EditAddress ed = new EditAddress(UInt16.Parse(patient.getStNum().ToString()), patient.getAddLine(), patient.getCity(),patient.getRegion());
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
                patient.setAddress(n,a,c,r);
                ed.Close();
            }
            else
            {
                ed.Close();
            }
        }





    }
}
