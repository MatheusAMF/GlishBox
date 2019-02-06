using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlishBox
{
    public partial class frmEx35 : Form
    {
        public frmEx35()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAvancEx objAvancex = new frmAvancEx();
            objAvancex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4, r5, r6, r7, r8;
            r1 = Convert.ToString(textBox1.Text); r5 = Convert.ToString(textBox5.Text);
            r2 = Convert.ToString(textBox2.Text); r6 = Convert.ToString(textBox6.Text);
            r3 = Convert.ToString(textBox3.Text); r7 = Convert.ToString(textBox7.Text);
            r4 = Convert.ToString(textBox4.Text); r8 = Convert.ToString(textBox8.Text);

            string R1 = r1.ToLower(); string R5 = r5.ToLower();
            string R2 = r2.ToLower(); string R6 = r6.ToLower();
            string R3 = r3.ToLower(); string R7 = r7.ToLower();
            string R4 = r4.ToLower(); string R8 = r8.ToLower();

            if (R1 == "rains" && R2 == "had" && R3 == "were" && R4 == "helped" && R5 == "will need" && R6 == "would play" && R7 == "would choose" && R8 == "would wear")
            {
                label10.Visible = true;
            }
            if (R1 == "rains") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "had") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "were") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "helped") lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "will need") lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (R6 == "would play") lblErrado6.Visible = false; lblCerto6.Visible = true;
            if (R7 == "would choose") lblErrado7.Visible = false; lblCerto7.Visible = true;
            if (R8 == "would wear") lblErrado8.Visible = false; lblCerto8.Visible = true;

            if (R1 != "rains") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "had") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "were") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "helped") lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "will need") lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (R6 != "would play") lblCerto6.Visible = false; lblErrado6.Visible = true;
            if (R7 != "would choose") lblCerto7.Visible = false; lblErrado7.Visible = true;
            if (R8 != "would wear") lblCerto8.Visible = false; lblErrado8.Visible = true;
        }
    }
}
