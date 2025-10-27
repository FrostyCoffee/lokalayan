namespace lokalayanwinform
{
    partial class FormLogin
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
            btnLogin = new Button();
            titleLogin = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            nameLabel = new Label();
            labelPassword = new Label();
            reqQuestin = new Label();
            linkLabelRegis = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.MediumTurquoise;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(274, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // titleLogin
            // 
            titleLogin.AutoSize = true;
            titleLogin.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLogin.Location = new Point(243, 45);
            titleLogin.Name = "titleLogin";
            titleLogin.Size = new Size(309, 26);
            titleLogin.TabIndex = 1;
            titleLogin.Text = "Selamat Datang di LokaLayan";
            titleLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(274, 131);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(41, 16);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Email";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameLabel.Click += nameLabel_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(274, 172);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(67, 16);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            labelPassword.Click += label1_Click;
            // 
            // reqQuestin
            // 
            reqQuestin.AutoSize = true;
            reqQuestin.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reqQuestin.Location = new Point(274, 303);
            reqQuestin.Name = "reqQuestin";
            reqQuestin.Size = new Size(127, 16);
            reqQuestin.TabIndex = 6;
            reqQuestin.Text = "Belum punya akun?";
            reqQuestin.Click += label1_Click_1;
            // 
            // linkLabelRegis
            // 
            linkLabelRegis.AutoSize = true;
            linkLabelRegis.Font = new Font("Montserrat", 8.25F);
            linkLabelRegis.Location = new Point(407, 304);
            linkLabelRegis.Name = "linkLabelRegis";
            linkLabelRegis.Size = new Size(94, 15);
            linkLabelRegis.TabIndex = 7;
            linkLabelRegis.TabStop = true;
            linkLabelRegis.Text = "Daftar Sekarang";
            linkLabelRegis.LinkClicked += linkLabelRegis_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelRegis);
            Controls.Add(reqQuestin);
            Controls.Add(labelPassword);
            Controls.Add(nameLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(titleLogin);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label titleLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label nameLabel;
        private Label labelPassword;
        private Label reqQuestin;
        private LinkLabel linkLabelRegis;
    }
}