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
    public partial class frmEx9 : Form
    {
        public frmEx9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4, r5, r6, r7, r8, r9, r10;
            r1 = Convert.ToString(textBox1.Text); r5 = Convert.ToString(textBox5.Text); r9 = Convert.ToString(textBox9.Text); r10 = Convert.ToString(textBox10.Text);
            r2 = Convert.ToString(textBox2.Text); r6 = Convert.ToString(textBox6.Text);
            r3 = Convert.ToString(textBox3.Text); r7 = Convert.ToString(textBox7.Text);
            r4 = Convert.ToString(textBox4.Text); r8 = Convert.ToString(textBox8.Text);

            string R1 = r1.ToLower(); string R5 = r5.ToLower(); string R9 = r9.ToLower(); string R10 = r10.ToLower();
            string R2 = r2.ToLower(); string R6 = r6.ToLower();
            string R3 = r3.ToLower(); string R7 = r7.ToLower();
            string R4 = r4.ToLower(); string R8 = r8.ToLower();

            if (R1 == "computers" && R2 == "boxes" && R3 == "crises" && R4 == "notebooks" && R5 == "keys" && R6 == "parties" && R7 == "flowers" && R8 == "tables" && R9 == "students" && R10 == "teachers")
            {
                label19.Visible = true;
            }
            if (R1 == "computers") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "boxes") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "crises") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "notebooks") lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "keys") lblErrado5.Visible = false; lblCerto5.Visible = true;
            if (R6 == "parties") lblErrado6.Visible = false; lblCerto6.Visible = true;
            if (R7 == "flowers") lblErrado7.Visible = false; lblCerto7.Visible = true;
            if (R8 == "tables") lblErrado8.Visible = false; lblCerto8.Visible = true;
            if (R9 == "students") lblErrado9.Visible = false; lblCerto9.Visible = true;
            if (R10 == "teachers") lblErrado10.Visible = false; lblCerto10.Visible = true;

            if (R1 != "computers") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "boxes") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "crises") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "notebooks") lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "keys") lblCerto5.Visible = false; lblErrado5.Visible = true;
            if (R6 != "parties") lblCerto6.Visible = false; lblErrado6.Visible = true;
            if (R7 != "flowers") lblCerto7.Visible = false; lblErrado7.Visible = true;
            if (R8 != "tables") lblCerto8.Visible = false; lblErrado8.Visible = true;
            if (R9 != "students") lblCerto9.Visible = false; lblErrado9.Visible = true;
            if (R10 != "teachers") lblCerto10.Visible = false; lblErrado10.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label280.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
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
    }
}
