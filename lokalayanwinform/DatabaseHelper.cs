using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using Npgsql;

namespace lokalayanwinform
{
    public class DatabaseHelper
    {
        public static class Session
        {
            public static int idPengguna { get; set; }
            public static int? idNelayan { get; set; }
            public static int? idPembeli { get; set; }
        }
        private string connectionString = "Host=aws-1-ap-southeast-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.lxnnlskblsgipoymabyj;Password=nelayan123lmao;SSL Mode=Require;Trust Server Certificate=true;";
        public DataTable GetPesananbyNelayan (int idNelayan)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT p.* FROM \"Pesanan\" p" +
                    "INNER JOIN Produk pr ON p.\"idProduk\" = pr.\"idProduk\"" +
                    "WHERE pr.\"idNelayan\" = @idNelayan";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idNelayan", idNelayan);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public int InsertPesanan(int idPembeli, int totalHarga, string status)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO \"Pesanan\" (\"idPembeli\", \"totalHarga\", \"status\") VALUES (@idPembeli, @totalHarga, @status) RETURNING \"idPesanan\"";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPembeli", idPembeli);
                    cmd.Parameters.AddWithValue("totalHarga", totalHarga);
                    cmd.Parameters.AddWithValue("status", status);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public void InsertDetailPesanan(int idPesanan, int idProduk, int hargaSatuan, int jumlah)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO \"detailPesanan\" (\"idPesanan\", \"idProduk\", \"hargaSatuan\", \"jumlah\") VALUES (@idPesanan, @idProduk, @hargaSatuan, @jumlah)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPesanan", idPesanan);
                    cmd.Parameters.AddWithValue("idProduk", idProduk);
                    cmd.Parameters.AddWithValue("hargaSatuan", hargaSatuan);
                    cmd.Parameters.AddWithValue("jumlah", jumlah);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertPembayaran(int idPesanan, string metode, string status)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO \"Pembayaran\" (\"idPesanan\", \"metode\", \"status\") VALUES (@idPesanan, @metode, @status)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPesanan", idPesanan);
                    cmd.Parameters.AddWithValue("metode", metode);
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertPengiriman(int idPesanan, string metode)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO \"Pengiriman\" (\"idPesanan\", \"metode\") VALUES (@idPesanan, @metode)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPesanan", idPesanan);
                    cmd.Parameters.AddWithValue("metode", metode);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStockInDatabase(int newStock, int idProduk)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE \"Produk\" SET \"stok\" = @stok WHERE \"idProduk\" = @idProduk";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("stok", newStock);
                        cmd.Parameters.AddWithValue("idProduk", idProduk);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui stok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataRow GetProductById(int idProduk)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM \"Produk\" WHERE \"idProduk\" = @idProduk";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idProduk", idProduk);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0];
                        }
                        else
                        {
                            throw new Exception("Produk tidak ditemukan.");
                        }
                    }
                }
            }
        }
        public DataTable KatalogProduk()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT kategori, jenis, harga FROM \"Produk\"";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public int GetTotalPesanan(int idNelayan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COALESCE(SUM(dp.jumlah), 0) " +
               "FROM \"detailPesanan\" dp " +
               "INNER JOIN \"Produk\" p ON dp.\"idProduk\" = p.\"idProduk\" " +
               "WHERE p.\"idNelayan\" = @idNelayan";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idNelayan", idNelayan);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int GetTotalStok(int idNelayan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COALESCE(SUM(stok), 0) FROM \"Produk\" WHERE \"idNelayan\" = @idNelayan";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idNelayan", idNelayan);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int GetJumlahProduk(int idNelayan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM \"Produk\" WHERE \"idNelayan\" = @idNelayan";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idNelayan", idNelayan);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int? GetidPembelibyidPengguna(int idPengguna)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT \"idPembeli\" FROM \"Pembeli\" WHERE \"idPengguna\" = @idPengguna";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idPengguna", idPengguna);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int?)result : null;
                }
            }
        }

        public int? GetidNelayanbyidPengguna(int idPengguna)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT \"idNelayan\" FROM \"Nelayan\" WHERE \"idPengguna\" = @idPengguna";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idPengguna", idPengguna);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int?)result : null;
                }
            }
        }
            public DataTable GetAllProduk(int idNelayan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT \"idProduk\", kategori, jenis, grade, harga, stok, \"tanggalTangkap\"  FROM \"Produk\"";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("idNelayan", idNelayan);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void AddProduk(int idNelayan, string kategori, string jenis, string grade, int harga, int stok)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Produk\" (\"idNelayan\", kategori, jenis, grade, harga, stok) VALUES (@idNelayan, @kategori, @jenis, @grade, @harga, @stok)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idNelayan", idNelayan);
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("jenis", jenis);
                    cmd.Parameters.AddWithValue("grade", grade);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("stok", stok);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProduk(int idProduk, string kategori, string jenis, string grade, int harga, int stok)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE \"Produk\" SET kategori = @kategori, jenis = @jenis, grade = @grade, harga=@harga, stok=@stok WHERE \"idProduk\" = @idProduk";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("id", idProduk);
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("jenis", jenis);
                    cmd.Parameters.AddWithValue("grade", grade);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("stok", stok);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduk(int idProduk)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM \"Produk\" WHERE \"idProduk\" = @idProduk";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idProduk", idProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection to Supabase PostgreSQL database successful!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
            }
        }
        public int RegisterUser(string nama, string password, string email)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Pengguna\" (nama, password, email) VALUES (@nama, @password, @email) RETURNING \"idPengguna\"";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("email", email);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        public void RegisterNelayan(int idPengguna, string lokasi)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Nelayan\" (\"idPengguna\", lokasi) VALUES (@idPengguna, @lokasi)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue ("idPengguna", idPengguna);
                    cmd.Parameters.AddWithValue("lokasi", lokasi);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void RegisterPembeli(int idPengguna,string alamat)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Pembeli\" (\"idPengguna\", alamat) VALUES (@idPengguna, @alamat)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idPengguna", idPengguna);
                    cmd.Parameters.AddWithValue("alamat", alamat);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public Dictionary<string, object> GetPenggunaByEmail(string email)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT \"idPengguna\", nama, password, email FROM \"Pengguna\" WHERE email = @email";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Dictionary<string, object>
                    {
                        { "idPengguna", reader.GetInt32(0) },
                        { "nama", reader.GetString(1) },
                        { "password", reader.GetString(2) },
                        { "email", reader.GetString(3) }
                    };
                        }
                    }
                }
            }
            return null;
        }
        public bool IsUserNelayan(int idPengguna)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM \"Nelayan\" WHERE \"idPengguna\" = @idPengguna";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("idPengguna", idPengguna);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }   
}
