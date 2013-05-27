namespace AutoCompany
{
    partial class Catalog
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
            this.CarPicture = new System.Windows.Forms.PictureBox();
            this.PervBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CarSpecifics = new System.Windows.Forms.RichTextBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarPicture
            // 
            this.CarPicture.Location = new System.Drawing.Point(26, 13);
            this.CarPicture.Name = "CarPicture";
            this.CarPicture.Size = new System.Drawing.Size(460, 300);
            this.CarPicture.TabIndex = 0;
            this.CarPicture.TabStop = false;
            // 
            // PervBtn
            // 
            this.PervBtn.Location = new System.Drawing.Point(26, 323);
            this.PervBtn.Name = "PervBtn";
            this.PervBtn.Size = new System.Drawing.Size(125, 46);
            this.PervBtn.TabIndex = 1;
            this.PervBtn.Text = "Before";
            this.PervBtn.UseVisualStyleBackColor = true;
            this.PervBtn.Click += new System.EventHandler(this.PervBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(220, 323);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(125, 46);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CarSpecifics
            // 
            this.CarSpecifics.Location = new System.Drawing.Point(28, 19);
            this.CarSpecifics.Name = "CarSpecifics";
            this.CarSpecifics.ReadOnly = true;
            this.CarSpecifics.Size = new System.Drawing.Size(142, 197);
            this.CarSpecifics.TabIndex = 3;
            this.CarSpecifics.Text = "";
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::AutoCompany.Properties.Resources.LOGO;
            this.LogoBox.Location = new System.Drawing.Point(555, 13);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(215, 153);
            this.LogoBox.TabIndex = 4;
            this.LogoBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CarSpecifics);
            this.groupBox1.Location = new System.Drawing.Point(555, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details:";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PervBtn);
            this.Controls.Add(this.CarPicture);
            this.Name = "Catalog";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CarPicture;
        private System.Windows.Forms.Button PervBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.RichTextBox CarSpecifics;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}