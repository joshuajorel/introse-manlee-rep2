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

            //DataTable dtb = new DataTable();

            // dataGridView1.DataSource = dtb;
        }

        private void addsoc(SocialEnvironment se)
        {
            conn.Open();
            string query = "INSERT INTO SOCIAL(NAME, RELATIONSHIP, FREQUENCY) VALUES" +
                "(@name, @rel, @freq)";

            cmd = new MySqlCommand(query, conn);
            cmd.Prepare();

            //cmd.Parameters.AddWithValue("@id", SocID);
            cmd.Parameters.AddWithValue("@name", se.getNme());
            cmd.Parameters.AddWithValue("@rel", se.getRlp());
            cmd.Parameters.AddWithValue("@freq", se.getFv());

            try
            {
                cmd.ExecuteNonQuery();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                Console.WriteLine("Social Registry Has Been Added.");

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();

        }

        private void SocEnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getSocial._getSocial' table. You can move, or remove it, as needed.
            this.getSocialTableAdapter.Fill(this.getSocial._getSocial);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            relation = textBox2.Text;
            freq = textBox3.Text;

            SE.setNme(name);
            SE.setRlp(relation);
            SE.setFv(freq);
            addsoc(SE);
        }

    }
}