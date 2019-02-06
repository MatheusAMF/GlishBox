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
using System.Speech.AudioFormat;
using System.Speech.Recognition;

namespace GlishBox
{
    public partial class frmEx1 : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        public frmEx1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4;
            r1 = Convert.ToString(txtr1.Text);
            r2 = Convert.ToString(txtr2.Text);
            r3 = Convert.ToString(txtr3.Text);
            r4 = Convert.ToString(txr4.Text);

            string R1 = r1.ToUpper();
            string R2 = r2.ToUpper();
            string R3 = r3.ToUpper();
            string R4 = r4.ToUpper();

            if (R1 == "T" && R2 == "C" && R3 == "U" && R4 == "Y")
            {
                label3.Visible = true;
            }
            if (R1 == "T") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "C") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "U") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "Y") lblErrado4.Visible = false; lblCerto4.Visible = true;

            if (R1 != "T") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "C") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "U") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "Y") lblCerto4.Visible = false; lblErrado4.Visible = true;
        }

        private void lblexa_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("tea");
        }

        private void lblexb_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("see");
        }

        private void lblexc_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("you");
        }

        private void lblexd_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync("why");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
            this.Close();
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {

        }
    }
}
