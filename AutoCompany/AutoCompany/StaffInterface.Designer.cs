namespace AutoCompany
{
    partial class StaffInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.TABLE = new System.Windows.Forms.DataGridView();
            this.CheckServis = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddCarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User logged in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogBtn.Location = new System.Drawing.Point(635, 143);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(149, 42);
            this.CatalogBtn.TabIndex = 2;
            this.CatalogBtn.Text = "Каталог";
            this.CatalogBtn.UseVisualStyleBackColor = true;
            this.CatalogBtn.Click += new System.EventHandler(this.CatalogBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCompany.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(635, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 125);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(8, 39);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(92, 23);
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Sales
            // 
            this.Sales.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(635, 203);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(149, 40);
            this.Sales.TabIndex = 5;
            this.Sales.Text = "Check Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // TABLE
            // 
            this.TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE.Location = new System.Drawing.Point(33, 143);
            this.TABLE.Name = "TABLE";
            this.TABLE.ReadOnly = true;
            this.TABLE.Size = new System.Drawing.Size(546, 243);
            this.TABLE.TabIndex = 6;
            // 
            // CheckServis
            // 
            this.CheckServis.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckServis.Location = new System.Drawing.Point(635, 259);
            this.CheckServis.Name = "CheckServis";
            this.CheckServis.Size = new System.Drawing.Size(149, 41);
            this.CheckServis.TabIndex = 7;
            this.CheckServis.Text = "Check Servis";
            this.CheckServis.UseVisualStyleBackColor = true;
            this.CheckServis.Click += new System.EventHandler(this.CheckServis_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(33, 110);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 27);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Visible = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarBtn.Location = new System.Drawing.Point(635, 307);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(149, 41);
            this.AddCarBtn.TabIndex = 9;
            this.AddCarBtn.Text = "Add Car";
            this.AddCarBtn.UseVisualStyleBackColor = true;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // StaffInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.AddCarBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CheckServis);
            this.Controls.Add(this.TABLE);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CatalogBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StaffInterface";
            this.Text = "StaffInterface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button Sales;
        public System.Windows.Forms.DataGridView TABLE;
        private System.Windows.Forms.Button CheckServis;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddCarBtn;
    }
}