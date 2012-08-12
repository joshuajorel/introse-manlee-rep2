using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introseHHC.RegForms
{
    public partial class Social : Form
    {    
        public string allout = "";
        public Social()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Social_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Describe Social Status");
            // find a way to view existing values
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {   
            string output = "";

            output = dataGridView1.CurrentCell.Value.ToString();
            this.Text = output;
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.CurrentCell.RowIndex + 1];
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            var input = this.dataGridView1.Rows;
            foreach (DataGridViewRow row in input)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        allout += cell.Value.ToString() + " ";
                    }
                }
            }
            Close();
        }

    }
}