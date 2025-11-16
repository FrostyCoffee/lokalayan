namespace lokalayanwinform
{
    partial class Pemesanan
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
            TitlePemesanan = new Label();
            lblPembayaran = new Label();
            lblPengiriman = new Label();
            rdbTranfer = new RadioButton();
            rdbQris = new RadioButton();
            rdbPos = new RadioButton();
            rdbJne = new RadioButton();
            btnPesan = new Button();
            SuspendLayout();
            // 
            // TitlePemesanan
            // 
            TitlePemesanan.AutoSize = true;
            TitlePemesanan.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitlePemesanan.Location = new Point(263, 43);
            TitlePemesanan.Name = "TitlePemesanan";
            TitlePemesanan.Size = new Size(363, 33);
            TitlePemesanan.TabIndex = 0;
            TitlePemesanan.Text = "Selesaikan pembelian anda";
            // 
            // lblPembayaran
            // 
            lblPembayaran.AutoSize = true;
            lblPembayaran.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPembayaran.Location = new Point(111, 129);
            lblPembayaran.Name = "lblPembayaran";
            lblPembayaran.Size = new Size(185, 22);
            lblPembayaran.TabIndex = 1;
            lblPembayaran.Text = "Metode Pembayaran";
            // 
            // lblPengiriman
            // 
            lblPengiriman.AutoSize = true;
            lblPengiriman.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPengiriman.Location = new Point(552, 129);
            lblPengiriman.Name = "lblPengiriman";
            lblPengiriman.Size = new Size(194, 22);
            lblPengiriman.TabIndex = 2;
            lblPengiriman.Text = "Ekspedisi Pengiriman";
            // 
            // rdbTranfer
            // 
            rdbTranfer.AutoSize = true;
            rdbTranfer.Location = new Point(111, 164);
            rdbTranfer.Name = "rdbTranfer";
            rdbTranfer.Size = new Size(107, 20);
            rdbTranfer.TabIndex = 3;
            rdbTranfer.TabStop = true;
            rdbTranfer.Text = "Transfer Bank";
            rdbTranfer.UseVisualStyleBackColor = true;
            // 
            // rdbQris
            // 
            rdbQris.AutoSize = true;
            rdbQris.Location = new Point(112, 195);
            rdbQris.Name = "rdbQris";
            rdbQris.Size = new Size(55, 20);
            rdbQris.TabIndex = 4;
            rdbQris.TabStop = true;
            rdbQris.Text = "QRIS";
            rdbQris.UseVisualStyleBackColor = true;
            // 
            // rdbPos
            // 
            rdbPos.AutoSize = true;
            rdbPos.Location = new Point(552, 164);
            rdbPos.Name = "rdbPos";
            rdbPos.Size = new Size(110, 20);
            rdbPos.TabIndex = 5;
            rdbPos.TabStop = true;
            rdbPos.Text = "Pos Indonesia";
            rdbPos.UseVisualStyleBackColor = true;
            // 
            // rdbJne
            // 
            rdbJne.AutoSize = true;
            rdbJne.Location = new Point(552, 195);
            rdbJne.Name = "rdbJne";
            rdbJne.Size = new Size(49, 20);
            rdbJne.TabIndex = 6;
            rdbJne.TabStop = true;
            rdbJne.Text = "JNE";
            rdbJne.UseVisualStyleBackColor = true;
            // 
            // btnPesan
            // 
            btnPesan.BackColor = Color.Turquoise;
            btnPesan.FlatAppearance.BorderSize = 0;
            btnPesan.FlatStyle = FlatStyle.Flat;
            btnPesan.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesan.Location = new Point(342, 293);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(206, 46);
            btnPesan.TabIndex = 7;
            btnPesan.Text = "Buat Pesanan";
            btnPesan.UseVisualStyleBackColor = false;
            btnPesan.Click += btnPesan_Click;
            // 
            // Pemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 480);
            Controls.Add(btnPesan);
            Controls.Add(rdbJne);
            Controls.Add(rdbPos);
            Controls.Add(rdbQris);
            Controls.Add(rdbTranfer);
            Controls.Add(lblPengiriman);
            Controls.Add(lblPembayaran);
            Controls.Add(TitlePemesanan);
            Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Pemesanan";
            Text = "Pemesanan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitlePemesanan;
        private Label lblPembayaran;
        private Label lblPengiriman;
        private RadioButton rdbTranfer;
        private RadioButton rdbQris;
        private RadioButton rdbPos;
        private RadioButton rdbJne;
        private Button btnPesan;
    }
}