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
    public partial class Pemesanan : Form
    {
        private int idProduk, jumlahBeli, hargaProduk, totalHarga, idPembeli;
        public Pemesanan()
        {
            InitializeComponent();
        }
        public void ReceiveOrderDetails(int idProduk, int jumlahBeli, int hargaProduk, int totalHarga, int idPembeli)
        {
            this.idProduk = idProduk;
            this.jumlahBeli = jumlahBeli;
            this.hargaProduk = hargaProduk;
            this.totalHarga = totalHarga;
            this.idPembeli = idPembeli;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            string metodePembayaran = cbTransfer.Checked ? "Transfer" : "QRIS";
            string metodePengiriman = rdbPos.Checked ? "Pos Indonesia" : "JNE";
            string statusPembayaran = "diterima";
            string statusPesanan = "diproses";
            DatabaseHelper db = new DatabaseHelper();

            int idPesanan = db.InsertPesanan(idProduk, idPembeli, totalHarga, statusPesanan);
            db.InsertDetailPesanan(idPesanan, idProduk, hargaProduk, jumlahBeli);
            db.InsertPembayaran(idPesanan, metodePembayaran, statusPembayaran);
            db.InsertPengiriman(idPesanan, metodePengiriman);

            MessageBox.Show("Pesanan berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
