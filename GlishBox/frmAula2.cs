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
using System.Globalization;

namespace GlishBox
{
    public partial class frmAula2 : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        public frmAula2()
        {
            InitializeComponent();
        }

        private void label254_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmBasic objbasic = new frmBasic();
            objbasic.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synth.Rate = -4;
            synth.SpeakAsync("1  2  3  4  5  6  7  8  9  10  11  12  13  14  15  16  17  18  19");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synth.Rate = -4;
            synth.SpeakAsync("20  30  40  50  60  70  80  90");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synth.Rate = -4;
            synth.SpeakAsync("100  200  300  400  1000  2000  3000  4000");
        }
    }
}
