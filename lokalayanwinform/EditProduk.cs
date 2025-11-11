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
    public partial class EditProduk : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public EditProduk()
        {
            InitializeComponent();
            LoadProduk();
        }
        private void LoadProduk()
        {
            var idNelayan = Session.idNelayan;

            try
            {
                DataTable produkData = dbHelper.GetAllProduk((int)idNelayan);
                dtgrProduk.DataSource = produkData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusProduk_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            string kategori = textBoxKategori.Text.Trim();
            string jenis = textBoxJenis.Text.Trim();
            string grade = textBoxGrade.Text.Trim();
            int harga = int.Parse(textBoxHarga.Text.Trim());
            int stok = int.Parse(textBoxStok.Text.Trim());
            int tanggalTangkap = int.Parse(textBoxTanggal.Text.Trim());

            if (string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(jenis) || string.IsNullOrEmpty(grade) ||
                harga <= 0 || stok < 0 || tanggalTangkap <= 0)
            {
                MessageBox.Show("Tolong isi semua field dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                dbHelper.AddProduk(kategori, jenis, grade, harga, stok, tanggalTangkap);
                MessageBox.Show("Produk berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
