namespace lokalayanwinform
{
    partial class ProductPage
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
            btnKembaliProduk = new Button();
            titleProduk = new Label();
            titleKategori = new Label();
            lblGradeProduk = new Label();
            lblHargaProduk = new Label();
            lblTanggalTangkap = new Label();
            btnBeliProduk = new Button();
            lblStok = new Label();
            counterStokProduk = new Label();
            lblJumlahBeli = new Label();
            textBoxJumlahBeli = new TextBox();
            fillGrade = new Label();
            fillTanggal = new Label();
            titleJenis = new Label();
            SuspendLayout();
            // 
            // btnKembaliProduk
            // 
            btnKembaliProduk.BackColor = Color.Turquoise;
            btnKembaliProduk.FlatAppearance.BorderSize = 0;
            btnKembaliProduk.FlatStyle = FlatStyle.Flat;
            btnKembaliProduk.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembaliProduk.Location = new Point(22, 21);
            btnKembaliProduk.Name = "btnKembaliProduk";
            btnKembaliProduk.Size = new Size(75, 23);
            btnKembaliProduk.TabIndex = 0;
            btnKembaliProduk.Text = "Kembali";
            btnKembaliProduk.UseVisualStyleBackColor = false;
            btnKembaliProduk.Click += btnKembaliProduk_Click;
            // 
            // titleProduk
            // 
            titleProduk.AutoSize = true;
            titleProduk.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleProduk.Location = new Point(210, 116);
            titleProduk.Name = "titleProduk";
            titleProduk.Size = new Size(0, 26);
            titleProduk.TabIndex = 2;
            titleProduk.TextAlign = ContentAlignment.MiddleLeft;
            titleProduk.Click += titleProduk_Click;
            // 
            // titleKategori
            // 
            titleKategori.AutoSize = true;
            titleKategori.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleKategori.Location = new Point(64, 104);
            titleKategori.MaximumSize = new Size(500, 500);
            titleKategori.Name = "titleKategori";
            titleKategori.Size = new Size(168, 29);
            titleKategori.TabIndex = 5;
            titleKategori.Text = "[Kategori Ikan]";
            // 
            // lblGradeProduk
            // 
            lblGradeProduk.AutoSize = true;
            lblGradeProduk.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeProduk.Location = new Point(64, 260);
            lblGradeProduk.Name = "lblGradeProduk";
            lblGradeProduk.Size = new Size(57, 22);
            lblGradeProduk.TabIndex = 6;
            lblGradeProduk.Text = "Grade";
            // 
            // lblHargaProduk
            // 
            lblHargaProduk.AutoSize = true;
            lblHargaProduk.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaProduk.Location = new Point(606, 176);
            lblHargaProduk.Name = "lblHargaProduk";
            lblHargaProduk.Size = new Size(113, 26);
            lblHargaProduk.TabIndex = 7;
            lblHargaProduk.Text = "Rp190.890";
            lblHargaProduk.Click += lblHargaProduk_Click;
            // 
            // lblTanggalTangkap
            // 
            lblTanggalTangkap.AutoSize = true;
            lblTanggalTangkap.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalTangkap.Location = new Point(64, 289);
            lblTanggalTangkap.Name = "lblTanggalTangkap";
            lblTanggalTangkap.Size = new Size(148, 22);
            lblTanggalTangkap.TabIndex = 8;
            lblTanggalTangkap.Text = "Tanggal Tangkap";
            // 
            // btnBeliProduk
            // 
            btnBeliProduk.BackColor = Color.Turquoise;
            btnBeliProduk.FlatAppearance.BorderSize = 0;
            btnBeliProduk.FlatStyle = FlatStyle.Flat;
            btnBeliProduk.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeliProduk.Location = new Point(606, 283);
            btnBeliProduk.Name = "btnBeliProduk";
            btnBeliProduk.Size = new Size(148, 32);
            btnBeliProduk.TabIndex = 11;
            btnBeliProduk.Text = "Beli";
            btnBeliProduk.UseVisualStyleBackColor = false;
            btnBeliProduk.Click += btnBeliProduk_Click;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStok.Location = new Point(609, 216);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(34, 16);
            lblStok.TabIndex = 12;
            lblStok.Text = "Stok";
            // 
            // counterStokProduk
            // 
            counterStokProduk.AutoSize = true;
            counterStokProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counterStokProduk.Location = new Point(731, 216);
            counterStokProduk.Name = "counterStokProduk";
            counterStokProduk.Size = new Size(23, 16);
            counterStokProduk.TabIndex = 13;
            counterStokProduk.Text = "00";
            // 
            // lblJumlahBeli
            // 
            lblJumlahBeli.AutoSize = true;
            lblJumlahBeli.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahBeli.Location = new Point(609, 245);
            lblJumlahBeli.Name = "lblJumlahBeli";
            lblJumlahBeli.Size = new Size(76, 16);
            lblJumlahBeli.TabIndex = 14;
            lblJumlahBeli.Text = "Jumlah beli";
            // 
            // textBoxJumlahBeli
            // 
            textBoxJumlahBeli.Location = new Point(726, 243);
            textBoxJumlahBeli.Name = "textBoxJumlahBeli";
            textBoxJumlahBeli.Size = new Size(28, 23);
            textBoxJumlahBeli.TabIndex = 15;
            // 
            // fillGrade
            // 
            fillGrade.AutoSize = true;
            fillGrade.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fillGrade.Location = new Point(248, 260);
            fillGrade.Name = "fillGrade";
            fillGrade.Size = new Size(70, 22);
            fillGrade.TabIndex = 16;
            fillGrade.Text = "[grade]";
            fillGrade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fillTanggal
            // 
            fillTanggal.AutoSize = true;
            fillTanggal.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fillTanggal.Location = new Point(248, 289);
            fillTanggal.Name = "fillTanggal";
            fillTanggal.Size = new Size(163, 22);
            fillTanggal.TabIndex = 17;
            fillTanggal.Text = "[tanggal tangkap]";
            // 
            // titleJenis
            // 
            titleJenis.AutoSize = true;
            titleJenis.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleJenis.Location = new Point(64, 148);
            titleJenis.Name = "titleJenis";
            titleJenis.Size = new Size(125, 44);
            titleJenis.TabIndex = 18;
            titleJenis.Text = "[jenis]";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleJenis);
            Controls.Add(fillTanggal);
            Controls.Add(fillGrade);
            Controls.Add(textBoxJumlahBeli);
            Controls.Add(lblJumlahBeli);
            Controls.Add(counterStokProduk);
            Controls.Add(lblStok);
            Controls.Add(btnBeliProduk);
            Controls.Add(lblTanggalTangkap);
            Controls.Add(lblHargaProduk);
            Controls.Add(lblGradeProduk);
            Controls.Add(titleKategori);
            Controls.Add(titleProduk);
            Controls.Add(btnKembaliProduk);
            Name = "ProductPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembaliProduk;
        private Label titleProduk;
        private Label lblSpesifikasiProduk;
        private Label lblJenis;
        private Label titleKategori;
        private Label lblGradeProduk;
        private Label lblHargaProduk;
        private Label lblTanggalTangkap;
        private Button btnBeliProduk;
        private Label lblStok;
        private Label counterStokProduk;
        private Label lblJumlahBeli;
        private TextBox textBoxJumlahBeli;
        private Label fillGrade;
        private Label fillTanggal;
        private Label titleJenis;
    }
}