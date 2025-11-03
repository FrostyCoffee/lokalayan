using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lokalayanwinform
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabelRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tolong isi email dan password dengan lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                var pengguna = dbHelper.GetPenggunaByEmail(email);
                if (pengguna == null || pengguna.Password != password)
                {
                    MessageBox.Show("Email atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool isNelayan = dbHelper.IsUserNelayan(pengguna.IdPengguna);
                if (isNelayan)
                {
                    DashboardPenjual dashboardPenjual = new DashboardPenjual();
                    dashboardPenjual.Show();
                }
                else
                {
                    Katalog dashboardPembeli = new Katalog();
                    dashboardPembeli.Show();
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
