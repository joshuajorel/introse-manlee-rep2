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
    public partial class FuncStat : Form
    {
        private Boolean[] ans;
        public FuncStat()
        {
            InitializeComponent();
        }

        private void FuncStat_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ans[0] = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ans[0] = true;
        }
    }
}
