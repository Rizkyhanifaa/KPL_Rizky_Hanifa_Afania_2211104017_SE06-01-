using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul15_2211104017
{
    public partial class FormRegister: Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!AuthHelper.IsValidInput(username, password, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashed = AuthHelper.HashPassword(password);
            AuthHelper.SaveUser(new User { Username = username, PasswordHash = hashed });

            MessageBox.Show("Registrasi berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
