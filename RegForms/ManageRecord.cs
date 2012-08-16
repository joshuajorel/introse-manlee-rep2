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
    public partial class ManageRecord : Form
    {
        private string connString;

        public ManageRecord(string c)
        {
            InitializeComponent();

            connString = c;
        }

        private void ManageRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getEmployeeDetailsDB.getEmployeeDetails' table. You can move, or remove it, as needed.
            this.getEmployeeDetailsTableAdapter.Fill(this.getEmployeeDetailsDB.getEmployeeDetails);
            // TODO: This line of code loads data into the 'getEmployeeDetailsDB.getEmployeeDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'getClientDetailsDB.getClientDetails' table. You can move, or remove it, as needed.
            this.getClientDetailsTableAdapter.Fill(this.getClientDetailsDB.getClientDetails);
            // TODO: This line of code loads data into the 'getPatientDetailsDB.getPatientDetails' table. You can move, or remove it, as needed.
            this.getPatientDetailsTableAdapter.Fill(this.getPatientDetailsDB.getPatientDetails);
           

        }

        private void patientView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPatient v = new ViewPatient(UInt16.Parse(patientView.SelectedCells[0].Value.ToString()),connString);

            v.ShowDialog();
            
        }


    }
}
