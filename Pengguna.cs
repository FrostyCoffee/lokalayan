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

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // Constructor
        public Pengguna()
        {
        }

        public Pengguna(int idPengguna, string nama, string email, string password, string role)
        {
            this.idPengguna = idPengguna;
            this.nama = nama;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        // Methods
        public bool Login(string email, string password)
        {
            // Implementasi sederhana login
            return this.email == email && this.password == password;
        }

        public bool Register(string nama, string email, string password, string role)
        {
            // Implementasi sederhana register
            try
            {
                this.nama = nama;
                this.email = email;
                this.password = password;
                this.role = role;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}