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
    public partial class frmEx24 : Form
    {
        public frmEx24()
        {
            InitializeComponent();
        }

        private void frmEx24_Load(object sender, EventArgs e)
        {

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
            frmInterEx objInterex = new frmInterEx();
            objInterex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r1, r2, r3, r4, r5;
            r1 = Convert.ToString(textBox1.Text); r3 = Convert.ToString(textBox3.Text);
            r2 = Convert.ToString(textBox2.Text); r4 = Convert.ToString(textBox4.Text);
            r5 = Convert.ToString(textBox5.Text);

            string R1 = r1.ToLower(); string R5 = r5.ToLower();
            string R2 = r2.ToLower(); 
            string R3 = r3.ToLower(); 
            string R4 = r4.ToLower(); 

            if (R1 == "often" && R2 == "always" && R3 == "never" && R4 == "usually" && R5 == "quase nunca")
            {
                label10.Visible = true;
            }
            if (R1 == "often") lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (R2 == "always") lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (R3 == "never") lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (R4 == "usually") lblErrado4.Visible = false; lblCerto4.Visible = true;
            if (R5 == "quase nunca") lblErrado5.Visible = false; lblCerto5.Visible = true;

            if (R1 != "often") lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (R2 != "always") lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (R3 != "never") lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (R4 != "usually") lblCerto4.Visible = false; lblErrado4.Visible = true;
            if (R5 != "quase nunca") lblCerto5.Visible = false; lblErrado5.Visible = true;
        }
    }
}
