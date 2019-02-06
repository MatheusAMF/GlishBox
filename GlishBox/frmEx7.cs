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
    public partial class frmEx7 : Form
    {
        public frmEx7()
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
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p1 = comboBox1.SelectedIndex; int p5 = comboBox5.SelectedIndex;
            int p2 = comboBox2.SelectedIndex; int p6 = comboBox6.SelectedIndex;
            int p3 = comboBox3.SelectedIndex; int p7 = comboBox7.SelectedIndex;
            int p4 = comboBox4.SelectedIndex; int p8 = comboBox8.SelectedIndex;

            if (p1 == 0 && p2 == 1 && p3 == 0 && p4 == 1 && p5 == 0 && p6 == 1 && p7 == 1 && p8 == 0)
            {
                label10.Visible = true;
            }

            if (p1 == 0) lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (p2 == 1) lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (p3 == 0) lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (p4 == 1) lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (p5 == 0) lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (p6 == 1) lblErrado6.Visible = false; lblCerto6.Visible = true;
            if (p7 == 1) lblErrado7.Visible = false; lblCerto7.Visible = true;
            if (p8 == 0) lblErrado8.Visible = false; lblCerto8.Visible = true;

            if (p1 != 0) lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (p2 != 1) lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (p3 != 0) lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (p4 != 1) lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (p5 != 0) lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (p6 != 1) lblCerto6.Visible = false; lblErrado6.Visible = true;
            if (p7 != 1) lblCerto7.Visible = false; lblErrado7.Visible = true;
            if (p8 != 0) lblCerto8.Visible = false; lblErrado8.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDica.Visible = true;
            lblDica2.Visible = true;
            lblDica3.Visible = true;
            lblDica4.Visible = true;
            lblDica5.Visible = true;
            lblDica6.Visible = true;
            lblDica7.Visible = true;
            lblDica8.Visible = true;
        }

        private void frmEx7_Load(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCerto1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado3_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado4_Click(object sender, EventArgs e)
        {

        }
    }
}
