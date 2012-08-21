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
            this.getEmployeeDetailsTableAdapter.Fill(this.getEmployeeDetailsDB.getEmployeeDetails);
            this.getClientDetailsTableAdapter.Fill(this.getClientDetailsDB.getClientDetails);
            this.getPatientDetailsTableAdapter.Fill(this.getPatientDetailsDB.getPatientDetails);

            connString = c;
        }

        private void ManageRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getEmployeeDetailsDB.getEmployeeDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'getEmployeeDetailsDB.getEmployeeDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'getClientDetailsDB.getClientDetails' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'getPatientDetailsDB.getPatientDetails' table. You can move, or remove it, as needed.
            
           

        }

        private void patientView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewPatient v = new ViewPatient(UInt16.Parse(patientView.SelectedCells[0].Value.ToString()),connString);

            v.ShowDialog();
            if (v.CloseStatus)
            {
                this.getPatientDetailsTableAdapter.Fill(this.getPatientDetailsDB.getPatientDetails);
                v.Close();

            }
            
        }

        private void clientView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewClient vc = new ViewClient(UInt16.Parse(clientView.SelectedCells[0].Value.ToString()),connString);

            vc.ShowDialog();
            if (vc.CloseStatus)
            {
                this.getClientDetailsTableAdapter.Fill(this.getClientDetailsDB.getClientDetails);
                vc.Close();
            }
        }

        private void employeeView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewEmployee ve = new ViewEmployee(UInt16.Parse(employeeView.SelectedCells[0].Value.ToString()),connString);
            ve.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patSearch_Click(object sender, EventArgs e)
        {
            getPatientDetailsBindingSource.Filter = string.Format("Surname LIKE '{0}'", patSearchIn.Text);
               
        }

        private void pClearButton_Click(object sender, EventArgs e)
        {
            getPatientDetailsBindingSource.Filter = "";
            patSearchIn.Text = "";
        }

        private void clientSearch_Click(object sender, EventArgs e)
        {
            getClientDetailsBindingSource.Filter = string.Format("Surname LIKE '{0}'",clientSearchIn.Text);
        }

        private void clientClearButton_Click(object sender, EventArgs e)
        {
            clientSearchIn.Text = "";
            getClientDetailsBindingSource.Filter = "";
        }

        private void empSearch_Click(object sender, EventArgs e)
        {
            getEmployeeDetailsBindingSource.Filter = string.Format("Surname LIKE '{0}'", empSearchIn.Text);
        }

        private void empClearButton_Click(object sender, EventArgs e)
        {
            empSearchIn.Text = "";
            getEmployeeDetailsBindingSource.Filter = "";
        }





    }
}
