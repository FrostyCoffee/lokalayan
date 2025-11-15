using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lokalayanwinform
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtBoxNama.Text.Trim();
            string email = txtBoxEmail.Text.Trim();
            string password = txtBoxPass.Text.Trim();
            bool isSeller = btnRadioPenjual.Checked;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tolong isi seluruh form dengan lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                int idPengguna = dbHelper.RegisterUser(name, password, email);

                if (isSeller)
                {
                    RegisNelayan regisNelayan = new RegisNelayan(idPengguna);
                    regisNelayan.Show();
                }
                else
                {
                    RegisPembeli regisPembeli = new RegisPembeli(idPengguna);
                    regisPembeli.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat registrasi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void labelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnRadioPenjual_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
