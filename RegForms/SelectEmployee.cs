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
    public partial class SelectEmployee : Form
    {
        private UInt16 sel;
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string sname;

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }

        public UInt16 Sel
        {
            get { return sel; }
            set { sel = value; }
        }

        public SelectEmployee()
        {
            InitializeComponent();
            sel = 0;
            fname = sname = "";

        }

        private void SelectEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getEmployeesDB1.getEmployees' table. You can move, or remove it, as needed.
            this.getEmployeesTableAdapter2.Fill(this.getEmployeesDB1.getEmployees);
            // TODO: This line of code loads data into the 'getEmployeeDB.getEmployees' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'getEmployeesDB.getEmployees' table. You can move, or remove it, as needed.

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = UInt16.Parse(employeeView.SelectedCells[0].Value.ToString());
            fname = employeeView.SelectedCells[1].Value.ToString();
            sname = employeeView.SelectedCells[2].Value.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = 0;
            fname = "";
            sname = "";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getEmployeesBindingSource.Filter = string.Format("Surname LIKE '{0}'",searchIn.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchIn.Text = "";
            getEmployeesBindingSource.Filter = "";
        }

        private void searchIn_TextChanged(object sender, EventArgs e)
        {
            getEmployeesBindingSource.Filter = string.Format("Surname LIKE '*{0}*'", searchIn.Text);
        }
    }
}
