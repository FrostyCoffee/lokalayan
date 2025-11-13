using System;
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
        }
        private string connectionString = "Host=db.lxnnlskblsgipoymabyj.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=nelayan123lmao;SSL Mode=Require;Trust Server Certificate=true;";
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
                            return dt.Rows[0]; // Return the first row
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
                string query = "SELECT idProduk, kategori, jenis, grade, harga, stok, tanggalTangkap  FROM Produk";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("idNelayan", idNelayan);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void AddProduk(string kategori, string jenis, string grade, int harga, int stok, int tanggalTangkap)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Produk (kategori, jenis, grade, harga, stok, tanggalTangkap) VALUES (@kategori, @jenis, @grade, @harga, @stok, @tanggalTangkap)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("jenis", jenis);
                    cmd.Parameters.AddWithValue("grade", grade);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("stok", stok);
                    cmd.Parameters.AddWithValue("tanggalTangkap", tanggalTangkap);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProduk(int idProduk, string kategori, string jenis, string grade, int harga, int stok, int tanggalTangkap)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Produk SET kategori = @kategori, jenis = @jenis, grade = @grade, harga=@harga, stok=@stok, tanggalTangkap=@tanggalTangkap WHERE idProduk = @idProduk";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("id", idProduk);
                    cmd.Parameters.AddWithValue("kategori", kategori);
                    cmd.Parameters.AddWithValue("jenis", jenis);
                    cmd.Parameters.AddWithValue("grade", grade);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("stok", stok);
                    cmd.Parameters.AddWithValue("tanggalTangkap", tanggalTangkap);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduk(int idProduk)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Produk WHERE idProduk = @idProduk";
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
        public int RegisterUser(Pengguna pengguna)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Pengguna\" (nama, password, email) VALUES (@nama, @password, @email) RETURNING \"idPengguna\"";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("nama", pengguna.Nama);
                    cmd.Parameters.AddWithValue("password", pengguna.Password);
                    cmd.Parameters.AddWithValue("email", pengguna.Email);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        public void RegisterNelayan(Nelayan nelayan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Nelayan\" (\"idPengguna\", lokasi) VALUES (@\"idPengguna\", @lokasi)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("\"idPengguna\"", nelayan.IdPengguna);
                    cmd.Parameters.AddWithValue("lokasi", nelayan.Lokasi);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void RegisterPembeli(Pembeli pembeli)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO \"Pembeli\" (\"idPengguna\", alamat) VALUES (@\"idPengguna\", @alamat)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("\"idPengguna\"", pembeli.IdPengguna);
                    cmd.Parameters.AddWithValue("alamat", pembeli.Alamat);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public Pengguna GetPenggunaByEmail(string email)
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
                            return new Pengguna
                            {
                                IdPengguna = reader.GetInt32(0),
                                Nama = reader.GetString(1),
                                Password = reader.GetString(2),
                                Email = reader.GetString(3)
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
