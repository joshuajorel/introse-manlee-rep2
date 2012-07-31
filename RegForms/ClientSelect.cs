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
    public partial class ClientSelect : Form
    {
        private UInt16 sel;

        public UInt16 Sel
        {
            get { return sel; }
            set { sel = value; }
        }

        public ClientSelect()
        {
            InitializeComponent();
            sel = 0;
        }

  

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = UInt16.Parse(clientView.SelectedCells[0].Value.ToString());
        }

        private void ClientSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getClientsDB.getClients' table. You can move, or remove it, as needed.
            this.getClientsTableAdapter.Fill(this.getClientsDB.getClients);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = 0;
        }



    }
}
