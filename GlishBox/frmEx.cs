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
    public partial class frmEx : Form
    {
        public frmEx()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasice = new frmBasicEx();
            objbasice.ShowDialog();
            this.Close();
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
            Form1 objform1 = new Form1();
            objform1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmInterEx objintere = new frmInterEx();
            objintere.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmAvancEx objavanc = new frmAvancEx();
            objavanc.ShowDialog();
            this.Close();
        }
    }
}
