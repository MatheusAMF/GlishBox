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
    public partial class frmAula4 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        Timer t = new Timer();
        public frmAula4()
        {
            InitializeComponent();
        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
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
            t.Interval = 13000; // specify interval time as you want
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("A maneira mais facil de aprender é perguntando, por isso  é essencial saber como fazer perguntas. As principais palavras para fazer perguntas são:");
            synthen.Rate = -5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            synthen.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synthen.Rate = -2;
            synthen.SpeakAsync("what");
            synthen.SpeakAsync("who");
            synthen.SpeakAsync("witch");
            synthen.SpeakAsync("how");
            synthen.SpeakAsync("when");
            synthen.SpeakAsync("where");
            t.Stop();
        }
    }
}
