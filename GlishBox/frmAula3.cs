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
    public partial class frmAula3 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula3()
        {
            InitializeComponent();
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
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
            Timer t = new Timer();
            t.Interval = 16000; // specify interval time as you want
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("Saber o verbo bi é algo muito importante, pois é utlizado constantemente na língua inglesa. São três verbos que são utilizados dependendo do sujeito da frase. Esses verbos são:");
            synthen.Rate = -5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            synthen.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synthen.Rate = -3;
            synthen.SpeakAsync("AM");
            synthen.SpeakAsync("IS");
            synthen.SpeakAsync("ARE");
            timer1.Stop();
        }
    }
}
