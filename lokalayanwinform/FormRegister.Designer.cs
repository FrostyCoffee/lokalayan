namespace lokalayanwinform
{
    partial class FormRegister
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
            btnRegister = new Button();
            labelPassword = new Label();
            nameLabel = new Label();
            txtBoxPass = new TextBox();
            txtBoxEmail = new TextBox();
            lblNama = new Label();
            txtBoxNama = new TextBox();
            btnRadioPenjual = new RadioButton();
            titleRegistrasi = new Label();
            labelLogin = new LinkLabel();
            reqQuestin = new Label();
            SuspendLayout();
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
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(284, 190);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(67, 16);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(284, 149);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(41, 16);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Email";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(357, 188);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(159, 23);
            txtBoxPass.TabIndex = 7;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(357, 147);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(159, 23);
            txtBoxEmail.TabIndex = 6;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(284, 109);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(44, 16);
            lblNama.TabIndex = 11;
            lblNama.Text = "Nama";
            lblNama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxNama
            // 
            txtBoxNama.Location = new Point(357, 107);
            txtBoxNama.Name = "txtBoxNama";
            txtBoxNama.Size = new Size(159, 23);
            txtBoxNama.TabIndex = 10;
            // 
            // btnRadioPenjual
            // 
            btnRadioPenjual.AutoSize = true;
            btnRadioPenjual.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRadioPenjual.Location = new Point(272, 230);
            btnRadioPenjual.Name = "btnRadioPenjual";
            btnRadioPenjual.Size = new Size(266, 20);
            btnRadioPenjual.TabIndex = 12;
            btnRadioPenjual.TabStop = true;
            btnRadioPenjual.Text = "Klik jika anda mendaftar sebagai penjual";
            btnRadioPenjual.UseVisualStyleBackColor = true;
            btnRadioPenjual.CheckedChanged += btnRadioPenjual_CheckedChanged;
            // 
            // titleRegistrasi
            // 
            titleRegistrasi.AutoSize = true;
            titleRegistrasi.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleRegistrasi.Location = new Point(243, 45);
            titleRegistrasi.Name = "titleRegistrasi";
            titleRegistrasi.Size = new Size(309, 26);
            titleRegistrasi.TabIndex = 13;
            titleRegistrasi.Text = "Selamat Datang di LokaLayan";
            titleRegistrasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Montserrat", 8.25F);
            labelLogin.Location = new Point(436, 291);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(38, 15);
            labelLogin.TabIndex = 15;
            labelLogin.TabStop = true;
            labelLogin.Text = "Login";
            labelLogin.LinkClicked += labelLogin_LinkClicked;
            // 
            // reqQuestin
            // 
            reqQuestin.AutoSize = true;
            reqQuestin.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reqQuestin.Location = new Point(311, 291);
            reqQuestin.Name = "reqQuestin";
            reqQuestin.Size = new Size(125, 16);
            reqQuestin.TabIndex = 14;
            reqQuestin.Text = "Sudah punya akun?";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLogin);
            Controls.Add(reqQuestin);
            Controls.Add(titleRegistrasi);
            Controls.Add(btnRadioPenjual);
            Controls.Add(lblNama);
            Controls.Add(txtBoxNama);
            Controls.Add(labelPassword);
            Controls.Add(nameLabel);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxEmail);
            Controls.Add(btnRegister);
            Name = "FormRegister";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label labelPassword;
        private Label nameLabel;
        private TextBox txtBoxPass;
        private TextBox txtBoxEmail;
        private Label lblNama;
        private TextBox txtBoxNama;
        private RadioButton btnRadioPenjual;
        private Label titleRegistrasi;
        private LinkLabel labelLogin;
        private Label reqQuestin;
    }
}