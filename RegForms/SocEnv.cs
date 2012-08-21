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
        private string server;
        private string database;
        private string user;
        private string password;
        private SocialEnvironment SE;

        private SocEnv Soc;
        private UInt16 socID;
        private string name;
        private string relation;
        private string freq;

        public UInt16 SocID
        {
            get { return socID; }
            set { socID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        public string Freq
        {
            get { return freq; }
            set { freq = value; }
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

        public SocEnv(UInt16 id, string c)
        {
            InitializeComponent();
            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            conn = new MySqlConnection(c);
            SocID = id;
            SE = new SocialEnvironment();


            //cgaID = UInt16.Parse(read.GetString("ID"));
        }

        private void addsoc(SocialEnvironment se)
        {
            //conn.Open();
            if (OpenConnection())
            {
                string query = "INSERT INTO SOCIAL(CGAID, NAME, RELATIONSHIP, FREQUENCY) VALUES (@id, @name, @rel, @freq)";


                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", SocID);
                cmd.Parameters.AddWithValue("@name", se.getNme());
                cmd.Parameters.AddWithValue("@rel", se.getRlp());
                cmd.Parameters.AddWithValue("@freq", se.getFv());

                Console.WriteLine(se.getNme() + se.getRlp() + se.getFv());

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Social Registry Has Been Added.");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    // check if the new one is _not_ the new row (this is the unexpected behavior mentioned in the questions comments)
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                CloseConnection();
            }

        }

        private void SocEnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getSocial._getSocial' table. You can move, or remove it, as needed.
            this.getSocialTableAdapter.Fill(this.getSocial._getSocial);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            name = textBox1.Text;
            relation = textBox2.Text;
            freq = textBox3.Text;

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
    }
}