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
    public partial class PemesananPenjual : Form
    {
        public PemesananPenjual()
        {
            InitializeComponent();
            LoadPesananProduk();
        }

        private void dtgrCekPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPesananProduk()
        {
            int idNelayan = DatabaseHelper.Session.idNelayan ?? 0;
            if (idNelayan == 0)
            {
                MessageBox.Show("Identitas nelayan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable dt = dbHelper.GetPesananbyNelayan(idNelayan);
            dtgrCekPemesanan.DataSource = dt;
        }

        private void btn_balik_Click(object sender, EventArgs e)
        {
            DashboardPenjual dashboardPenjual = new DashboardPenjual();
            dashboardPenjual.Show();
            this.Close();
        }
    }
}
