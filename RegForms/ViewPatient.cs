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
        private bool personalEdit = false;
        private bool contactEdit = false;
        private bool clientEdit = false;
        EditName ed;
        

        private Patient patient;

        

        public ViewPatient(UInt16 id, string c)
        {   InitializeComponent();

            patient = new Patient();

            //initialize database connection
            conn = new MySqlConnection(c);

            patID = id;

            if (OpenConnection())
            {
                string query;
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

                ed = new EditName(d,fname,mname,sname);

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
                //set fields to Enabled
               
                editNameButton.Visible = true;
                
                genderField.Visible = false;
                genderBox.Visible = true;

                natField.Enabled = true;
                relField.Enabled = true;
                civField.Enabled = true;

                birthField.Visible = false;
                datePicker.Visible = true;

                educField.Visible = false;
                educBox.Visible = true;

                genderField.Visible = false;
                genderBox.Visible = true;

                personalEdit = true;
            }
            else //finalizes updates. Edit button == Done
            {
                if (OpenConnection())
                {
                    string query;
                    //sql operations go here.
                    personalEditButton.Text = "Edit";

                    
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

                    personalEdit = false;
                    personalCancelButton.Visible = false;

                    CloseConnection();
                }

                //update database entry
            }
        }

        private void personalCancelButton_Click(object sender, EventArgs e)
        {
            nameField.Text = patient.getSurname() + ", " + patient.getFirstName() + " " + patient.getMidName();
            birthField.Text = patient.getBDay().ToShortDateString();
            genderField.Text = patient.getGender();
            natField.Text = patient.getNationality();
            relField.Text = patient.getReligion();
            civField.Text = patient.getCivilStatus();
            educField.Text = patient.getEducAttainment();
            
            personalEditButton.Text = "Edit";

            nameField.Enabled = false;

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

            personalEdit = false;
            personalCancelButton.Visible = false;
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            ed.ShowDialog();
        }

    }
}
