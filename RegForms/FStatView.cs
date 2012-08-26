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
        private bool ans;
        private int num;
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
            if (func.getStat(num) != null)
            {
                for (num = 0; num < 12; num++)
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
            else
            {
                radioButton1.Checked = true;
                radioButton4.Checked = true;
                radioButton6.Checked = true;
                radioButton8.Checked = true;
                radioButton10.Checked = true;
                radioButton12.Checked = true;
                radioButton14.Checked = true;
                radioButton16.Checked = true;
                radioButton18.Checked = true;
                radioButton20.Checked = true;
                radioButton22.Checked = true;
                radioButton24.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
