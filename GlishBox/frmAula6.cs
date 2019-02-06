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
    public partial class frmAula6 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        Timer t = new Timer();
        public frmAula6()
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmAula6c objaula6c = new frmAula6c();
            objaula6c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBasic objbasic = new frmBasic();
            objbasic.ShowDialog();
            this.Close();
        }

        private void frmAula6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            t.Interval = 13000; // specify interval time as you want
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("Os pronomes de posseção e os adjetivos de posseção são utilizados para mostrar que alguma coisa pertence a alguém. Esses são os adjetivos:");
            synthen.Rate = -5;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            synthen.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synthen.Rate = -2;
            synthen.SpeakAsync("my");
            synthen.SpeakAsync("your");
            synthen.SpeakAsync("his");
            synthen.SpeakAsync("her");
            synthen.SpeakAsync("it");
            synthen.SpeakAsync("our");
            synthen.SpeakAsync("your");
            synthen.SpeakAsync("their");
            t.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
