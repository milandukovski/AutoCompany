namespace AutoCompany
{
    partial class Form1
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
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatalogBtn.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogBtn.Location = new System.Drawing.Point(387, 199);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(204, 55);
            this.CatalogBtn.TabIndex = 0;
            this.CatalogBtn.Text = "Каталог";
            this.CatalogBtn.UseVisualStyleBackColor = true;
            this.CatalogBtn.Click += new System.EventHandler(this.CatalogBtn_Click);
            this.CatalogBtn.MouseEnter += new System.EventHandler(this.CatalogBtn_MouseHover);
            this.CatalogBtn.MouseLeave += new System.EventHandler(this.CatalogBtn_MouseLeave);
            this.CatalogBtn.MouseHover += new System.EventHandler(this.CatalogBtn_MouseHover);
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(13, 199);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(204, 53);
            this.Login.TabIndex = 1;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            this.Login.MouseHover += new System.EventHandler(this.Login_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCompany.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 137);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CatalogBtn);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FINKI-MOTORS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

