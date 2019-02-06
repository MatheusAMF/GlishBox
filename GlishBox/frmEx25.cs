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
    public partial class frmEx25 : Form
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
        public frmEx25()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAvancEx objavancex = new frmAvancEx();
            objavancex.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmEx252 objex252 = new frmEx252();
            objex252.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GetCheckedRadio(groupBox1) == rbCerto1 && GetCheckedRadio(groupBox2) == rbCerto2)
            {
                label10.Visible = true;
            }
            if (GetCheckedRadio(groupBox1) == rbCerto1) lblErrado1.Visible = false; lblCerto1.Visible = true;
            if (GetCheckedRadio(groupBox2) == rbCerto2) lblErrado2.Visible = false; lblCerto2.Visible = true;

            if (GetCheckedRadio(groupBox1) != rbCerto1) lblCerto1.Visible = false; lblErrado1.Visible = true;
            if (GetCheckedRadio(groupBox2) != rbCerto2) lblCerto2.Visible = false; lblErrado2.Visible = true;
        }
    }
}
