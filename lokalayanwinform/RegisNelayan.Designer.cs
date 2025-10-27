namespace lokalayanwinform
{
    partial class RegisNelayan
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
            txtBoxLokasiNelayan = new TextBox();
            btnRegister = new Button();
            lblLokasiNelayan = new Label();
            titleRegistrasi = new Label();
            SuspendLayout();
            // 
            // txtBoxLokasiNelayan
            // 
            txtBoxLokasiNelayan.Location = new Point(357, 107);
            txtBoxLokasiNelayan.Name = "txtBoxLokasiNelayan";
            txtBoxLokasiNelayan.Size = new Size(159, 23);
            txtBoxLokasiNelayan.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.MediumTurquoise;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(284, 256);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(232, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblLokasiNelayan
            // 
            lblLokasiNelayan.AutoSize = true;
            lblLokasiNelayan.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLokasiNelayan.Location = new Point(284, 109);
            lblLokasiNelayan.Name = "lblLokasiNelayan";
            lblLokasiNelayan.Size = new Size(45, 16);
            lblLokasiNelayan.TabIndex = 18;
            lblLokasiNelayan.Text = "Lokasi";
            lblLokasiNelayan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleRegistrasi
            // 
            titleRegistrasi.AutoSize = true;
            titleRegistrasi.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleRegistrasi.Location = new Point(258, 45);
            titleRegistrasi.Name = "titleRegistrasi";
            titleRegistrasi.Size = new Size(279, 26);
            titleRegistrasi.TabIndex = 19;
            titleRegistrasi.Text = "Registrasi sebagai Nelayan";
            titleRegistrasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisNelayan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleRegistrasi);
            Controls.Add(lblLokasiNelayan);
            Controls.Add(txtBoxLokasiNelayan);
            Controls.Add(btnRegister);
            Name = "RegisNelayan";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxLokasiNelayan;
        private Label labelPassword;
        private Label nameLabel;
        private TextBox txtBoxPass;
        private TextBox txtBoxEmail;
        private Button btnRegister;
        private Label lblLokasiNelayan;
        private Label titleRegistrasi;
    }
}