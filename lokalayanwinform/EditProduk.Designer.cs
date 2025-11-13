namespace lokalayanwinform
{
    partial class EditProduk
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
            titleEdit = new Label();
            lblKategori = new Label();
            lblJenis = new Label();
            lblGrade = new Label();
            lblHarga = new Label();
            lblStok = new Label();
            txtTanggal = new Label();
            textBoxKategori = new TextBox();
            textBoxJenis = new TextBox();
            textBoxGrade = new TextBox();
            textBoxHarga = new TextBox();
            textBoxStok = new TextBox();
            textBoxTanggal = new TextBox();
            dtgrProduk = new DataGridView();
            btnTambahProduk = new Button();
            btnPerbarahuiProduk = new Button();
            btnHapusProduk = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgrProduk).BeginInit();
            SuspendLayout();
            // 
            // titleEdit
            // 
            titleEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleEdit.AutoSize = true;
            titleEdit.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleEdit.Location = new Point(284, 41);
            titleEdit.Name = "titleEdit";
            titleEdit.Size = new Size(254, 44);
            titleEdit.TabIndex = 0;
            titleEdit.Text = "EDIT PRODUK";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(66, 109);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(59, 16);
            lblKategori.TabIndex = 1;
            lblKategori.Text = "Kategori";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJenis.Location = new Point(66, 135);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(37, 16);
            lblJenis.TabIndex = 2;
            lblJenis.Text = "Jenis";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(66, 161);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(42, 16);
            lblGrade.TabIndex = 3;
            lblGrade.Text = "Grade";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(66, 186);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(44, 16);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Harga";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStok.Location = new Point(66, 211);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(34, 16);
            lblStok.TabIndex = 5;
            lblStok.Text = "Stok";
            // 
            // txtTanggal
            // 
            txtTanggal.AutoSize = true;
            txtTanggal.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTanggal.Location = new Point(66, 236);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(110, 16);
            txtTanggal.TabIndex = 6;
            txtTanggal.Text = "Tanggal Tangkap";
            // 
            // textBoxKategori
            // 
            textBoxKategori.Location = new Point(197, 107);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(100, 23);
            textBoxKategori.TabIndex = 7;
            // 
            // textBoxJenis
            // 
            textBoxJenis.Location = new Point(197, 133);
            textBoxJenis.Name = "textBoxJenis";
            textBoxJenis.Size = new Size(100, 23);
            textBoxJenis.TabIndex = 8;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(197, 159);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(100, 23);
            textBoxGrade.TabIndex = 9;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(197, 184);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(100, 23);
            textBoxHarga.TabIndex = 10;
            // 
            // textBoxStok
            // 
            textBoxStok.Location = new Point(197, 209);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(100, 23);
            textBoxStok.TabIndex = 11;
            // 
            // textBoxTanggal
            // 
            textBoxTanggal.Location = new Point(197, 234);
            textBoxTanggal.Name = "textBoxTanggal";
            textBoxTanggal.Size = new Size(100, 23);
            textBoxTanggal.TabIndex = 12;
            // 
            // dtgrProduk
            // 
            dtgrProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrProduk.Location = new Point(66, 307);
            dtgrProduk.Name = "dtgrProduk";
            dtgrProduk.Size = new Size(662, 131);
            dtgrProduk.TabIndex = 13;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackColor = Color.Turquoise;
            btnTambahProduk.FlatAppearance.BorderSize = 0;
            btnTambahProduk.FlatStyle = FlatStyle.Flat;
            btnTambahProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahProduk.Location = new Point(396, 133);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(90, 90);
            btnTambahProduk.TabIndex = 14;
            btnTambahProduk.Text = "Tambah";
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // btnPerbarahuiProduk
            // 
            btnPerbarahuiProduk.BackColor = Color.Turquoise;
            btnPerbarahuiProduk.FlatAppearance.BorderSize = 0;
            btnPerbarahuiProduk.FlatStyle = FlatStyle.Flat;
            btnPerbarahuiProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerbarahuiProduk.ForeColor = SystemColors.ControlText;
            btnPerbarahuiProduk.Location = new Point(520, 135);
            btnPerbarahuiProduk.Name = "btnPerbarahuiProduk";
            btnPerbarahuiProduk.Size = new Size(90, 90);
            btnPerbarahuiProduk.TabIndex = 15;
            btnPerbarahuiProduk.Text = "Perbaharui";
            btnPerbarahuiProduk.UseVisualStyleBackColor = false;
            btnPerbarahuiProduk.Click += btnPerbarahuiProduk_Click;
            // 
            // btnHapusProduk
            // 
            btnHapusProduk.BackColor = Color.Turquoise;
            btnHapusProduk.FlatAppearance.BorderSize = 0;
            btnHapusProduk.FlatStyle = FlatStyle.Flat;
            btnHapusProduk.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapusProduk.Location = new Point(638, 133);
            btnHapusProduk.Name = "btnHapusProduk";
            btnHapusProduk.Size = new Size(90, 90);
            btnHapusProduk.TabIndex = 16;
            btnHapusProduk.Text = "Hapus";
            btnHapusProduk.UseVisualStyleBackColor = false;
            btnHapusProduk.Click += btnHapusProduk_Click;
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHapusProduk);
            Controls.Add(btnPerbarahuiProduk);
            Controls.Add(btnTambahProduk);
            Controls.Add(dtgrProduk);
            Controls.Add(textBoxTanggal);
            Controls.Add(textBoxStok);
            Controls.Add(textBoxHarga);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxJenis);
            Controls.Add(textBoxKategori);
            Controls.Add(txtTanggal);
            Controls.Add(lblStok);
            Controls.Add(lblHarga);
            Controls.Add(lblGrade);
            Controls.Add(lblJenis);
            Controls.Add(lblKategori);
            Controls.Add(titleEdit);
            Name = "EditProduk";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgrProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleEdit;
        private Label lblKategori;
        private Label lblJenis;
        private Label lblGrade;
        private Label lblHarga;
        private Label lblStok;
        private Label txtTanggal;
        private TextBox textBoxKategori;
        private TextBox textBoxJenis;
        private TextBox textBoxGrade;
        private TextBox textBoxHarga;
        private TextBox textBoxStok;
        private TextBox textBoxTanggal;
        private DataGridView dtgrProduk;
        private Button btnTambahProduk;
        private Button btnPerbarahuiProduk;
        private Button btnHapusProduk;
    }
}