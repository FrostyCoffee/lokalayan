using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lokalayanwinform.DatabaseHelper;

namespace lokalayanwinform
{
    public partial class Katalog : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public Katalog()
        {
            InitializeComponent();
            LoadProduk();
        }
        private void OpenProductPage(int idProduk)
        {
            ProductPage productPage = new ProductPage(idProduk);
            productPage.Show();
        }
        private void LoadProduk()
        {
            try
            {
                DataTable produkData = dbHelper.KatalogProduk();
                flpKatalog.Controls.Clear();
                foreach (DataRow row in produkData.Rows)
                {
                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 100),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        Tag = row["idProduk"]
                    };
                    Label kategoriLabel = new Label
                    {
                        Text = "Kategori: " + row["kategori"].ToString(),
                        Location = new Point(10, 10),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(kategoriLabel);
                    Label jenisLabel = new Label
                    {
                        Text = "Jenis: " + row["jenis"].ToString(),
                        Location = new Point(10, 30),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(jenisLabel);
                    Label hargaLabel = new Label
                    {
                        Text = "Harga: Rp " + row["harga"].ToString(),
                        Location = new Point(10, 50),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(hargaLabel);
                    flpKatalog.Controls.Add(productPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data katalog: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
