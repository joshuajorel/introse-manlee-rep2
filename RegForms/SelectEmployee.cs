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

        public UInt16 Sel
        {
            get { return sel; }
            set { sel = value; }
        }

        public SelectEmployee()
        {
            InitializeComponent();
            sel = 0;

        }

        private void SelectEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getEmployeesDB.getEmployees' table. You can move, or remove it, as needed.
            this.getEmployeesTableAdapter.Fill(this.getEmployeesDB.getEmployees);

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = UInt16.Parse(employeeView.SelectedCells[0].Value.ToString());
        }
    }
}
