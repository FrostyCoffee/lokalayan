using System;

namespace LokaLayan
{
    public class RequestBuyer
    {
        // Private fields
        private int reqID;
        private string jenisIkan;
        private string grade;
        private int kuantitas;
        private DateTime tanggalBatas;
        private string status;

        // Properties
        public int ReqID
        {
            get { return reqID; }
            set { reqID = value; }
        }

        public string JenisIkan
        {
            get { return jenisIkan; }
            set { jenisIkan = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Kuantitas
        {
            get { return kuantitas; }
            set { kuantitas = value; }
        }

        public DateTime TanggalBatas
        {
            get { return tanggalBatas; }
            set { tanggalBatas = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Constructor
        public RequestBuyer()
        {
            this.status = "Active";
        }

        public RequestBuyer(int reqID, string jenisIkan, string grade, int kuantitas, DateTime tanggalBatas)
        {
            this.reqID = reqID;
            this.jenisIkan = jenisIkan;
            this.grade = grade;
            this.kuantitas = kuantitas;
            this.tanggalBatas = tanggalBatas;
            this.status = "Active";
        }

        // Methods
        public bool PostRequest(string jenisIkan, string grade, int kuantitas, DateTime tanggalBatas)
        {
            if (!string.IsNullOrEmpty(jenisIkan) && kuantitas > 0 && tanggalBatas > DateTime.Now)
            {
                this.jenisIkan = jenisIkan;
                this.grade = grade;
                this.kuantitas = kuantitas;
                this.tanggalBatas = tanggalBatas;
                this.status = "Posted";
                
                Console.WriteLine($"Request berhasil dipost:");
                Console.WriteLine($"Jenis Ikan: {jenisIkan}");
                Console.WriteLine($"Grade: {grade}");
                Console.WriteLine($"Kuantitas: {kuantitas} kg");
                Console.WriteLine($"Batas Waktu: {tanggalBatas:dd/MM/yyyy}");
                return true;
            }
            return false;
        }

        public bool TerimaTawaran(decimal hargaTawaran)
        {
            this.status = "Accepted";
            Console.WriteLine($"Tawaran sebesar Rp {hargaTawaran:N0} diterima untuk request {reqID}");
            return true;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public bool CekValiditas()
        {
            if (DateTime.Now > tanggalBatas)
            {
                this.status = "Expired";
                return false;
            }
            return true;
        }
    }
}