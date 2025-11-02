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
    public partial class RegisPembeli : Form
    {
        public RegisPembeli()
        {
            InitializeComponent();
        }

        private void txtBoxAlamatPembeli_TextChanged(object sender, EventArgs e)
        {
            string alamat = txtBoxAlamatPembeli.Text.Trim();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string alamat = txtBoxAlamatPembeli.Text.Trim();
            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Tolong isi alamat dengan lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                Pembeli pembeli = new Pembeli
                {
                    Alamat = alamat
                };
                dbHelper.RegisterPembeli(pembeli);
                MessageBox.Show("Registrasi Pembeli berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Katalog dashboardPembeli = new Katalog();
                dashboardPembeli.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat registrasi Pembeli: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
