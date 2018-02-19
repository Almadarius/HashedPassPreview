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
    public partial class frmPBKDF2 : Form
    {
        public frmPBKDF2()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            txtSaltBytes.Text = BytesToString(salt);
            txtSaltString.Text = Convert.ToBase64String(salt);

            string pwd = txtPwd.Text;
            int iterations = (int)nudIterations.Value;

            var pbkdf2 = new Rfc2898DeriveBytes(pwd, salt, iterations);

            byte[] hash = pbkdf2.GetBytes(20);

            txtHashedPasswordBytes.Text = BytesToString(hash);
            txtHashedPasswordString.Text = Convert.ToBase64String(hash);

            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            txtResultBytes.Text = BytesToString(hashBytes);
            txtResultString.Text = Convert.ToBase64String(hashBytes);
        }

        private string BytesToString(byte[] bytes)
        {
            string result = string.Empty;

            for (int i = 0; i < bytes.Length; i++)
            {
                result += "[" + bytes[i].ToString() + "]";
            }

            return result;
        }
    }
}