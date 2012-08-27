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
    public partial class SocView : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader read;
        private MySqlCommand cmd;
        private string nme;
        private string rel;
        private string freq;
        private string query;
        private SocialEnvironment se;
        private UInt16 ID;
        private int ct;

        public SocView(UInt16 id, string c)
        {
            InitializeComponent();
            ID = id;
            conn = new MySqlConnection(c);
            ct = 0;
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

        private void SocView_Load(object sender, EventArgs e)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM SOCIAL WHERE CGAID = @cgaid;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cgaid", ID);
                read = cmd.ExecuteReader();

                int ct;
                while (read.Read())
                {
                    ct = socEnvView.Rows.Add();
                    socEnvView.Rows[ct].Cells[0].Value = read.GetString("NAME");
                    socEnvView.Rows[ct].Cells[1].Value = read.GetString("RELATIONSHIP");
                    socEnvView.Rows[ct].Cells[2].Value = read.GetString("FREQUENCY");
                }
                read.Close();
                CloseConnection();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
