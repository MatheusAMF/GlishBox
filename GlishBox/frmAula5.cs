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
    public partial class frmAula5 : Form
    {
        public SpeechSynthesizer synthen = new SpeechSynthesizer();
        public SpeechSynthesizer synthbr = new SpeechSynthesizer();
        public frmAula5()
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

        private void frmAula5_Load(object sender, EventArgs e)
        {

        }

        private void label190_Click(object sender, EventArgs e)
        {

        }

        private void label192_Click(object sender, EventArgs e)
        {

        }

        private void label194_Click(object sender, EventArgs e)
        {

        }

        private void label196_Click(object sender, EventArgs e)
        {

        }

        private void label198_Click(object sender, EventArgs e)
        {

        }

        private void label200_Click(object sender, EventArgs e)
        {

        }

        private void label202_Click(object sender, EventArgs e)
        {

        }

        private void label204_Click(object sender, EventArgs e)
        {

        }

        private void label206_Click(object sender, EventArgs e)
        {

        }

        private void label208_Click(object sender, EventArgs e)
        {

        }

        private void label210_Click(object sender, EventArgs e)
        {

        }

        private void label212_Click(object sender, EventArgs e)
        {

        }

        private void label214_Click(object sender, EventArgs e)
        {

        }

        private void label216_Click(object sender, EventArgs e)
        {

        }

        private void label218_Click(object sender, EventArgs e)
        {

        }

        private void label220_Click(object sender, EventArgs e)
        {

        }

        private void label222_Click(object sender, EventArgs e)
        {

        }

        private void label223_Click(object sender, EventArgs e)
        {

        }

        private void label224_Click(object sender, EventArgs e)
        {

        }

        private void label225_Click(object sender, EventArgs e)
        {

        }

        private void label226_Click(object sender, EventArgs e)
        {

        }

        private void label227_Click(object sender, EventArgs e)
        {

        }

        private void label228_Click(object sender, EventArgs e)
        {

        }

        private void label188_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            synthbr.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            synthbr.SpeakAsync("O A e o AN são artigos indefinidos, A e AN tem o mesmo significado, eles significam um/uma, a diferença é que o A é usado antes de consoante e o AN é usando antes de vogal. Mas existe outra regra para o uso do A e do AN, se o som da primeira palavra for diferente do que ela é, por exemplo se começar com a letra H mas tiver som de vogal então utiliza-se AN e a mesma acontece quando a vogal tem som de consoante.");
            synthen.Rate = -5;
        }
    }
}
