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
    public partial class SocEnv : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private SocialEnvironment SE;

        private UInt16 socID;
        //private UInt16 patID;
        private string name;
        private string relation;
        private string freq;

        public UInt16 SocID
        {
            get { return socID; }
            set { socID = value; }
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

        public SocEnv(UInt16 pid, UInt16 id, string c)
        {
            InitializeComponent();

            conn = new MySqlConnection(c);
            socID = id;
            //patID = pid;
            SE = new SocialEnvironment();
            fillTable();

        }

        private void addsoc(SocialEnvironment se)
        {
            //conn.Open();
            if (OpenConnection())
            {
                string query = "INSERT INTO SOCIAL(CGAID, NAME, RELATIONSHIP, FREQUENCY) VALUES (@id, @name, @rel, @freq)";

                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@pid",patID);
                cmd.Parameters.AddWithValue("@id", SocID);
                cmd.Parameters.AddWithValue("@name", se.getNme());
                cmd.Parameters.AddWithValue("@rel", se.getRlp());
                cmd.Parameters.AddWithValue("@freq", se.getFv());

                Console.WriteLine(se.getNme() + se.getRlp() + se.getFv());

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Social Registry Has Been Added.");
                    nameField.Text = string.Empty;
                    relField.Text = string.Empty;
                    freqField.Text = string.Empty;
                    // check if the new one is _not_ the new row (this is the unexpected behavior mentioned in the questions comments)
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                CloseConnection();
                socEnvView.Rows.Clear();
                fillTable();           
            }
            
        }

        private void fillTable()
        {

            if (OpenConnection())
            {
                string query;
                query = "SELECT * FROM SOCIAL WHERE CGAID = @cgaID;";
                cmd = new MySqlCommand(query,conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cgaID", socID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {
                    x = socEnvView.Rows.Add();
                    socEnvView.Rows[x].Cells[0].Value = read.GetString("NAME");
                    socEnvView.Rows[x].Cells[1].Value = read.GetString("RELATIONSHIP");
                    socEnvView.Rows[x].Cells[2].Value = read.GetString("FREQUENCY");
                }
                read.Close();
                CloseConnection();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            name = nameField.Text;
            relation = relField.Text;
            freq = freqField.Text;

            SE.setNme(name);
            SE.setRlp(relation);
            SE.setFv(freq);
            //Console.WriteLine(SE.getNme() + " " + SE.getRlp() + " " + SE.getFv());
            addsoc(SE);
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}