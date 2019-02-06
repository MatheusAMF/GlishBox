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
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmAula1 objaula1 = new frmAula1();
            objaula1.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmAula2 objaula2 = new frmAula2();
            objaula2.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmAula3 objaula3 = new frmAula3();
            objaula3.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmAula4 objaula4 = new frmAula4();
            objaula4.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmAula5 objaula5 = new frmAula5();
            objaula5.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmAula6 objaula6 = new frmAula6();
            objaula6.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmAula7 objaula7 = new frmAula7();
            objaula7.ShowDialog();
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
            frmAulas objaulas = new frmAulas();
            objaulas.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmAula8 objaula8 = new frmAula8();
            objaula8.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            frmAula9 objaula9 = new frmAula9();
            objaula9.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmAula10 objaula10 = new frmAula10();
            objaula10.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmAula11 objaula11 = new frmAula11();
            objaula11.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmAula12 objaula12 = new frmAula12();
            objaula12.ShowDialog();
            this.Close();
        }
    }
}
