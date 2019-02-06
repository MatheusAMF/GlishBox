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
    public partial class frmEx22 : Form
    {
        public frmEx22()
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

        private void lblCerto3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInterEx objInterex = new frmInterEx();
            objInterex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4, r5, r6, r7, r8;
            r1 = Convert.ToString(textBox1.Text); r5 = Convert.ToString(textBox5.Text);
            r2 = Convert.ToString(textBox2.Text); r6 = Convert.ToString(textBox6.Text);
            r3 = Convert.ToString(textBox3.Text); r7 = Convert.ToString(textBox7.Text);
            r4 = Convert.ToString(textBox4.Text); r8 = Convert.ToString(textBox8.Text);

            string R1 = r1.ToLower(); string R5 = r5.ToLower();
            string R2 = r2.ToLower(); string R6 = r6.ToLower();
            string R3 = r3.ToLower(); string R7 = r7.ToLower();
            string R4 = r4.ToLower(); string R8 = r8.ToLower();

            if (R1 == "on" && R2 == "at" && R3 == "on" && R4 == "in" && R5 == "at" && R6 == "at" && R7 == "on" && R8 == "in")
            {
                label10.Visible = true;
            }
            if (R1 == "on") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "at") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "on") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "in") lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "at") lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (R6 == "at") lblErrado6.Visible = false; lblCerto6.Visible = true;
            if (R7 == "on") lblErrado7.Visible = false; lblCerto7.Visible = true;
            if (R8 == "in") lblErrado8.Visible = false; lblCerto8.Visible = true;

            if (R1 != "on") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "at") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "on") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "in") lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "at") lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (R6 != "at") lblCerto6.Visible = false; lblErrado6.Visible = true;
            if (R7 != "on") lblCerto7.Visible = false; lblErrado7.Visible = true;
            if (R8 != "in") lblCerto8.Visible = false; lblErrado8.Visible = true;
        }

        private void lblErrado8_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado7_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado6_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado5_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto4_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto1_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado4_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado3_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado2_Click(object sender, EventArgs e)
        {

        }

        private void lblErrado1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label297_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto7_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto6_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto5_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto8_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEx22_Load(object sender, EventArgs e)
        {

        }
    }
}
