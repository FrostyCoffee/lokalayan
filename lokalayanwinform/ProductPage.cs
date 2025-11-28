using Npgsql;
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
    public partial class ProductPage : Form
    {
        private int idProduk;
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private int currentStock;
        public ProductPage(int idProduk)
        {
            InitializeComponent();
            this.idProduk = idProduk;
            LoadProductDetails();
        }

        private void titleProduk_Click(object sender, EventArgs e)
        {

        }
        private void LoadProductDetails()
        {
            try
            {
                DataRow product = dbHelper.GetProductById(idProduk);
                titleKategori.Text = product["kategori"].ToString();
                titleJenis.Text = product["jenis"].ToString();
                fillGrade.Text = product["grade"].ToString();
                lblHargaProduk.Text = "Rp " + product["harga"].ToString();
                counterStokProduk.Text = product["stok"].ToString();

                currentStock = Convert.ToInt32(product["stok"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat detail produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBeliProduk_Click(object sender, EventArgs e)
        {
            try
            {
                int jumlahBeli = Convert.ToInt32(textBoxJumlahBeli.Text);
                if (jumlahBeli <= 0)
                {
                    MessageBox.Show("Jumlah pembelian harus lebih dari 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (jumlahBeli > currentStock)
                {
                    MessageBox.Show("Stok tidak mencukupi untuk jumlah pembelian yang diminta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int hargaProduk = Convert.ToInt32(lblHargaProduk.Text.Replace("Rp ", "").Replace(".", ""));
                int totalHarga = CalculateTotalPrice(hargaProduk, jumlahBeli);

                int idPembeli = Session.idPembeli ?? 0;
                if (idPembeli == 0)
                {
                    MessageBox.Show("ID Pembeli tidak valid. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentStock -= jumlahBeli;
                counterStokProduk.Text = currentStock.ToString();
                dbHelper.UpdateStockInDatabase(currentStock, idProduk);
                MessageBox.Show("Pembelian berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pass order details to Pemesanan form
                Pemesanan pemesananForm = new Pemesanan();
                pemesananForm.ReceiveOrderDetails(idProduk, jumlahBeli, hargaProduk, totalHarga, idPembeli);
                pemesananForm.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Tolong masukkan jumlah pembelian yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses pembelian: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalculateTotalPrice(int hargaProduk, int jumlahBeli)
        {
            return hargaProduk * jumlahBeli;
        }

        private void PostOrderDetails(int idProduk, int jumlahBeli, int hargaProduk, int totalHarga, int idPembeli)
        {
            try
            {
                Pemesanan pemesananForm = new Pemesanan();
                pemesananForm.ReceiveOrderDetails(idProduk, jumlahBeli, hargaProduk, totalHarga, idPembeli);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengirim detail pesanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RedirectToPemesanan()
        {
            Pemesanan pemesananForm = new Pemesanan();
            pemesananForm.Show();
            this.Close();
        }

        private void lblHargaProduk_Click(object sender, EventArgs e)
        {

        }

        private void btnKembaliProduk_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog();
            katalog.Show();
            this.Close();
        }
    }
}
