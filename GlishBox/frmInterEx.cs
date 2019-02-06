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
    public partial class frmInterEx : Form
    {
        public frmInterEx()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmEx20 objex20 = new frmEx20();
            objex20.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmEx21 objex21 = new frmEx21();
            objex21.ShowDialog();
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
            frmEx objex = new frmEx();
            objex.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmEx22 objex22 = new frmEx22();
            objex22.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmEx23 objex23 = new frmEx23();
            objex23.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmEx24 objex24 = new frmEx24();
            objex24.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmEx13 objex13 = new frmEx13();
            objex13.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            frmEx14 objex14 = new frmEx14();
            objex14.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmEx15 objex15 = new frmEx15();
            objex15.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmEx16 objex16 = new frmEx16();
            objex16.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmEx17 objex17 = new frmEx17();
            objex17.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmEx18 objex18 = new frmEx18();
            objex18.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmEx19 objex19 = new frmEx19();
            objex19.ShowDialog();
            this.Close();
        }
    }
}
