using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashedPassPreview
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPBKDF2_Click(object sender, EventArgs e)
        {
            frmPBKDF2 pbkdf2 = new frmPBKDF2();
            pbkdf2.Show();
        }
    }
}
