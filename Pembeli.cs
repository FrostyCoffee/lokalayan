using System;

namespace LokaLayan
{
    public class Pembeli : Pengguna
    {
        // Private fields tambahan khusus Pembeli
        private string alamat;
        private string pembayaran;

        // Properties tambahan
        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string Pembayaran
        {
            get { return pembayaran; }
            set { pembayaran = value; }
        }

        // Constructor
        public Pembeli() : base()
        {
        }

        public Pembeli(int idPengguna, string nama, string email, string password, string role, string alamat, string pembayaran) 
            : base(idPengguna, nama, email, password, role)
        {
            this.alamat = alamat;
            this.pembayaran = pembayaran;
        }

        // Methods khusus Pembeli
        public string GetAlamat()
        {
            return this.alamat;
        }

        public void UpdateAlamat(string alamatBaru)
        {
            this.alamat = alamatBaru;
        }

        public void SetMetodePembayaran(string metodePembayaran)
        {
            this.pembayaran = metodePembayaran;
        }
    }
}