using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApp
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCriança_CheckedChanged(object sender, EventArgs e)
        {
            chkCriança.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkCriança.Checked = false;

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCriança.ForeColor = Color.Gray;
            chkAdulto.ForeColor = Color.DarkOrange;
            chkAdulto.Checked = false;  

        }
    }
}
