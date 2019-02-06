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
    public partial class frmAula11 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula11()
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
            frmBasic objbasic = new frmBasic();
            objbasic.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("Para formar uma oração interrogativa no Simple Present, usa-se o verbo auxiliar Do ANTES DO SUJEITO para os Pronomes Pessoais e does para a 3ª pessoa do singular");
            synthen.Rate = -5;
        }
    }
}
