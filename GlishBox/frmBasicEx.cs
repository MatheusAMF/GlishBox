using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace GlishBox
{
    public partial class frmBasicEx : Form
    {
        public frmBasicEx()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmEx1 objex1 = new frmEx1();
            objex1.ShowDialog();
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

        private void label3_Click(object sender, EventArgs e)
        {
            frmEx2 objex2 = new frmEx2();
            objex2.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmEx3 objex3 = new frmEx3();
            objex3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEx objex = new frmEx();
            objex.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmEx4 objex4 = new frmEx4();
            objex4.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmEx5 objex5 = new frmEx5();
            objex5.ShowDialog();
            this.Close();
        }

        private void frmBasicEx_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmEx6 objex6 = new frmEx6();
            objex6.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmEx7 objex7 = new frmEx7();
            objex7.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmEx8 objex8 = new frmEx8();
            objex8.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            frmEx9 objex9 = new frmEx9();
            objex9.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmEx10 objex10 = new frmEx10();
            objex10.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmEx11 objex11 = new frmEx11();
            objex11.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmEx12 objex12 = new frmEx12();
            objex12.ShowDialog();
            this.Close();
        }
    }
}
