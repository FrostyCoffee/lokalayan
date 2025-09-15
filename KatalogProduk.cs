using System;
using System.Collections.Generic;

namespace LokaLayan
{
    public class KatalogProduk
    {
        // Private fields
        private string kategori;
        private List<Produk> listProduk;

        // Properties
        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }

        public List<Produk> ListProduk
        {
            get { return listProduk; }
            set { listProduk = value; }
        }

        // Constructor
        public KatalogProduk()
        {
            listProduk = new List<Produk>();
        }

        public KatalogProduk(string kategori)
        {
            this.kategori = kategori;
            this.listProduk = new List<Produk>();
        }

        // Methods
        public void TambahProduk(Produk produk)
        {
            if (produk != null)
            {
                listProduk.Add(produk);
                Console.WriteLine($"Produk {produk.Jenis} berhasil ditambahkan ke katalog {kategori}");
            }
        }

        public List<Produk> CariProduk(string jenisProduk)
        {
            List<Produk> hasilCari = new List<Produk>();
            
            foreach (Produk p in listProduk)
            {
                if (p.Jenis.ToLower().Contains(jenisProduk.ToLower()))
                {
                    hasilCari.Add(p);
                }
            }
            
            return hasilCari;
        }

        public List<Produk> FilterBerdasarGrade(string grade)
        {
            List<Produk> hasilFilter = new List<Produk>();
            
            foreach (Produk p in listProduk)
            {
                if (p.Grade.Equals(grade, StringComparison.OrdinalIgnoreCase))
                {
                    hasilFilter.Add(p);
                }
            }
            
            return hasilFilter;
        }

        public void TampilkanKatalog()
        {
            Console.WriteLine($"=== Katalog {kategori} ===");
            foreach (Produk p in listProduk)
            {
                Console.WriteLine($"ID: {p.IdProduk}, Jenis: {p.Jenis}, Grade: {p.Grade}, Harga: Rp {p.Harga:N0}, Stok: {p.Stok}");
            }
        }
    }
}