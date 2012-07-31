using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.RegForms;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class Login : Form
    {
        private string user, pass;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string server = "localhost";
        private string database = "hhc-db";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            pass = textBox2.Text;

            string connString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" +
                                "PASSWORD=" + pass + ";";

            conn = new MySqlConnection(connString);

            if (OpenConnection())
            {
                MainMenu mm = new MainMenu(this);
                this.Hide();
                mm.Show();
                CloseConnection();
            }
            else
            {
                MessageBox.Show("Invalid Log-in");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void clearPass()
        {
            textBox2.Text = "";
        }
    }
}
