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
    public partial class ViewCGA2 : Form
    {
        private UInt16 patID;
        private UInt16 cgaID;
        private UInt16 phyID;
        private bool cont = false;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private GDScales gds;
        private Boolean[] gdAns = new Boolean[]{true, false, false, false, true, false, true, false, false, false, true, true, true, false, false};
        private MentalExam me;
        private Nutrition nut;
        private Boolean[] meAns = new Boolean[30];
        private CGiverAssess ca;
        //for initializing the boolean array into false
        private void countBool()
        {
            for (int a = 0; a < meAns.Length; a++)
            {
                meAns[a] = false;
            }
        }

        public ViewCGA2()
        {
            InitializeComponent();
        }

        public ViewCGA2(UInt16 id,string c)
        {
            InitializeComponent();
            patID = id;
            conn = new MySqlConnection(c);
            gds = new GDScales(gdAns);
            countBool();
            me = new MentalExam(meAns);
            nut = new Nutrition();


            if (OpenConnection())
            {
                    string query = "SELECT * FROM CGA_FORM WHERE PATID = @pid;";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@pid", patID);
                    read = cmd.ExecuteReader();
                      read.Read();
                      try
                      {
                          cgaID = UInt16.Parse(read.GetString("CGAID"));
                          hiTB.Text = read.GetString("HINS");
                          ppcTB.Text = read.GetString("PCON");
                          phyID = UInt16.Parse(read.GetString("APHYS"));
                          read.Close();
                          cont = true;
                      }
                      catch (Exception err)
                      {
                          MessageBox.Show("No CGA.");
                          this.Hide();
                      }

                    if(cont)
                    {
                        query = "SELECT FNAME,SNAME,MNAME FROM PERSON WHERE ID = @eid;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@eid",phyID);
                        read = cmd.ExecuteReader();
                        read.Read();
                        apTB.Text = read.GetString(0)+" "+read.GetString(2)+" "+read.GetString(1);
                        read.Close();

                        query = "SELECT * FROM PERSONAL_HISTORY WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@cgaId", cgaID);
                        read = cmd.ExecuteReader();
                        read.Read();
                        allergyTB.Text = read.GetString("allergy");
                        smokingTB.Text = read.GetString("smoking");
                        drinkingTB.Text = read.GetString("drinking");
                        hobbyTB.Text = read.GetString("hobby");
                        read.Close();


                        //family history
                        query = "SELECT * FROM FAMILY_HISTORY WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        read = cmd.ExecuteReader();
                        read.Read();

                        if (read.GetString("diabetes").Equals("True"))
                            diaYesRB.Checked = true;
                        if (read.GetString("cancer").Equals("True"))
                            canYesRB.Checked = true;
                        if (read.GetString("tuberculosis").Equals("True"))
                            tubYesRB.Checked = true;
                        if (read.GetString("bleed").Equals("True"))
                            bdYesRB.Checked = true;
                        read.Close();


                        //geriatric depression scale
                        query = "SELECT ANSWER FROM GER_DEP_SCALE WHERE CGAID = @cgaID AND NUMBER = @num;";
                        cmd.CommandText = query;

                        for (int ctr = 0; ctr < 15; ctr++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@cgaID", cgaID);
                            cmd.Parameters.AddWithValue("@num", ctr);
                            cmd.Prepare();
                            read = cmd.ExecuteReader();
                            read.Read();
                            gds.setScale(ctr, read.GetBoolean(0));
                            read.Close();
                        }
                        gdTotalTB.Text = gds.computeScore().ToString() + " - " + gds.assess();

                        setGDRadioButtons();
                        
                        //mental status
                        query = "SELECT ANSWER FROM MENSTAT WHERE CGAID = @cgaID AND NUMBER = @num;";
                        cmd.CommandText = query;
                        
                        for (int ctr = 0; ctr < 29; ctr++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@cgaID", cgaID);
                            cmd.Parameters.AddWithValue("@num", ctr);
                            cmd.Prepare();
                            read = cmd.ExecuteReader();
                            read.Read();
                            me.setAns(ctr, read.GetBoolean(0));
                            read.Close();
                        }

                        setMECheckboxes();
                        msTB.Text = me.getScore().ToString();

                        //nutrition
                        query = "SELECT ANSWER FROM NUT_ASS WHERE CGAID = @cgaID AND NUMBER = @num;";
                        cmd.CommandText = query;

                        for (int ctr = 0; ctr < 17; ctr++)
                        {
                         
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@cgaID", cgaID);
                                cmd.Parameters.AddWithValue("@num", ctr);
                                cmd.Prepare();
                                read = cmd.ExecuteReader();
                                read.Read();
                                nut.setNut(ctr, read.GetFloat(0));
                                read.Close();
                        }

                        for(int ctr = 0; ctr < 3; ctr++)
                        {
                            cmd.Parameters.Clear();                            
                            cmd.Parameters.AddWithValue("@cgaID", cgaID);                            
                            cmd.Parameters.AddWithValue("@num", ctr+17);                            
                            cmd.Prepare();                            
                            read = cmd.ExecuteReader();                            
                            read.Read();
                            if (read.GetFloat(0) == 1)
                            {
                                nut.setProteinIntake(ctr, true);
                            }
                            else
                            {
                                nut.setProteinIntake(ctr, false);
                            }
                            read.Close();
                        }
                        
                        nutTB.Text = nut.getScore().ToString()+" - "+nut.assess();
                        
                        setNutRadioButtons();

                  }

                      



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

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (cgaID > 0)
            {
                if (OpenConnection())
                {
                    string query = "DELETE FROM CGA_FORM WHERE CGAID = @cgaID; ";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@cgaID", cgaID);
                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Delete Successful");
                    this.Hide();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void setGDRadioButtons()
        {
            //code is specific to answers in the CGA
            if (gds.getScale(0) == false)
            {
                gdNo1.Checked = true;
            }
            
            if (gds.getScale(1) == true)
            {
                gdScore2.Checked = true;
            } 
            
            if (gds.getScale(2) == true)
            {
                gdScore3.Checked = true;
            } 
            
            if (gds.getScale(3) == true)
            {
                gdScore4.Checked = true;
            }

            if(gds.getScale(4) == false)
            {
                gdNo5.Checked = true;
            }

            if(gds.getScale(5) == true)
            {
                gdScore6.Checked = true;
            }

            if(gds.getScale(6) == false)
            {
                gdNo7.Checked = true;
            }

            if(gds.getScale(7) == true)
            {
                gdScore8.Checked = true;
            }

            if(gds.getScale(8) == true)
            {
                gdScore9.Checked = true;
            }

            if(gds.getScale(9) == true)
            {
                gdScore10.Checked = true;
            }

            if(gds.getScale(10) == false)
            {
                gdNo11.Checked = true;
            }

            if(gds.getScale(11) == false)
            {
                gdNo12.Checked = true;
            }

            if(gds.getScale(12) == false)
            {
                gdNo13.Checked = true;
            }

            if(gds.getScale(13) == true)
            {
                gdScore14.Checked = true;
            }

            if(gds.getScale(14) == true)
            {
                gdScore15.Checked = true;
            }
        }

        private void setMECheckboxes()
        {
            if (me.getAns(0))
            {
                checkBox1.Checked = true;
            }

            if (me.getAns(1))
            {
                checkBox2.Checked = true;
            }

            if (me.getAns(2))
            {
                checkBox3.Checked = true;
            }

            if (me.getAns(3))
            {
                checkBox4.Checked = true;
            }

            if (me.getAns(4))
            {
                checkBox5.Checked = true;
            }

            if (me.getAns(5))
            {
                checkBox6.Checked = true;
            }
            
            if (me.getAns(6))
            {
                checkBox7.Checked = true;
            }

            if (me.getAns(7))
            {
                checkBox8.Checked = true;
            }

            if (me.getAns(8))
            {
                checkBox9.Checked = true;
            }

            if (me.getAns(9))
            {
                checkBox10.Checked = true;
            }

            if (me.getAns(10))
            {
                checkBox11.Checked = true;
            }

            if (me.getAns(11))
            {
                checkBox12.Checked = true;
            }

            if (me.getAns(12))
            {
                checkBox13.Checked = true;
            }

            if (me.getAns(13))
            {
                checkBox14.Checked = true;
            }

            if (me.getAns(14))
            {
                checkBox15.Checked = true;
            }

            if (me.getAns(15))
            {
                checkBox16.Checked = true;
            }

            if (me.getAns(16))
            {
                checkBox17.Checked = true;
            }

            if (me.getAns(17))
            {
                checkBox18.Checked = true;
            }

            if (me.getAns(18))
            {
                checkBox19.Checked = true;
            }

            if (me.getAns(19))
            {
                checkBox20.Checked = true;
            }

            if (me.getAns(20))
            {
                checkBox21.Checked = true;
            }

            if (me.getAns(21))
            {
                checkBox22.Checked = true;
            }

            if (me.getAns(22))
            {
                checkBox23.Checked = true;
            }

            if (me.getAns(23))
            {
                checkBox24.Checked = true;
            }

            if (me.getAns(24))
            {
                checkBox25.Checked = true;
            }

            if (me.getAns(25))
            {
                checkBox26.Checked = true;
            }

            if (me.getAns(26))
            {
                checkBox27.Checked = true;
            }

            if (me.getAns(27))
            {
                checkBox28.Checked = true;
            }

            if (me.getAns(28))
            {
                checkBox29.Checked = true;
            }
        }

        private void setNutRadioButtons()
        {
            if(nut.getNut(0)==0)
            {
                na1Btn1.Checked = true;
            }
            else if (nut.getNut(0) == 1)
            {
                na1Btn2.Checked = true;
            }

            if (nut.getNut(1) == 0)
            {
                na2Btn1.Checked = true;
            }
            else if (nut.getNut(1) == 0.5f)
            {
                na2Btn2.Checked = true;
            }

            if (nut.getNut(2) == 0)
            {
                na3Btn1.Checked = true;
            }

            if (nut.getNut(3) == 0)
            {
                na4Btn1.Checked = true;
            }
            else if (nut.getNut(3) == 1)
            {
                na4Btn2.Checked = true;
            }
            else if (nut.getNut(3) == 2)
            {
                na4Btn3.Checked = true;
            }

            if (nut.getNut(4) == 1)
            {
                na5Btn1.Checked = true;
            }

            if (nut.getNut(5) == 0)
            {
                na6Btn1.Checked = true;
            }

            if (nut.getNut(6) == 1)
            {
                na7Btn1.Checked = true;
            }

            if (nut.getNut(7) == 0)
            {
                na8Btn1.Checked = true;
            }
            else if (nut.getNut(7) == 1)
            {
                na8Btn2.Checked = true;
            }

            if (nut.getNut(8) == 0)
            {
                na9Btn1.Checked = true;
            }

            if (nut.getNut(9) == 0)
            {
                na10Btn1.Checked = true;
            }
            else if (nut.getNut(9) == 1)
            {
                na10Btn2.Checked = true;
            }

            if (nut.getNut(10) == 0)
            {
                na11Btn1.Checked = true;
            }

            if (nut.getNut(11) == 0)
            {
                na12Btn1.Checked = true;
            }
            else if (nut.getNut(11) == 1)
            {
                na12Btn2.Checked = true;
            }

            if (nut.getProteinIntake(0))
            {
                na13Btn1.Checked = true;
            }

            if (nut.getProteinIntake(1))
            {
                na14Btn1.Checked = true;
            }

            if (nut.getProteinIntake(2))
            {
                na15Btn1.Checked = true;
            }

            if (nut.getNut(13) == 1)
            {
                na16Btn1.Checked = true;
            }

            if (nut.getNut(14) == 0)
            {
                na17Btn1.Checked = true;
            }
            else if (nut.getNut(14) == 1)
            {
                na17Btn2.Checked = true;
            }

            if (nut.getNut(15) == 0)
            {
                na18Btn1.Checked = true;
            }
            else if (nut.getNut(15) == 0.5f)
            {
                na18Btn2.Checked = true;
            }

            if (nut.getNut(16) == 0)
            {
                na19Btn1.Checked = true;
            }
            else if (nut.getNut(16) == 1)
            {
                na19Btn2.Checked = true;
            }
        }
}
}
