namespace Store
{
    partial class ctrlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProcudtName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbRating = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblProcudtName);
            this.Panel1.Controls.Add(this.lblDescription);
            this.Panel1.Controls.Add(this.lblProductPrice);
            this.Panel1.Controls.Add(this.pbImage);
            this.Panel1.Controls.Add(this.lblStock);
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.pbRating);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(307, 245);
            this.Panel1.TabIndex = 0;
            this.Panel1.Click += new System.EventHandler(this.Product_Click);
            // 
            // lblProcudtName
            // 
            this.lblProcudtName.AutoSize = true;
            this.lblProcudtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcudtName.Location = new System.Drawing.Point(26, 145);
            this.lblProcudtName.Name = "lblProcudtName";
            this.lblProcudtName.Size = new System.Drawing.Size(81, 20);
            this.lblProcudtName.TabIndex = 9;
            this.lblProcudtName.Text = "Iphone 12";
            this.lblProcudtName.Click += new System.EventHandler(this.Product_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(24, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(270, 44);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Phone 14: Sleek design, powerful performance, advanced camera, and seamless Apple" +
    " ecosystem integration";
            this.lblDescription.Click += new System.EventHandler(this.Product_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(198, 145);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(54, 20);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "1200$";
            this.lblProductPrice.Click += new System.EventHandler(this.Product_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(181, 216);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(92, 20);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "12 in Stock";
            this.lblStock.Click += new System.EventHandler(this.Product_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Store.Properties.Resources.iphone_12;
            this.pbImage.Location = new System.Drawing.Point(75, 8);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(146, 122);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.Product_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Store.Properties.Resources.in_stock_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(139, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Product_Click);
            // 
            // pbRating
            // 
            this.pbRating.Image = global::Store.Properties.Resources.satr_5_removebg_preview;
            this.pbRating.Location = new System.Drawing.Point(24, 209);
            this.pbRating.Name = "pbRating";
            this.pbRating.Size = new System.Drawing.Size(83, 30);
            this.pbRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRating.TabIndex = 12;
            this.pbRating.TabStop = false;
            this.pbRating.Click += new System.EventHandler(this.Product_Click);
            // 
            // ctrlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.Panel1);
            this.Name = "ctrlProduct";
            this.Size = new System.Drawing.Size(307, 245);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProcudtName;
        private System.Windows.Forms.PictureBox pbRating;
    }
}
