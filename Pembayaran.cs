using System;

namespace lokalayan
{
    public class Pembayaran
    {
        // Private fields
        private int idPembayaran;
        private string metode = string.Empty;
        private string status;

        // Properties
        public int IdPembayaran
        {
            get { return idPembayaran; }
            set { idPembayaran = value; }
        }

        public string Metode
        {
            get { return metode; }
            set { metode = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Constructor
        public Pembayaran()
        {
            this.status = "Pending";
        }

        public Pembayaran(int idPembayaran, string metode)
        {
            this.idPembayaran = idPembayaran;
            this.metode = metode;
            this.status = "Pending";
        }

        // Methods
        public bool MulaiPembayaran(decimal jumlah, string metodePembayaran)
        {
            if (jumlah > 0 && !string.IsNullOrEmpty(metodePembayaran))
            {
                this.metode = metodePembayaran;
                this.status = "Processing";
                
                Console.WriteLine($"Memulai pembayaran sebesar Rp {jumlah:N0} via {metodePembayaran}");
                
                // Simulasi proses pembayaran
                System.Threading.Thread.Sleep(1000); // Simulasi delay
                
                this.status = "Completed";
                Console.WriteLine("Pembayaran berhasil!");
                return true;
            }
            return false;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public bool VerifikasiPembayaran()
        {
            if (this.status == "Completed")
            {
                Console.WriteLine($"Pembayaran dengan ID {idPembayaran} telah terverifikasi");
                return true;
            }
            
            Console.WriteLine("Pembayaran belum selesai atau gagal");
            return false;
        }

        public void BatalkanPembayaran()
        {
            this.status = "Cancelled";
            Console.WriteLine($"Pembayaran dengan ID {idPembayaran} telah dibatalkan");
        }
    }
}