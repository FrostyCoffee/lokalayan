namespace lokalayanwinform
{
    partial class DashboardPenjual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleDashboardPenjual = new Label();
            labelTotalPesan = new Label();
            lblTotalStock = new Label();
            lblJumlahProduk = new Label();
            counterTotalPesanan = new Label();
            counterTotalStok = new Label();
            counterJumlahProduk = new Label();
            btnEditProduk = new Button();
            btnCekStok = new Button();
            SuspendLayout();
            // 
            // titleDashboardPenjual
            // 
            titleDashboardPenjual.AutoSize = true;
            titleDashboardPenjual.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleDashboardPenjual.Location = new Point(292, 45);
            titleDashboardPenjual.Name = "titleDashboardPenjual";
            titleDashboardPenjual.Size = new Size(227, 26);
            titleDashboardPenjual.TabIndex = 0;
            titleDashboardPenjual.Text = "Dashboard Penjualan";
            // 
            // labelTotalPesan
            // 
            labelTotalPesan.AutoSize = true;
            labelTotalPesan.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalPesan.Location = new Point(305, 128);
            labelTotalPesan.Name = "labelTotalPesan";
            labelTotalPesan.Size = new Size(91, 16);
            labelTotalPesan.TabIndex = 1;
            labelTotalPesan.Text = "Total Pesanan";
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(305, 156);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(66, 16);
            lblTotalStock.TabIndex = 2;
            lblTotalStock.Text = "Total Stok";
            // 
            // lblJumlahProduk
            // 
            lblJumlahProduk.AutoSize = true;
            lblJumlahProduk.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahProduk.Location = new Point(305, 185);
            lblJumlahProduk.Name = "lblJumlahProduk";
            lblJumlahProduk.Size = new Size(100, 16);
            lblJumlahProduk.TabIndex = 3;
            lblJumlahProduk.Text = "Jumlah Produk";
            // 
            // counterTotalPesanan
            // 
            counterTotalPesanan.AutoSize = true;
            counterTotalPesanan.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counterTotalPesanan.Location = new Point(475, 128);
            counterTotalPesanan.Name = "counterTotalPesanan";
            counterTotalPesanan.Size = new Size(23, 16);
            counterTotalPesanan.TabIndex = 4;
            counterTotalPesanan.Text = "00";
            // 
            // counterTotalStok
            // 
            counterTotalStok.AutoSize = true;
            counterTotalStok.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counterTotalStok.Location = new Point(475, 156);
            counterTotalStok.Name = "counterTotalStok";
            counterTotalStok.Size = new Size(23, 16);
            counterTotalStok.TabIndex = 5;
            counterTotalStok.Text = "00";
            // 
            // counterJumlahProduk
            // 
            counterJumlahProduk.AutoSize = true;
            counterJumlahProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counterJumlahProduk.Location = new Point(475, 185);
            counterJumlahProduk.Name = "counterJumlahProduk";
            counterJumlahProduk.Size = new Size(23, 16);
            counterJumlahProduk.TabIndex = 6;
            counterJumlahProduk.Text = "00";
            // 
            // btnEditProduk
            // 
            btnEditProduk.BackColor = Color.Turquoise;
            btnEditProduk.FlatAppearance.BorderColor = Color.White;
            btnEditProduk.FlatAppearance.BorderSize = 0;
            btnEditProduk.FlatStyle = FlatStyle.Flat;
            btnEditProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProduk.Location = new Point(292, 260);
            btnEditProduk.Name = "btnEditProduk";
            btnEditProduk.Size = new Size(227, 23);
            btnEditProduk.TabIndex = 7;
            btnEditProduk.Text = "Edit Produk";
            btnEditProduk.UseVisualStyleBackColor = false;
            btnEditProduk.Click += btnEditProduk_Click;
            // 
            // btnCekStok
            // 
            btnCekStok.BackColor = Color.Turquoise;
            btnCekStok.FlatAppearance.BorderSize = 0;
            btnCekStok.FlatStyle = FlatStyle.Flat;
            btnCekStok.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCekStok.Location = new Point(292, 301);
            btnCekStok.Name = "btnCekStok";
            btnCekStok.Size = new Size(227, 23);
            btnCekStok.TabIndex = 8;
            btnCekStok.Text = "Cek Pesanan";
            btnCekStok.UseVisualStyleBackColor = false;
            btnCekStok.Click += btnCekStok_Click;
            // 
            // DashboardPenjual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCekStok);
            Controls.Add(btnEditProduk);
            Controls.Add(counterJumlahProduk);
            Controls.Add(counterTotalStok);
            Controls.Add(counterTotalPesanan);
            Controls.Add(lblJumlahProduk);
            Controls.Add(lblTotalStock);
            Controls.Add(labelTotalPesan);
            Controls.Add(titleDashboardPenjual);
            Name = "DashboardPenjual";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleDashboardPenjual;
        private Label labelTotalPesan;
        private Label lblTotalStock;
        private Label lblJumlahProduk;
        private Label counterTotalPesanan;
        private Label counterTotalStok;
        private Label counterJumlahProduk;
        private Button btnEditProduk;
        private Button btnCekStok;
    }
}