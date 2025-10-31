using System;

namespace lokalayan
{
    // Change the class name to avoid conflict with WPF application entry point
    class ConsoleProgram
    {
        // Rename Main to avoid duplicate entry point
        static void RunConsoleDemo(string[] args)
        {
            Console.WriteLine("=== APLIKASI LOKALAYAN ===");
            Console.WriteLine("Sistem Jual Beli Ikan Lokal\n");

            try
            {
                // Test membuat objek Nelayan
                Console.WriteLine("1. TESTING CLASS NELAYAN");
                Nelayan nelayan1 = new Nelayan(1, "Pak Budi", "budi@email.com", "password123", 4.5f, "Pantai Parangtritis");
                Console.WriteLine($"Nelayan: {nelayan1.Nama}, Lokasi: {nelayan1.Lokasi}, Rating: {nelayan1.Rating}");

                // Test login nelayan
                bool loginBerhasil = nelayan1.Login("budi@email.com", "password123");
                Console.WriteLine($"Login Nelayan: {(loginBerhasil ? "Berhasil" : "Gagal")}");

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Test membuat objek Pembeli
                Console.WriteLine("2. TESTING CLASS PEMBELI");
                Pembeli pembeli1 = new Pembeli(2, "Ibu Sari", "sari@email.com", "password456", "Jl. Malioboro No.10", "Transfer Bank");
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

                // Test membuat pesanan
                Console.WriteLine("4. TESTING CLASS PESANAN");
                Pesanan pesanan1 = new Pesanan(1001, 101, 2, "Pending", 0);
                pesanan1.BuatPesanan(ikan1.IdProduk, 2, 3, ikan1.Harga);
                pesanan1.UpdateStatus("Dikonfirmasi");

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Test Pembayaran
                Console.WriteLine("5. TESTING CLASS PEMBAYARAN");
                Pembayaran bayar1 = new Pembayaran(3001, "Transfer Bank");
                bayar1.MulaiPembayaran(150000, "Transfer Bank");
                bayar1.VerifikasiPembayaran();

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Test Pengiriman
                Console.WriteLine("6. TESTING CLASS PENGIRIMAN");
                Pengiriman kirim1 = new Pengiriman(4001, "Gudang Nelayan", "Kurir");
                kirim1.MulaiPengiriman("Jl. Malioboro No.10, Yogyakarta", "Kurir Express");
                kirim1.UpdateLokasi("Dalam Perjalanan - Checkpoint 1");
                kirim1.UpdateLokasi("Dalam Perjalanan - Checkpoint 2");
                kirim1.SelesaiPengiriman();

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Test skenario sederhana
                Console.WriteLine("7. SKENARIO TRANSAKSI SEDERHANA");
                Console.WriteLine("Simulasi transaksi dari awal hingga selesai:");

                // 1. Pembeli membuat pesanan
                Console.WriteLine("\n• Pembeli membuat pesanan:");
                Pesanan pesananBaru = new Pesanan();
                pesananBaru.BuatPesanan(ikan1.IdProduk, pembeli1.IdPembeli, 2, ikan1.Harga);
                pesananBaru.UpdateStatus("Dikonfirmasi");

                // 2. Proses pembayaran
                Console.WriteLine("\n• Proses pembayaran:");
                Pembayaran pembayaranBaru = new Pembayaran();
                pembayaranBaru.MulaiPembayaran(pesananBaru.TotalHarga, "E-Wallet");

                // 3. Update stok produk
                Console.WriteLine("\n• Update stok produk:");
                int stokLama = ikan1.Stok;
                ikan1.UpdateStok(stokLama - 2);
                Console.WriteLine($"Stok {ikan1.Jenis} berkurang dari {stokLama} menjadi {ikan1.Stok}");

                // 4. Proses pengiriman
                Console.WriteLine("\n• Proses pengiriman:");
                Pengiriman pengirimanBaru = new Pengiriman();
                pengirimanBaru.MulaiPengiriman(pembeli1.GetAlamat(), "Ojek Online");
                pengirimanBaru.SelesaiPengiriman();

                // 5. Pesanan selesai
                pesananBaru.UpdateStatus("Selesai");

                Console.WriteLine("\n" + new string('=', 60));
                Console.WriteLine("🎉 TRANSAKSI SELESAI DENGAN SUKSES! 🎉");
                Console.WriteLine(new string('=', 60));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}