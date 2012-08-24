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
    public partial class ConnSetup : Form
    {
        private MySqlConnection conn;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private string uname;

        public string Uname
        {
            get { return uname; }
            set { uname = value; }
        }
        private string pword;

        public string Pword
        {
            get { return pword; }
            set { pword = value; }
        }
        private string serv;

        public string Serv
        {
            get { return serv; }
            set { serv = value; }
        }
        private string db;

        public ConnSetup(string s,string d, string u)
        {
            InitializeComponent();
            status = false;
            uname = "";
            pword = "";
            serv = "";
            db = d;
            serverField.Text = s;
            unameField.Text = u;

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            bool u, p, s;

            uname = unameField.Text;
            pword = passField.Text;
            serv = serverField.Text;

            u = string.IsNullOrEmpty(uname) || string.IsNullOrWhiteSpace(uname);
            p = string.IsNullOrEmpty(pword) || string.IsNullOrWhiteSpace(pword);
            s = string.IsNullOrEmpty(serv) || string.IsNullOrWhiteSpace(serv);

            if (!u && !p && !s)
            {
                status = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kindly fill in all fields.","Message");
            }

            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            status = false;
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
    }
}
