using System;

namespace LokaLayan
{
    public class Negosiasi
    {
        // Private fields
        private decimal hargaTawaran;
        private string status;

        // Properties
        public decimal HargaTawaran
        {
            get { return hargaTawaran; }
            set { hargaTawaran = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Constructor
        public Negosiasi()
        {
            this.status = "Pending";
        }

        public Negosiasi(decimal hargaTawaran)
        {
            this.hargaTawaran = hargaTawaran;
            this.status = "Pending";
        }

        // Methods
        public bool MulaiNegosiasi(decimal hargaAwal, decimal hargaTawaran)
        {
            if (hargaTawaran > 0 && hargaTawaran < hargaAwal)
            {
                this.hargaTawaran = hargaTawaran;
                this.status = "Dalam Negosiasi";
                Console.WriteLine($"Negosiasi dimulai. Harga awal: Rp {hargaAwal:N0}, Tawaran: Rp {hargaTawaran:N0}");
                return true;
            }
            return false;
        }

        public bool AduHarga(decimal hargaCounterOffer)
        {
            if (hargaCounterOffer > this.hargaTawaran)
            {
                Console.WriteLine($"Counter offer diterima: Rp {hargaCounterOffer:N0}");
                this.hargaTawaran = hargaCounterOffer;
                return true;
            }
            return false;
        }

        public decimal HargaAkhir()
        {
            this.status = "Selesai";
            Console.WriteLine($"Negosiasi selesai dengan harga final: Rp {hargaTawaran:N0}");
            return hargaTawaran;
        }

        public void TolakTawaran()
        {
            this.status = "Ditolak";
            Console.WriteLine("Tawaran negosiasi ditolak");
        }
    }
}