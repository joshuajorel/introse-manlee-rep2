using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using introseHHC.Objects;
using MySql.Data.MySqlClient;

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
        private MySqlConnection conn2;

        private SocEnv Soc;
        private DataTable dtb;
        private OleDbDataAdapter dapt;
        private UInt16 sel;

        public UInt16 Sel
        {
            get { return sel; }
            set { sel = value; }
        }

        public SocEnv()
        {
            InitializeComponent();
            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            string connString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" +
                                "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connString);
            //conn2 = OleDbConnection("@"+connString);
            SocEnv Soc = new SocEnv();
             

           /* if (OpenConnection())
            {
                string query = "SELECT socenv.name AS 'Name', socenv.relationship AS 'Relationship'" +
                    "socenv.frequency AS 'Frequency of Visit' cga_form.cgaid AS 'CGA Number'" +
                    "FROM socenv LEFT JOIN cga_form ON cga_form.cgaid = socenv.cgaid;";
                OleDbDataAdapter dapt = new OleDbDataAdapter(query, conn);
                //this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                OleDbCommandBuilder comb = new OleDbCommandBuilder(dapt);

                DataTable dtb = new DataTable();
                dapt.Fill(dtb, query);
                dapt.Update(dtb);
                dataGridView1.DataSource = dtb;
                //sel = 
            }*/
        }

        /* public void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
         {
             string output = "";

             output = dataGridView1.CurrentCell.Value.ToString();
             this.Text = output;

             int col = dataGridView1.CurrentCell.ColumnIndex;
             int rows = dataGridView1.CurrentCell.RowIndex;
             if (col == dataGridView1.Columns.Count - 1)
                 dataGridView1.CurrentCell = dataGridView1[0, rows + 1];
             else
                 dataGridView1.CurrentCell = dataGridView1[col + 1, rows];

         }*/

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            AddSoc se = new AddSoc();
            se.ShowDialog();
            //dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            DataRow dr = dtb.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;

            dtb.Rows.Add(dr);
            dataGridView1.DataSource = dtb;
            dapt.Update(dtb);
        }*/
    }
}
