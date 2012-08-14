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
    public partial class ViewPatient : Form
    {
        private UInt16 patID;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public ViewPatient(UInt16 id, string c)
        {
            InitializeComponent();

            //initialize database connection
                 

            conn = new MySqlConnection(c);

            patID = id;

            if (OpenConnection())
            {
                string query = "SELECT * FROM (SELECT * FROM PERSON RIGHT JOIN PATIENT ON PERSON.ID = PATID) AS TAB WHERE ID = @id;";
                cmd = new MySqlCommand(query,conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id",id);

                read = cmd.ExecuteReader();
                read.Read();

                nameField.Text = read.GetString("SName")+", "+read.GetString("FName")+" "+read.GetString("MName");
                birthField.Text = DateTime.Parse(read.GetString("BDate")).ToShortDateString();
                genderField.Text = read.GetString("Gender");
                civField.Text = read.GetString("CivStat");
                natField.Text = read.GetString("Nationality");
                relField.Text = read.GetString("Religion");
                educField.Text = read.GetString("EducAttain");
                addField1.Text = read.GetString("StNum") + " " + read.GetString("AddLine");
                addField2.Text = read.GetString("City") + ", " + read.GetString("Region");
                homeField.Text = read.GetString("HomeNum");
                workField.Text = read.GetString("WorkNum");
                mobField.Text = read.GetString("MobNum");
                otherField.Text = read.GetString("OtherNum");
                emailField.Text = read.GetString("Email");

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
    }
}
