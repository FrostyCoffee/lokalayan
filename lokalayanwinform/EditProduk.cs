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
            if (dtgrProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tolong pilih produk yang ingin dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idProduk = Convert.ToInt32(dtgrProduk.SelectedRows[0].Cells["idProduk"].Value);
            try
            {
                dbHelper.DeleteProduk(idProduk);
                MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            string kategori = textBoxKategori.Text.Trim();
            string jenis = textBoxJenis.Text.Trim();
            string grade = textBoxGrade.Text.Trim();
            int harga = int.Parse(textBoxHarga.Text.Trim());
            int stok = int.Parse(textBoxStok.Text.Trim());

            if (string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(jenis) || string.IsNullOrEmpty(grade) ||
                harga <= 0 || stok < 0)
            {
                MessageBox.Show("Tolong isi semua field dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                dbHelper.AddProduk((int)Session.idNelayan, kategori, jenis, grade, harga, stok);
                MessageBox.Show("Produk berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgrProduk_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrProduk.SelectedRows.Count > 0)
            {
                var selectedRow = dtgrProduk.SelectedRows[0];
                textBoxKategori.Text = selectedRow.Cells["kategori"].Value.ToString();
                textBoxJenis.Text = selectedRow.Cells["jenis"].Value.ToString();
                textBoxGrade.Text = selectedRow.Cells["grade"].Value.ToString();
                textBoxHarga.Text = selectedRow.Cells["harga"].Value.ToString();
                textBoxStok.Text = selectedRow.Cells["stok"].Value.ToString();
            }
        }

        private void btnPerbarahuiProduk_Click(object sender, EventArgs e)
        {
            if (dtgrProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tolong pilih produk yang ingin diperbarui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idProduk = Convert.ToInt32(dtgrProduk.SelectedRows[0].Cells["idProduk"].Value);
            string kategori = textBoxKategori.Text.Trim();
            string jenis = textBoxJenis.Text.Trim();
            string grade = textBoxGrade.Text.Trim();
            int harga = int.Parse(textBoxHarga.Text.Trim());
            int stok = int.Parse(textBoxStok.Text.Trim());

            if (string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(jenis) || string.IsNullOrEmpty(grade) ||
                harga <= 0 || stok < 0)
            {
                MessageBox.Show("Tolong isi semua field dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbHelper.UpdateProduk(idProduk, kategori, jenis, grade, harga, stok);
                MessageBox.Show("Produk berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ada error saat memperbaharui produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
