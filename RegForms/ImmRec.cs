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
    public partial class ImmRec : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;
        private Immunization imm;

        private UInt16 immID;
        private DateTime date;
        private string desc;

        public ImmRec(UInt16 id, string c)
        {
            InitializeComponent();

            conn = new MySqlConnection(c);
            immID = id;
            imm = new Immunization();
            fillTable();
        }

        public UInt16 ImmID
        {
            get { return immID; }
            set { immID = value; }
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

        private void setimmrec(Immunization rec)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO IM_REC(CGAID, IMMDATE, DESCRIPTION)" +
                    "VALUES (@id, @date, @desc)";

                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", ImmID);
                cmd.Parameters.AddWithValue("@date", rec.getDate());
                cmd.Parameters.AddWithValue("@desc", rec.getDesc());

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Immunization Record Has Been Added.");
                    descField.Text = string.Empty;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            CloseConnection();
            immrecView.Rows.Clear();
            fillTable();
        }

        private void fillTable()
        {

            if (OpenConnection())
            {
                string query;
                query = "SELECT * FROM IM_REC WHERE CGAID = @cgaID;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cgaID", immID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {
                    x = immrecView.Rows.Add();
                    immrecView.Rows[x].Cells[0].Value = read.GetString("DESCRIPTION");
                    immrecView.Rows[x].Cells[1].Value = read.GetString("IMMDATE");
                }
                read.Close();
                CloseConnection();
            }
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            date = dateField.Value;
            desc = descField.Text;

            imm.setDesc(desc);
            imm.setDate(date);

            setimmrec(imm);
        }
    }
}
