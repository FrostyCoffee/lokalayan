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
            labelTotalJual = new Label();
            lblTotalStock = new Label();
            lblJumlahProduk = new Label();
            counterTotalJual = new Label();
            counterTotalStok = new Label();
            label1 = new Label();
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
            // labelTotalJual
            // 
            labelTotalJual.AutoSize = true;
            labelTotalJual.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalJual.Location = new Point(305, 128);
            labelTotalJual.Name = "labelTotalJual";
            labelTotalJual.Size = new Size(99, 16);
            labelTotalJual.TabIndex = 1;
            labelTotalJual.Text = "Total Penjualan";
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
            // counterTotalJual
            // 
            counterTotalJual.AutoSize = true;
            counterTotalJual.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counterTotalJual.Location = new Point(475, 128);
            counterTotalJual.Name = "counterTotalJual";
            counterTotalJual.Size = new Size(23, 16);
            counterTotalJual.TabIndex = 4;
            counterTotalJual.Text = "00";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 185);
            label1.Name = "label1";
            label1.Size = new Size(23, 16);
            label1.TabIndex = 6;
            label1.Text = "00";
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
            // 
            // DashboardPenjual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCekStok);
            Controls.Add(btnEditProduk);
            Controls.Add(label1);
            Controls.Add(counterTotalStok);
            Controls.Add(counterTotalJual);
            Controls.Add(lblJumlahProduk);
            Controls.Add(lblTotalStock);
            Controls.Add(labelTotalJual);
            Controls.Add(titleDashboardPenjual);
            Name = "DashboardPenjual";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleDashboardPenjual;
        private Label labelTotalJual;
        private Label lblTotalStock;
        private Label lblJumlahProduk;
        private Label counterTotalJual;
        private Label counterTotalStok;
        private Label label1;
        private Button btnEditProduk;
        private Button btnCekStok;
    }
}