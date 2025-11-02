using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokalayanwinform
{
    public class Pesanan
    {
        // Private fields
        private int idPesanan;
        private int idProduk;
        private int idPembeli;
        private string status;
        private decimal totalHarga;

        // Properties
        public int IdPesanan
        {
            get { return idPesanan; }
            set { idPesanan = value; }
        }

        public int IdProduk
        {
            get { return idProduk; }
            set { idProduk = value; }
        }

        public int IdPembeli
        {
            get { return idPembeli; }
            set { idPembeli = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public decimal TotalHarga
        {
            get { return totalHarga; }
            set { totalHarga = value; }
        }

        // Constructor
        public Pesanan()
        {
            this.status = "Pending";
        }

        public Pesanan(int idPesanan, int idProduk, int idPembeli, string status, decimal totalHarga)
        {
            this.idPesanan = idPesanan;
            this.idProduk = idProduk;
            this.idPembeli = idPembeli;
            this.status = status;
            this.totalHarga = totalHarga;
        }

        // Methods
        public bool BuatPesanan(int idProduk, int idPembeli, int jumlah, decimal hargaSatuan)
        {
            if (jumlah > 0 && hargaSatuan > 0)
            {
                this.idProduk = idProduk;
                this.idPembeli = idPembeli;
                this.totalHarga = jumlah * hargaSatuan;
                this.status = "Dibuat";

                Console.WriteLine($"Pesanan dibuat:");
                Console.WriteLine($"ID Produk: {idProduk}");
                Console.WriteLine($"ID Pembeli: {idPembeli}");
                Console.WriteLine($"Jumlah: {jumlah}");
                Console.WriteLine($"Total Harga: Rp {totalHarga:N0}");
                return true;
            }
            return false;
        }

        public void UpdateStatus(string statusBaru)
        {
            this.status = statusBaru;
            Console.WriteLine($"Status pesanan {idPesanan} diupdate menjadi: {status}");
        }

        public string GetStatus()
        {
            return this.status;
        }

        public bool BatalkanPesanan()
        {
            if (this.status == "Pending" || this.status == "Dibuat")
            {
                this.status = "Dibatalkan";
                Console.WriteLine($"Pesanan {idPesanan} berhasil dibatalkan");
                return true;
            }

            Console.WriteLine("Pesanan tidak dapat dibatalkan");
            return false;
        }

        public decimal HitungTotal(int jumlah, decimal hargaSatuan)
        {
            this.totalHarga = jumlah * hargaSatuan;
            return this.totalHarga;
        }
    }
}