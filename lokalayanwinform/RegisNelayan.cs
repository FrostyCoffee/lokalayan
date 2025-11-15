using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lokalayanwinform.DatabaseHelper;

namespace lokalayanwinform
{
    public partial class RegisNelayan : Form
    {
        private int idPengguna;
        public RegisNelayan(int idPengguna)
        {
            InitializeComponent();
            this.idPengguna = idPengguna;
        }
        private void txtBoxLokasiNelayan_TextChanged(object sender, EventArgs e)
        {
            string lokasi = txtBoxLokasiNelayan.Text.Trim();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lokasi = txtBoxLokasiNelayan.Text.Trim();
            if (string.IsNullOrEmpty(lokasi))
            {
                MessageBox.Show("Tolong isi lokasi dengan lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.RegisterNelayan(idPengguna, lokasi);
                MessageBox.Show("Registrasi Nelayan berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardPenjual dashboardPenjual = new DashboardPenjual();
                dashboardPenjual.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat registrasi Nelayan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
