using System;

namespace LokaLayan
{
    public class Produk
    {
        // Private fields
        private int idProduk;
        private string jenis;
        private string grade;
        private decimal harga;
        private int stok;
        private DateTime tanggalTangkap;

        // Properties
        public int IdProduk
        {
            get { return idProduk; }
            set { idProduk = value; }
        }

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public decimal Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int Stok
        {
            get { return stok; }
            set { stok = value; }
        }

        public DateTime TanggalTangkap
        {
            get { return tanggalTangkap; }
            set { tanggalTangkap = value; }
        }

        // Constructor
        public Produk()
        {
        }

        public Produk(int idProduk, string jenis, string grade, decimal harga, int stok, DateTime tanggalTangkap)
        {
            this.idProduk = idProduk;
            this.jenis = jenis;
            this.grade = grade;
            this.harga = harga;
            this.stok = stok;
            this.tanggalTangkap = tanggalTangkap;
        }

        // Methods
        public bool UpdateStok(int jumlahBaru)
        {
            if (jumlahBaru >= 0)
            {
                this.stok = jumlahBaru;
                return true;
            }
            return false;
        }

        public bool CekKetersediaan(int jumlahDiminta)
        {
            return stok >= jumlahDiminta;
        }
    }
}