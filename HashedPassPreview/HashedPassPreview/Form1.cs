using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashedPassPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            txtSaltBytes.Text = salt.ToString();
            txtSaltString.Text = Convert.ToBase64String(salt);

            string pwd = txtPwd.Text;
            int iterations = (int)nudIterations.Value;

            var pbkdf2 = new Rfc2898DeriveBytes(pwd, salt, iterations);

            byte[] hash = pbkdf2.GetBytes(20);

            txtHashedPasswordBytes.Text = hash.ToString();
            txtHashedPasswordString.Text = Convert.ToBase64String(hash);

            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            txtResultBytes.Text = hashBytes.ToString();
            txtResultString.Text = Convert.ToBase64String(hashBytes);
        }
    }
}