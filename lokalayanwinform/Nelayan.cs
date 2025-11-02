using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokalayanwinform
{
    public class Nelayan : Pengguna
    {
        // Private fields tambahan khusus Nelayan
        private float rating;
        private string lokasi = string.Empty;

        // Properties tambahan
        public float Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Lokasi
        {
            get { return lokasi; }
            set { lokasi = value; }
        }

        // Constructor
        public Nelayan() : base()
        {
        }

        public Nelayan(int idPengguna, string nama, string email, string password, float rating, string lokasi)
            : base(idPengguna, nama, email, password)
        {
            this.rating = rating;
            this.lokasi = lokasi;
        }

        // Methods khusus Nelayan
        public void UpdateRating(float ratingBaru)
        {
            if (ratingBaru >= 0 && ratingBaru <= 5)
            {
                this.rating = ratingBaru;
            }
        }

        public void UpdateLokasi(string lokasiBaru)
        {
            this.lokasi = lokasiBaru;
        }
    }
}
