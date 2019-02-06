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
    public partial class frmEx4 : Form
    {
        public RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }
            return null;
        }
        public frmEx4()
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

        private void frmEx4_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblCerto3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbldica1.Visible = true;
            lbldica2.Visible = true;
            lbldica3.Visible = true;
            lbldica4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBasicEx objbasicex = new frmBasicEx();
            objbasicex.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GetCheckedRadio(groupBox1) == rbCerto1 && GetCheckedRadio(groupBox2) == rbCerto2 && GetCheckedRadio(groupBox3) == rbCerto3 && GetCheckedRadio(groupBox4) == rbCerto4)
            {
                label3.Visible = true;
            }
            if (GetCheckedRadio(groupBox1) == rbCerto1) lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (GetCheckedRadio(groupBox2) == rbCerto2) lblErrado2.Visible = false; lblCerto2.Visible = true;
            if (GetCheckedRadio(groupBox3) == rbCerto3) lblErrado3.Visible = false; lblCerto3.Visible = true;
            if (GetCheckedRadio(groupBox4) == rbCerto4) lblErrado4.Visible = false; lblCerto4.Visible = true;

            if (GetCheckedRadio(groupBox1) != rbCerto1) lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (GetCheckedRadio(groupBox2) != rbCerto2) lblCerto2.Visible = false; lblErrado2.Visible = true;
            if (GetCheckedRadio(groupBox3) != rbCerto3) lblCerto3.Visible = false; lblErrado3.Visible = true;
            if (GetCheckedRadio(groupBox4) != rbCerto4) lblCerto4.Visible = false; lblErrado4.Visible = true;
        }

        private void rbCerto1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
