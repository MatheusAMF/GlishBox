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
    public partial class frmEx12 : Form
    {
        public frmEx12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4, r5, r6;
            r1 = Convert.ToString(textBox1.Text); r5 = Convert.ToString(textBox5.Text);
            r2 = Convert.ToString(textBox2.Text); r6 = Convert.ToString(textBox6.Text);
            r3 = Convert.ToString(textBox3.Text);
            r4 = Convert.ToString(textBox4.Text);

            string R1 = r1.ToLower(); string R5 = r5.ToLower();
            string R2 = r2.ToLower(); string R6 = r6.ToLower();
            string R3 = r3.ToLower();
            string R4 = r4.ToLower();

            if (R1 == "i don't have good friends" && R2 == "you don't live in los angeles" && R3 == "she doesn't like her job" && R4 == "it doesn't rain in summer" && R5 == "we don't believe you" && R6 == "they don't know english")
            {
                label2.Visible = true;
            }
            if (R1 == "i don't have good friends") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "you don't live in los angeles") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "she doesn't like her job") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "it doesn't rain in summer") lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "we don't believe you") lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (R6 == "they don't know english") lblErrado6.Visible = false; lblCerto6.Visible = true;

            if (R1 != "i don't have good friends") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "you don't live in los angeles") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "she doesn't like her job") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "it doesn't rain in summer") lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "we don't believe you") lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (R6 != "they don't know english") lblCerto6.Visible = false; lblErrado6.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
