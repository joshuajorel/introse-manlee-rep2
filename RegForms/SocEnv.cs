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
        private DataSet ds;

        private SocEnv Soc;
        private DataTable dtb;
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
            DataSet ds = new DataSet();
            UInt16 cgaID;
             
                string query = "SELECT socenv.name AS 'Name', socenv.relationship AS 'Relationship'" +
                    "socenv.frequency AS 'Frequency of Visit' " +
                    "FROM socenv LEFT JOIN cga_form ON cga_form.cgaid = socenv.cgaid;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);

                read = cmd.ExecuteReader();
                read.Read();
                //cgaID = UInt16.Parse(read.GetString("ID"));

                //DataTable dtb = new DataTable();

               // dataGridView1.DataSource = dtb;
                //sel = 
     
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
    }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    AddSoc se = new AddSoc();
        //    se.ShowDialog();
           // dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
           /* DataRow dr = dtb.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;

            dtb.Rows.Add(dr);
            dataGridView1.DataSource = dtb;
            //dapt.Update(dtb);*/
        }

        private void SocEnv_Load(object sender, EventArgs e)
        {
            
        }
    }
}
