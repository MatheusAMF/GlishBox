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
    public partial class frmEx2 : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        public frmEx2()
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

        private void label280_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label200.Visible = true;
            label280.Visible = true;
            label281. Visible = true;
            label1.ForeColor = Color.Gray; 
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
            label7.ForeColor = Color.Gray;
            label8.ForeColor = Color.Gray; 
        }

        private void frmEx2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("5");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("22");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("45");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("68");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("99");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("102");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("525");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("1002");
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

            if (R1 == "five" && R2 == "twenty two" && R3 == "forty five" && R4 == "sixty eight" && R5 == "ninety nine" && R6 == "one hundred and two" && R7 == "five hundred and twenty five" && R8 == "one thousand and two")
            {
                label19.Visible = true;
            }
            if (R1 == "five")                           lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "twenty two")                     lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "forty five")                     lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "sixty eight")                    lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "ninety nine")                    lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (R6 == "one hundred and two")            lblErrado6.Visible = false; lblCerto6.Visible = true;
            if (R7 == "five hundred and twenty five")   lblErrado7.Visible = false; lblCerto7.Visible = true;
            if (R8 == "one thousand and two")           lblErrado8.Visible = false; lblCerto8.Visible = true;

            if (R1 != "five")                           lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "twenty two")                     lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "forty five")                     lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "sixty eight")                    lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "ninety nine")                    lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (R6 != "one hundred and two")            lblCerto6.Visible = false; lblErrado6.Visible = true;
            if (R7 != "five hundred and twenty five")   lblCerto7.Visible = false; lblErrado7.Visible = true;
            if (R8 != "one thousand and two")           lblCerto8.Visible = false; lblErrado8.Visible = true;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrado1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
