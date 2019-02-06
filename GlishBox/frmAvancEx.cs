using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlishBox
{
    public partial class frmAvancEx : Form
    {
        public frmAvancEx()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEx objex = new frmEx();
            objex.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmEx25 objex25 = new frmEx25();
            objex25.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmEx26 objex26 = new frmEx26();
            objex26.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmEx27 objex27 = new frmEx27();
            objex27.ShowDialog();
            this.Close();
        }
    }
}
