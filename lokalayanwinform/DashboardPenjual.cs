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
    public partial class DashboardPenjual : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private void LoadCounters()
        {
            try
            {
                if (Session.idNelayan == null)
                {
                    MessageBox.Show("Anda tidak memiliki akses ke dashboard penjual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idNelayan = Session.idNelayan.Value;
                int totalPesanan = dbHelper.GetTotalPesanan(idNelayan);
                int totalStok = dbHelper.GetTotalStok(idNelayan);
                int jumlahProduk = dbHelper.GetJumlahProduk(idNelayan);
                counterTotalPesanan.Text = totalPesanan.ToString();
                counterTotalStok.Text = totalStok.ToString();
                counterJumlahProduk.Text = jumlahProduk.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DashboardPenjual()
        {
            InitializeComponent();
            LoadCounters();
        }

        private void btnCekStok_Click(object sender, EventArgs e)
        {
            PemesananPenjual pemesananPenjual = new PemesananPenjual();
            pemesananPenjual.Show();
            this.Hide();

        }

        private void btnEditProduk_Click(object sender, EventArgs e)
        {
            EditProduk editProduk = new EditProduk();
            editProduk.Show();
            this.Hide();
        }
    }
}
