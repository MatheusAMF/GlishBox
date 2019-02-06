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
    public partial class frmAula1c : Form
    {
        public frmAula1c()
        {
            InitializeComponent();
        }

        private void frmAula1c_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Matheus1\Downloads\GlishBoxTESTES\GlishBox\GlishBox\Videos\Aula1.mp4";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
