using System;

namespace LokaLayan
{
    public class Pesan
    {
        public int IdPesanan { get; set; }
        public string Status { get; set; }
        public decimal TotalHarga { get; set; }

        public Pesan() { }

        public Pesan(int idPesanan, string status, decimal totalHarga)
        {
            IdPesanan = idPesanan;
            Status = status;
            TotalHarga = totalHarga;
        }

        public void BuatPesanan(int idProduk, int jumlah, decimal harga)
        {
            // Simulasi pembuatan pesanan
            TotalHarga = jumlah * harga;
            Status = "Dibuat";
            Console.WriteLine($"Pesanan dibuat: Produk {idProduk}, Jumlah {jumlah}, Total Harga: {TotalHarga:N0}");
        }

        public void UpdateStatus(string statusBaru)
        {
            Status = statusBaru;
            Console.WriteLine($"Status pesanan diupdate menjadi: {Status}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== APLIKASI LOKALAYAN ===");
            Console.WriteLine("Sistem Jual Beli Ikan Lokal\n");

            // Test membuat objek Nelayan
            Console.WriteLine("1. TESTING CLASS NELAYAN");
            Nelayan nelayan1 = new Nelayan(1, "Pak Budi", "budi@email.com", "password123", "nelayan", 4.5f, "Pantai Parangtritis");
            Console.WriteLine($"Nelayan: {nelayan1.Nama}, Lokasi: {nelayan1.Lokasi}, Rating: {nelayan1.Rating}");

            // Test login nelayan
            bool loginBerhasil = nelayan1.Login("budi@email.com", "password123");
            Console.WriteLine($"Login Nelayan: {(loginBerhasil ? "Berhasil" : "Gagal")}");

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test membuat objek Pembeli
            Console.WriteLine("2. TESTING CLASS PEMBELI");
            Pembeli pembeli1 = new Pembeli(2, "Ibu Sari", "sari@email.com", "password456", "pembeli", "Jl. Malioboro No.10", "Transfer Bank");
            Console.WriteLine($"Pembeli: {pembeli1.Nama}, Alamat: {pembeli1.GetAlamat()}");

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test membuat produk
            Console.WriteLine("3. TESTING CLASS PRODUK");
            Produk ikan1 = new Produk(101, "Tuna", "Grade A", 50000, 10, DateTime.Now.AddDays(-1));
            Produk ikan2 = new Produk(102, "Kakap", "Grade B", 35000, 15, DateTime.Now.AddDays(-2));

            Console.WriteLine($"Produk 1: {ikan1.Jenis} {ikan1.Grade}, Harga: Rp {ikan1.Harga:N0}, Stok: {ikan1.Stok}");
            Console.WriteLine($"Produk 2: {ikan2.Jenis} {ikan2.Grade}, Harga: Rp {ikan2.Harga:N0}, Stok: {ikan2.Stok}");

            // Update stok
            ikan1.UpdateStok(8);
            Console.WriteLine($"Stok {ikan1.Jenis} setelah update: {ikan1.Stok}");

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test katalog produk
            Console.WriteLine("4. TESTING CLASS KATALOG PRODUK");
            KatalogProduk katalog = new KatalogProduk("Ikan Segar");
            katalog.TambahProduk(ikan1);
            katalog.TambahProduk(ikan2);
            katalog.TampilkanKatalog();

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test membuat pesanan
            Console.WriteLine("5. TESTING CLASS PESAN");
            Pesan pesanan1 = new Pesan(1001, "Pending", 0);
            pesanan1.BuatPesanan(101, 3, ikan1.Harga);
            pesanan1.UpdateStatus("Dikonfirmasi");

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test negosiasi
            Console.WriteLine("6. TESTING CLASS NEGOSIASI");
            Negosiasi nego1 = new Negosiasi();
            nego1.MulaiNegosiasi(50000, 45000);
            nego1.AduHarga(47000);
            decimal hargaFinal = nego1.HargaAkhir();

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test Request Buyer
            Console.WriteLine("7. TESTING CLASS REQUEST BUYER");
            RequestBuyer request1 = new RequestBuyer(2001, "Salmon", "Grade A", 20, DateTime.Now.AddDays(7));
            request1.PostRequest("Salmon", "Grade A", 20, DateTime.Now.AddDays(7));
            request1.TerimaTawaran(60000);
            Console.WriteLine($"Status Request: {request1.GetStatus()}");

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test Pembayaran
            Console.WriteLine("8. TESTING CLASS PEMBAYARAN");
            Pembayaran bayar1 = new Pembayaran(3001, "Transfer Bank");
            bayar1.MulaiPembayaran(150000, "Transfer Bank");
            bayar1.VerifikasiPembayaran();

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test Pengiriman
            Console.WriteLine("9. TESTING CLASS PENGIRIMAN");
            Pengiriman kirim1 = new Pengiriman(4001, "Gudang Nelayan", "Kurir");
            kirim1.MulaiPengiriman("Jl. Malioboro No.10, Yogyakarta", "Kurir Express");
            kirim1.UpdateLokasi("Dalam Perjalanan - Checkpoint 1");
            kirim1.UpdateLokasi("Dalam Perjalanan - Checkpoint 2");
            kirim1.SelesaiPengiriman();

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Test skenario lengkap
            Console.WriteLine("10. SKENARIO TRANSAKSI LENGKAP");
            Console.WriteLine("Simulasi transaksi dari awal hingga selesai:");

            // 1. Pembeli melihat katalog
            Console.WriteLine("\n• Pembeli melihat katalog produk:");
            katalog.TampilkanKatalog();

            // 2. Pembeli membuat pesanan
            Console.WriteLine("\n• Pembeli membuat pesanan:");
            Pesan pesananBaru = new Pesan();
            pesananBaru.BuatPesanan(ikan1.IdProduk, 2, ikan1.Harga);

            // 3. Negosiasi harga
            Console.WriteLine("\n• Proses negosiasi:");
            Negosiasi negosiasiBaru = new Negosiasi();
            negosiasiBaru.MulaiNegosiasi(ikan1.Harga, ikan1.Harga - 5000);
            decimal hargaAkhir = negosiasiBaru.HargaAkhir();

            // 4. Update pesanan dengan harga hasil negosiasi
            pesananBaru.BuatPesanan(ikan1.IdProduk, 2, hargaAkhir);
            pesananBaru.UpdateStatus("Dikonfirmasi");

            // 5. Proses pembayaran
            Console.WriteLine("\n• Proses pembayaran:");
            Pembayaran pembayaranBaru = new Pembayaran();
            pembayaranBaru.MulaiPembayaran(pesananBaru.TotalHarga, "E-Wallet");

            // 6. Update stok produk
            Console.WriteLine("\n• Update stok produk:");
            int stokLama = ikan1.Stok;
            ikan1.UpdateStok(stokLama - 2);
            Console.WriteLine($"Stok {ikan1.Jenis} berkurang dari {stokLama} menjadi {ikan1.Stok}");

            // 7. Proses pengiriman
            Console.WriteLine("\n• Proses pengiriman:");
            Pengiriman pengirimanBaru = new Pengiriman();
            pengirimanBaru.MulaiPengiriman(pembeli1.GetAlamat(), "Ojek Online");
            pengirimanBaru.SelesaiPengiriman();

            // 8. Pesanan selesai
            pesananBaru.UpdateStatus("Selesai");

            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("🎉 TRANSAKSI SELESAI DENGAN SUKSES! 🎉");
            Console.WriteLine(new string('=', 60));

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
} 