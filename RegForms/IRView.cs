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
    public partial class IRView : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader read;
        private MySqlCommand cmd;
        private string desc;
        private DateTime date;
        private string query;
        private Immunization se;
        private UInt16 ID;
        private int ct;

        public IRView(UInt16 id, string c)
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

        private void IRView_Load(object sender, EventArgs e)
        {
            if (OpenConnection()) ;
            {
                query = "SELECT * FROM IM_REC WHERE CGAID = @cgaid;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.Add("@cgaid", ID);
                cmd.ExecuteReader();

                while (read.Read())
                {
                    ct = immrecView.Rows.Add();
                    immrecView.Rows[ct].Cells[0].Value = read.GetString("DESCRIPTION");
                    immrecView.Rows[ct].Cells[1].Value = read.GetString("IMMDATE");
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
