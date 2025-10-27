namespace lokalayanwinform
{
    partial class RegisPembeli
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
            titleRegistrasiPembeli = new Label();
            lblAlamatPembeli = new Label();
            txtBoxAlamatPembeli = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // titleRegistrasiPembeli
            // 
            titleRegistrasiPembeli.AutoSize = true;
            titleRegistrasiPembeli.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleRegistrasiPembeli.Location = new Point(255, 64);
            titleRegistrasiPembeli.Name = "titleRegistrasiPembeli";
            titleRegistrasiPembeli.Size = new Size(281, 26);
            titleRegistrasiPembeli.TabIndex = 23;
            titleRegistrasiPembeli.Text = "Registrasi sebagai Pembeli";
            titleRegistrasiPembeli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlamatPembeli
            // 
            lblAlamatPembeli.AutoSize = true;
            lblAlamatPembeli.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlamatPembeli.Location = new Point(281, 128);
            lblAlamatPembeli.Name = "lblAlamatPembeli";
            lblAlamatPembeli.Size = new Size(51, 16);
            lblAlamatPembeli.TabIndex = 22;
            lblAlamatPembeli.Text = "Alamat";
            lblAlamatPembeli.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxAlamatPembeli
            // 
            txtBoxAlamatPembeli.Location = new Point(354, 126);
            txtBoxAlamatPembeli.Name = "txtBoxAlamatPembeli";
            txtBoxAlamatPembeli.Size = new Size(159, 23);
            txtBoxAlamatPembeli.TabIndex = 21;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.MediumTurquoise;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(281, 275);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(232, 23);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // RegisPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleRegistrasiPembeli);
            Controls.Add(lblAlamatPembeli);
            Controls.Add(txtBoxAlamatPembeli);
            Controls.Add(btnRegister);
            Name = "RegisPembeli";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrasiPembeli;
        private Label lblAlamatPembeli;
        private TextBox txtBoxAlamatPembeli;
        private Button btnRegister;
    }
}