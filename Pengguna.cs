using System;

namespace LokaLayan
{
    public class Pengguna
    {
        // Private fields
        private int idPengguna;
        private string nama;
        private string email;
        private string password;
        private string role;

        // Properties (getter dan setter)
        public int IdPengguna
        {
            get { return idPengguna; }
            set { idPengguna = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Constructor
        public Pengguna()
        {
        }

        public Pengguna(int idPengguna, string nama, string email, string password)
        {
            this.idPengguna = idPengguna;
            this.nama = nama;
            this.email = email;
            this.password = password;
        }

        // Methods
        public bool Login(string email, string password)
        {
            // Implementasi sederhana login
            return this.email == email && this.password == password;
        }

        public bool Register(string nama, string email, string password)
        {
            // Implementasi sederhana register
            try
            {
                this.nama = nama;
                this.email = email;
                this.password = password;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}