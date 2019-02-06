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
    public partial class frmAula35 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAula35c objaula35c = new frmAula35c();
            objaula35c.ShowDialog();
            this.Close();
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
            synthbr.SpeakAsync("As orações condicionais (if clauses) expressam a dependência entre uma circunstância ou condição e um fato ou resultado. Estas circunstâncias e fatos podem ser presentes, passados ou futuros. Lembre-se de que estamos trabalhando com períodos compostos, constituídos por uma oração principal (main clause) e uma oração dependente, no caso, oração subordinada condicional (conditional clause). Uma frase condicional é formada por duas orações: a oração condicional(que exprime a condição), introduzida por if ou when; e a oração principal, que menciona a consequência.");
            synthen.Rate = -5;
        }
    }
}
