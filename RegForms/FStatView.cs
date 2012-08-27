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
    public partial class FStatView : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader read;
        private MySqlCommand cmd;
        private bool[] ans;
        private int num = 0;
        private string query;
        private FunctionalStatus func;
        private UInt16 ID;
        private int ct;

        public FStatView(UInt16 id, string c)
        {
            InitializeComponent();
            ID = id;
            conn = new MySqlConnection(c);
            ct = 0;
            func = new FunctionalStatus();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FStatView_Load(object sender, EventArgs e)
        {
            if (OpenConnection())
            {
                query = "SELECT ANSWER FROM FUNCSTAT WHERE CGAID = @cgaID AND NUMBER = @num;";
                cmd = new MySqlCommand(query, conn);

                for (int num = 0; num < 12; num++)
                {
                    cmd.Prepare();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cgaID", ID);
                    cmd.Parameters.AddWithValue("@num", num);

                    read = cmd.ExecuteReader();
                    read.Read();
                    func.setStat(read.GetBoolean(0), num);
                    read.Close();
                    Console.WriteLine("Functional Status Read." + num);
                }
                CloseConnection();
            }

            for (ct = 0; ct < 12; ct++)
            {
                func.getStat(num);
            }

            if (func.getStat(0) == true)
            {
                radioButton1.Checked = true;
            }
            else if (func.getStat(0) == false)
            {
                radioButton2.Checked = true;
            }
            if (func.getStat(1) == true)
            {
                radioButton4.Checked = true;
            }
            else if (func.getStat(1) == false)
            {
                radioButton3.Checked = true;
            }
            if (func.getStat(2) == true)
            {
                radioButton6.Checked = true;
            }
            else if (func.getStat(2) == false)
            {
                radioButton5.Checked = true;
            }
            if (func.getStat(3) == true)
            {
                radioButton8.Checked = true;
            }
            else if (func.getStat(3) == false)
            {
                radioButton7.Checked = true;
            }
            if (func.getStat(4) == true)
            {
                radioButton10.Checked = true;
            }
            else if (func.getStat(4) == false)
            {
                radioButton9.Checked = true;
            }
            if (func.getStat(5) == true)
            {
                radioButton12.Checked = true;
            }
            else if (func.getStat(5) == false)
            {
                radioButton11.Checked = true;
            }
            if (func.getStat(6) == true)
            {
                radioButton14.Checked = true;
            }
            else if (func.getStat(6) == false)
            {
                radioButton13.Checked = true;
            }
            if (func.getStat(7) == true)
            {
                radioButton16.Checked = true;
            }
            else if (func.getStat(7) == false)
            {
                radioButton15.Checked = true;
            }
            if (func.getStat(8) == true)
            {
                radioButton18.Checked = true;
            }
            else if (func.getStat(8) == false)
            {
                radioButton17.Checked = true;
            }
            if (func.getStat(9) == true)
            {
                radioButton20.Checked = true;
            }
            else if (func.getStat(9) == false)
            {
                radioButton19.Checked = true;
            }
            if (func.getStat(10) == true)
            {
                radioButton22.Checked = true;
            }
            else if (func.getStat(10) == false)
            {
                radioButton21.Checked = true;
            }
            if (func.getStat(11) == true)
            {
                radioButton24.Checked = true;
            }
            else if (func.getStat(11) == false)
            {
                radioButton23.Checked = true;
            }
        }
    }
}
