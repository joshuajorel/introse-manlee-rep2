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
    public partial class PMedView : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;
        private string connString;
        private string diag;
        private string pla;
        private DateTime dat;
        private UInt16 ID;
        private MedicalHistory mh;
        private int ct;

        public PMedView(UInt16 id, string c)
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

        private void PMedView_Load(object sender, EventArgs e)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM PMED_HIS WHERE PATID = @pid;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@pid", ID);

                read = cmd.ExecuteReader();

                int ct;
                while (read.Read())
                {
                    ct = medhisView.Rows.Add();
                    medhisView.Rows[ct].Cells[0].Value = read.GetString("DIAGNOSIS");
                    medhisView.Rows[ct].Cells[1].Value = read.GetString("PLACECON");
                    medhisView.Rows[ct].Cells[2].Value = read.GetString("INCDATE");
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
