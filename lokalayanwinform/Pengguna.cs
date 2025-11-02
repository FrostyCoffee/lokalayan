using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokalayanwinform
{
    public class Pengguna
    {
        // Private fields
        private int idPengguna;
        private string nama = string.Empty;
        private string email = string.Empty;
        private string password = string.Empty;

        // Properties
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

        // Constructors
        public Pengguna()
        {
            // Default constructor
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
            // Simple login implementation
            if (this.email == email && this.password == password)
            {
                Console.WriteLine($"Login berhasil: {nama}");
                return true;
            }
            Console.WriteLine("Login gagal: Email atau password salah");
            return false;
        }

        public void UpdateProfile(string nama, string email)
        {
            this.nama = nama;
            this.email = email;
            Console.WriteLine("Profil berhasil diperbarui");
        }

        public void GantiPassword(string passwordLama, string passwordBaru)
        {
            if (this.password == passwordLama)
            {
                this.password = passwordBaru;
                Console.WriteLine("Password berhasil diubah");
            }
            else
            {
                Console.WriteLine("Password lama tidak sesuai");
            }
        }
    }
}
