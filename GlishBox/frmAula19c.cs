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
    public partial class frmAula19c : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula19c()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAula19 objaula19 = new frmAula19();
            objaula19.ShowDialog();
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
            synthbr.SpeakAsync("Nós podemos usar o make para falar sobre a construção, criação ou execução de alguma coisa.");
            synthen.Rate = -5;
        }
    }
}
