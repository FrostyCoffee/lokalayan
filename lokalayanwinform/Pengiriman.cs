using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokalayanwinform
{
    public class Pengiriman
    {
        // Private fields
        private int idPengiriman;
        private string lokasiBarang = string.Empty;
        private string metode = string.Empty;

        // Properties
        public int IdPengiriman
        {
            get { return idPengiriman; }
            set { idPengiriman = value; }
        }

        public string LokasiBarang
        {
            get { return lokasiBarang; }
            set { lokasiBarang = value; }
        }

        public string Metode
        {
            get { return metode; }
            set { metode = value; }
        }

        // Constructor
        public Pengiriman()
        {
        }

        public Pengiriman(int idPengiriman, string lokasiBarang, string metode)
        {
            this.idPengiriman = idPengiriman;
            this.lokasiBarang = lokasiBarang;
            this.metode = metode;
        }

        // Methods
        public bool MulaiPengiriman(string alamatTujuan, string metodePengiriman)
        {
            if (!string.IsNullOrEmpty(alamatTujuan) && !string.IsNullOrEmpty(metodePengiriman))
            {
                this.metode = metodePengiriman;
                Console.WriteLine($"Pengiriman dimulai ke alamat: {alamatTujuan}");
                Console.WriteLine($"Metode pengiriman: {metodePengiriman}");

                // Update lokasi barang
                this.lokasiBarang = "Dalam Perjalanan";
                return true;
            }
            return false;
        }

        public string GetLokasi()
        {
            return this.lokasiBarang;
        }

        public void UpdateLokasi(string lokasiBaru)
        {
            this.lokasiBarang = lokasiBaru;
            Console.WriteLine($"Lokasi barang diupdate: {lokasiBaru}");
        }

        public bool SelesaiPengiriman()
        {
            this.lokasiBarang = "Terdelivery";
            Console.WriteLine($"Pengiriman dengan ID {idPengiriman} telah selesai");
            return true;
        }
    }
}
