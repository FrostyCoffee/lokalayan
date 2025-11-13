namespace lokalayanwinform
{
    partial class Katalog
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
            flpKatalog = new FlowLayoutPanel();
            titleKatalog = new Label();
            SuspendLayout();
            // 
            // flpKatalog
            // 
            flpKatalog.Location = new Point(71, 107);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(657, 295);
            flpKatalog.TabIndex = 0;
            // 
            // titleKatalog
            // 
            titleKatalog.AutoSize = true;
            titleKatalog.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleKatalog.Location = new Point(159, 35);
            titleKatalog.Name = "titleKatalog";
            titleKatalog.Size = new Size(485, 33);
            titleKatalog.TabIndex = 1;
            titleKatalog.Text = "Dapatkan Ikan dengan Harga Murah!";
            titleKatalog.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Katalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleKatalog);
            Controls.Add(flpKatalog);
            Name = "Katalog";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpKatalog;
        private Label titleKatalog;
    }
}