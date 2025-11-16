namespace lokalayanwinform
{
    partial class PemesananPenjual
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
            titlePesananPenjual = new Label();
            dtgrCekPemesanan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgrCekPemesanan).BeginInit();
            SuspendLayout();
            // 
            // titlePesananPenjual
            // 
            titlePesananPenjual.AutoSize = true;
            titlePesananPenjual.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlePesananPenjual.Location = new Point(320, 50);
            titlePesananPenjual.Name = "titlePesananPenjual";
            titlePesananPenjual.Size = new Size(153, 26);
            titlePesananPenjual.TabIndex = 0;
            titlePesananPenjual.Text = "Pesanan anda";
            // 
            // dtgrCekPemesanan
            // 
            dtgrCekPemesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrCekPemesanan.Location = new Point(42, 117);
            dtgrCekPemesanan.Name = "dtgrCekPemesanan";
            dtgrCekPemesanan.Size = new Size(714, 276);
            dtgrCekPemesanan.TabIndex = 1;
            dtgrCekPemesanan.CellContentClick += dtgrCekPemesanan_CellContentClick;
            // 
            // PemesananPenjual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgrCekPemesanan);
            Controls.Add(titlePesananPenjual);
            Name = "PemesananPenjual";
            Text = "PemesananPenjual";
            ((System.ComponentModel.ISupportInitialize)dtgrCekPemesanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlePesananPenjual;
        private DataGridView dtgrCekPemesanan;
    }
}