using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokalayanwinform
{
    public class Pembeli : Pengguna
    {
        private string alamat = string.Empty;
        private string pembayaran = string.Empty;
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

        public Pembeli(int idPengguna, string nama, string email, string password, string alamat, string pembayaran)
            : base(idPengguna, nama, email, password)
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
