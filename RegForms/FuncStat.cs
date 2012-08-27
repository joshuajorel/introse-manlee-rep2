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
    public partial class FuncStat : Form
    {
        private FunctionalStatus func;

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;

        private UInt16 fncID;
        private Boolean[] stat;
        private int num;
        private const int size = 12;

        public FuncStat(UInt16 id, string c)
        {
            InitializeComponent();
            num = 0;
            Boolean[] stat = new Boolean[] {true, true, true, true, true, true, true, true , true, true, true, true};
            func = new FunctionalStatus(stat);
            query = "";
            conn = new MySqlConnection(c);
            fncID = id; 
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

        private void FuncStat_Load(object sender, EventArgs e)
        {
            func.setStat(true, 0);
            func.setStat(true, 1);
            func.setStat(true, 2);
            func.setStat(true, 3);
            func.setStat(true, 4);
            func.setStat(true, 5);
            func.setStat(true, 6);
            func.setStat(true, 7);
            func.setStat(true, 8);
            func.setStat(true, 9);
            func.setStat(true, 10);
            func.setStat(true, 11);
        }

        private void addfunc(FunctionalStatus fs)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO FUNCSTAT(CGAID, ANSWER, NUMBER) VALUES" +
                    "(@id, @ans, @num)";

                cmd = new MySqlCommand(query, conn);
                cmd.CommandText = query;

                for(num = 0; num < 12; num++)
                {
                    cmd.Parameters.Clear();
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", fncID);
                    cmd.Parameters.AddWithValue("@ans", fs.getStat(num));
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Functional Status Recorded.");
                }
            }
            CloseConnection();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                func.setStat(true, 0);
            else
                func.setStat(false, 0);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                func.setStat(true, 1);
            else
                func.setStat(false, 1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                func.setStat(true, 2);
            else
                func.setStat(false, 2);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                func.setStat(true, 3);
            else
                func.setStat(false, 3);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
                func.setStat(true, 4);
            else
                func.setStat(false, 4);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
                func.setStat(true, 5);
            else
                func.setStat(false, 5);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
                func.setStat(true, 6);
            else
                func.setStat(false, 6);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
                func.setStat(true, 7);
            else
                func.setStat(false, 7);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
                func.setStat(true, 8);
            else
                func.setStat(false, 8);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
                func.setStat(true, 9);
            else
                func.setStat(false, 9);
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
                func.setStat(true, 10);
            else
                func.setStat(false, 10);
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
                func.setStat(true, 11);
            else
                func.setStat(false, 11);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            addfunc(func);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
