using System;
using System.Security.Cryptography;
using Npgsql;

namespace lokalayanwinform
{
    public class DatabaseHelper
    {
        private string connectionString = "Host=db.lxnnlskblsgipoymabyj.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=nelayan123lmao;SSL Mode=Require;Trust Server Certificate=true;";

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
