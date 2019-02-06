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
    public partial class frmAula1 : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        public frmAula1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAula1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_S_Click(object sender, EventArgs e)
        {

        }

        private void lbl_T_Click(object sender, EventArgs e)
        {

        }

        private void lbl_U_Click(object sender, EventArgs e)
        {

        }

        private void lbl_V_Click(object sender, EventArgs e)
        {

        }

        private void lbl_X_Click(object sender, EventArgs e)
        {

        }

        private void lbl_W_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Y_Click(object sender, EventArgs e)
        {

        }

        private void lbl_J_Click(object sender, EventArgs e)
        {

        }

        private void lbl_K_Click(object sender, EventArgs e)
        {

        }

        private void lbl_L_Click(object sender, EventArgs e)
        {

        }

        private void lbl_M_Click(object sender, EventArgs e)
        {

        }

        private void lbl_N_Click(object sender, EventArgs e)
        {

        }

        private void lbl_O_Click(object sender, EventArgs e)
        {

        }

        private void lbl_P_Click(object sender, EventArgs e)
        {

        }

        private void lbl_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Q_Click(object sender, EventArgs e)
        {

        }

        private void lbl_A_Click(object sender, EventArgs e)
        {

        }

        private void lbl_b_Click(object sender, EventArgs e)
        {

        }

        private void lbl_c_Click(object sender, EventArgs e)
        {

        }

        private void lbl_D_Click(object sender, EventArgs e)
        {

        }

        private void lbl_E_Click(object sender, EventArgs e)
        {

        }

        private void lbl_F_Click(object sender, EventArgs e)
        {

        }

        private void lbl_G_Click(object sender, EventArgs e)
        {

        }

        private void lbl_H_Click(object sender, EventArgs e)
        {

        }

        private void lbl_I_Click(object sender, EventArgs e)
        {

        }

        private void lbl_abc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBasic objbasic = new frmBasic();
            objbasic.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
            // synth.SelectVoiceByHints(VoiceGender.Male);
            synth.SpeakAsync("Pode parecer coisa de criança, mas o alfabeto é muito importante tanto em português como em inglês. "
                            + "Por exemplo, em uma ligação telefônica, em que você deve soletrar alguma"
                            + " palavra, se a outra pessoa não entende a letra soletrada, então relacionamos à "
                             + " outra palavra, como A de abelha, B de bola, C de cenoura, etc."
                              + " Em inglês usa - se “as in” que é uma expressão, “A” as in apple, “B” as in bee, etc.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            synth.Rate = -4;
            synth.SpeakAsync("A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z");
        }

        private void lbl_A_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.apple1;
        }
        private void lbl_b_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_b_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.ball;
        }

        private void lbl_c_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.car;
        }

        private void lbl_D_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.dice;
        }

        private void lbl_E_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lbl_E_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.egg;
        }

        private void lbl_F_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.frog;
        }

        private void lbl_G_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.girl;
        }

        private void lbl_H_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.horse;
        }

        private void lbl_I_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.icecream;
        }

        private void lbl_J_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.jelly;
        }

        private void lbl_K_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.knife;
        }

        private void lbl_L_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.leaf;
        }

        private void lbl_M_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.moon;
        }

        private void lbl_N_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.nose;
        }

        private void lbl_O_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.orange;
        }

        private void lbl_P_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.princess;
        }

        private void lbl_Q_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.queen;
        }

        private void lbl_R_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.rat;
        }

        private void lbl_S_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.sun;
        }

        private void lbl_T_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.tower;
        }

        private void lbl_U_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.umbrella;
        }

        private void lbl_V_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.vampire;
        }

        private void lbl_W_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.wand;
        }

        private void lbl_X_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.xray;
        }
        private void lbl_Y_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.yoyo;
        }

        private void lbl_Z_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.zebra;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAula1c objaula1 = new frmAula1c();
            objaula1.ShowDialog();
            this.Close();
        }
    }
}
