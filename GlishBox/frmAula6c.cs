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
    public partial class frmAula6c : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        Timer t = new Timer();
        public frmAula6c()
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
            frmAula6 objaula6 = new frmAula6();
            objaula6.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            t.Interval = 9000; // specify interval time as you want
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("Os pronomes possessivos tem a função de substituir um substantivo como podemos ver no exemplo abaixo:");
            synthen.Rate = -5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            synthen.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synthen.Rate = -2;
            synthen.SpeakAsync("mine");
            synthen.SpeakAsync("yours");
            synthen.SpeakAsync("his");
            synthen.SpeakAsync("hers");
            synthen.SpeakAsync("its");
            synthen.SpeakAsync("ours");
            synthen.SpeakAsync("yours");
            synthen.SpeakAsync("theirs");
            t.Stop();
        }
    }
}
