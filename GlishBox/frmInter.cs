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
    public partial class frmInter : Form
    {
        public frmInter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            frmAula13 objaula13 = new frmAula13();
            objaula13.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmAula18 objaula18 = new frmAula18();
            objaula18.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmAula14 objaula14 = new frmAula14();
            objaula14.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAulas objaulas = new frmAulas();
            objaulas.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmAula15 objaula15 = new frmAula15();
            objaula15.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmAula16 objaula16 = new frmAula16();
            objaula16.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmAula17 objaula17 = new frmAula17();
            objaula17.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmAula19 objaula19 = new frmAula19();
            objaula19.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmAula20 objaula20 = new frmAula20();
            objaula20.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmAula21 objaula21 = new frmAula21();
            objaula21.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmAula22 objaula22 = new frmAula22();
            objaula22.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmAula23 objaula23 = new frmAula23();
            objaula23.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            frmAula24 objaula24 = new frmAula24();
            objaula24.ShowDialog();
            this.Close();
        }
    }
}
