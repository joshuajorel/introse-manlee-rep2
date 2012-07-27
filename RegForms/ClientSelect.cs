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
        public ClientSelect()
        {
            InitializeComponent();
        }

        private void ClientSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_hhc_dbDataSet.getClients' table. You can move, or remove it, as needed.
            this.getClientsTableAdapter.Fill(this._hhc_dbDataSet.getClients);

        }
    }
}
