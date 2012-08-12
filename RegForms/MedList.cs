﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introseHHC.RegForms
{
    public partial class MedList : Form
    {
        public string allout;
        public MedList()
        {
            InitializeComponent();
        }

        private void PMedHist_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Add Medication");
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
