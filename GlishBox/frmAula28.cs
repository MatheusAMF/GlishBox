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
    public partial class frmAula28 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula28()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAvanc objavanc = new frmAvanc();
            objavanc.ShowDialog();
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
            synthbr.SpeakAsync("Os pronomes reflexivos podem ser usados para expressar: Ação reflexiva: a ação do verbo recai sobre o próprio sujeito. Função enfática: o pronome deve combinar com aquilo que está se enfatizando. Função idiomática: intenção de informar que o sujeito praticou a ação sozinho.");
            synthen.Rate = -5;
        }
    }
}
