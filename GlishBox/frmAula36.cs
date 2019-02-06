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
    public partial class frmAula36 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula36()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAvanc objavanc = new frmAvanc();
            objavanc.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAula36c objaula36c = new frmAula36c();
            objaula36c.ShowDialog();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("Este tempo verbal indica uma relação entre o tempo passado e o presente, é utilizadopara descrever ações que ocorreram no passado e afetam o presente, ações que vêm acontecendo, ações que acabaram de acontecer ou ações passadas sem terem um tempo determinado. Utiliza-se o presente perfeito para descrever ações que iniciaram no passado e se estendem até o presente. E Utiliza-se para descrever ações que vêm ocorrendo recentemente.");
            synthen.Rate = -5;
        }
    }
}
