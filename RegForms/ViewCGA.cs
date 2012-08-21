using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class ViewCGA : Form
    {
        private UInt16 patID;
        private UInt16 cgaID;
        private UInt16 phyID;
        private bool cont = false;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public ViewCGA()
        {
            InitializeComponent();
        }

        public ViewCGA(UInt16 id,string c)
        {
            InitializeComponent();
            patID = id;
            conn = new MySqlConnection(c);

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

                        query = "SELECT * FROM FAMILY_HISTORY WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        read = cmd.ExecuteReader();
                        read.Read();
                        tbField.Text = "No";
                        bleedField.Text = "No";
                        diabetesField.Text = "No";
                        cancerField.Text = "No";

                        if(read.GetString("diabetes").Equals("True"))
                            diabetesField.Text = "Yes";
                        if (read.GetString("cancer").Equals("True"))
                            cancerField.Text = "Yes";
                        if (read.GetString("tuberculosis").Equals("True"))
                            tbField.Text = "Yes";
                        if (read.GetString("bleed").Equals("True"))
                            bleedField.Text = "Yes";
                        read.Close();

                        query = "SELECT ANSWER FROM GER_DEP_SCALE WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        read = cmd.ExecuteReader();
                        read.Read();

                        gdsField.Text = read.GetString(0);
                        read.Close();

                        query = "SELECT ANSWER FROM MENSTAT WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        read = cmd.ExecuteReader();
                        read.Read();

                        mentalField.Text = read.GetString(0);
                        read.Close();

                        query = "SELECT ANSWER FROM NUT_ASS WHERE CGAID = @cgaID;";
                        cmd.CommandText = query;
                        cmd.Prepare();
                        read = cmd.ExecuteReader();
                        read.Read();

                        nutriField.Text = read.GetString(0);
                        read.Close();


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
                    cmd = new MySqlCommand(query,conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@cgaID",cgaID);
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
    }
}
