﻿using System;
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
    public partial class ViewEmployee : Form
    {
        private bool closeStatus = false;

        public bool CloseStatus
        {
            get { return closeStatus; }
            set { closeStatus = value; }
        }
        private UInt16 employeeID;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private Name tmp_Name;
        private Address tmp_Address;
        private Contact tmp_Contact;
        private bool personalEdit = false;
        private bool contactEdit = false;
        private Employee emp;

        public ViewEmployee(UInt16 id, string c)
        {
            InitializeComponent();
            conn = new MySqlConnection(c);
            employeeID = id;
            emp = new Employee();

            if (OpenConnection())
            {   
                string query;
                string fname, sname, mname;
                string d;
                string num, a, ct, r;
                int hnum, wnum, mnum, onum;
                string email;
                DateTime bday;
                //get patient personal details
                query = "SELECT * FROM (SELECT * FROM PERSON RIGHT JOIN EMPLOYEE ON PERSON.ID = EMPID) AS TAB WHERE ID = @id;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);

                read = cmd.ExecuteReader();
                read.Read();

                sname = read.GetString("SName");
                fname = read.GetString("FName");
                mname = read.GetString("MName");
                d = read.GetString("Designation");
                bday = DateTime.Parse(read.GetString("BDate"));
                num = read.GetString("StNum");
                a = read.GetString("AddLine");
                ct = read.GetString("City");
                r = read.GetString("Region");
                hnum = int.Parse(read.GetString("HomeNum"));
                wnum = int.Parse(read.GetString("WorkNum"));
                mnum = int.Parse(read.GetString("MobNum"));
                onum = int.Parse(read.GetString("OtherNum"));
                email = read.GetString("Email");

                nameField.Text = sname + ", " + fname + " " + mname;
                birthField.Text = bday.ToShortDateString();
                datePicker.Value = bday;
                genderField.Text = read.GetString("Gender");
                genderBox.Text = genderField.Text;
                civField.Text = read.GetString("CivStat");
                civStatBox.Text = civField.Text;
                natField.Text = read.GetString("Nationality");
                relField.Text = read.GetString("Religion");
                educField.Text = read.GetString("EducAttain");
                educBox.Text = educField.Text;
                addField1.Text = num + " " + a;
                addField2.Text = ct + ", " + r;
                homeField.Text = hnum.ToString();
                workField.Text = wnum.ToString();
                mobField.Text = mnum.ToString();
                otherField.Text = onum.ToString();
                emailField.Text = email;

                //save values to Employee object
                emp.setID(id);
                emp.setName(d, fname, mname, sname);
                emp.setBday(bday);
                emp.setCivilStatus(civField.Text);
                emp.setNationality(natField.Text);
                emp.setEducAttainment(educField.Text);
                emp.setGender(genderField.Text);
                emp.setReligion(relField.Text);
                emp.setNumbers(hnum, wnum, mnum, onum);
                emp.setEmail(email);
                emp.setAddress(UInt16.Parse(num), a, ct, r);

                //save a copy of the Name
                tmp_Name = new Objects.Name(d, fname, mname, sname);
                //save a copy of address
                tmp_Address = new Address(UInt16.Parse(num), a, ct, r);
                //save a copy of contact details
                tmp_Contact = new Contact(hnum, wnum, mnum, onum);
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
            closeStatus = true;
            this.Hide();
        }

        private void ViewEmployee_FormClosed(object sender, FormClosedEventArgs e)
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

                birthField.Visible = false;
                datePicker.Visible = true;
                genderField.Visible = false;
                genderBox.Visible = true;

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

                bool gen, ed, rel, civ, nat;

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
                        + "EDUCATTAIN = '{7}',BDATE=@bday WHERE ID = @eid;", emp.getSurname(), emp.getFirstName(),
                        emp.getMidName(), genderBox.Text, civStatBox.Text, natField.Text,
                        relField.Text, educBox.Text);

                        cmd.CommandText = query;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@eid", employeeID);
                        cmd.Parameters.AddWithValue("@bday", emp.getBDay());
                        cmd.ExecuteNonQuery();

                        CloseConnection();

                        birthField.Visible = true;
                        birthField.Text = emp.getBDay().ToShortDateString();
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
                    if (!ed)
                        sb.Append("Educational Attainment not in selection.\n");
                    if (!rel)
                        sb.Append("Invalid format in Religion.\n");
                    if (!civ)
                        sb.AppendLine("Civil Status not in selection.");
                    if (!nat)
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
            EditName ed = new EditName(emp.getDesig(), emp.getFirstName(), emp.getMidName(), emp.getSurname());
            ed.ShowDialog();

            if (ed.Status) //executes when the user presses OK in EditName Dialog box
            {
                string d, f, m, l;
                d = ed.Designation;
                f = ed.FirstName;
                m = ed.MiddleName;
                l = ed.LastName;
                nameField.Text = l + ", " + f + " " + m;
                emp.setName(d, f, m, l);

                ed.Close();
            }
            else
            {
                ed.Close();
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
            birthField.Text = emp.getBDay().ToShortDateString();
            genderField.Text = emp.getGender();
            relField.Text = emp.getReligion();
            natField.Text = emp.getNationality();
            civField.Text = emp.getCivilStatus();
            educField.Text = emp.getEducAttainment();

            personalEdit = false;
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
                int h, w, m, o;
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
                        h = int.Parse(homeField.Text);
                        w = int.Parse(workField.Text);
                        m = int.Parse(mobField.Text);
                        o = int.Parse(otherField.Text);

                        string query;

                        query = string.Format("UPDATE PERSON SET STNUM = @stno, ADDLINE = '{0}', "
                            + " CITY = '{1}', REGION = '{2}',"
                            + "HOMENUM = '{3}',WORKNUM = '{4}',MOBNUM = '{5}',OTHERNUM = '{6}',EMAIL = '{7}'"
                            + "WHERE ID = @eid;"
                            , emp.getAddLine(), emp.getCity(), emp.getRegion(),
                             h, w, m, o
                             , emailField.Text);
                        cmd.Parameters.Clear();
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@eid", employeeID);
                        cmd.Parameters.AddWithValue("@stno", emp.getStNum());

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

                    if (!a)
                        sb.AppendLine("-Invalid Home number.");
                    if (!b)
                        sb.AppendLine("-Invalid Work Number.");
                    if (!c)
                        sb.AppendLine("-Invalid Mobile Number.");
                    if (!d)
                        sb.AppendLine("-Invalid Other Number.");
                    if (!em)
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
            EditAddress ed = new EditAddress(UInt16.Parse(emp.getStNum().ToString()), emp.getAddLine(), emp.getCity(), emp.getRegion());
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
                emp.setAddress(n, a, c, r);
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
