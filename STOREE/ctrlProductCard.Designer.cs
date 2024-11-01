namespace Store
{
    partial class ctrlProductCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbSelect = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lblUnavailable = new System.Windows.Forms.Label();
            this.btnIncreaseCount = new System.Windows.Forms.Button();
            this.btnDecreaseCount = new System.Windows.Forms.Button();
            this.lbProductQuantity = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chbSelect);
            this.panel1.Controls.Add(this.lblUnavailable);
            this.panel1.Controls.Add(this.btnIncreaseCount);
            this.panel1.Controls.Add(this.btnDecreaseCount);
            this.panel1.Controls.Add(this.lbProductQuantity);
            this.panel1.Controls.Add(this.lblDelete);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(1245, 206);
            this.panel1.TabIndex = 2;
            // 
            // chbSelect
            // 
            this.chbSelect.Animated = true;
            this.chbSelect.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbSelect.CheckedState.BorderRadius = 2;
            this.chbSelect.CheckedState.BorderThickness = 0;
            this.chbSelect.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbSelect.Location = new System.Drawing.Point(9, 20);
            this.chbSelect.Name = "chbSelect";
            this.chbSelect.Size = new System.Drawing.Size(20, 20);
            this.chbSelect.TabIndex = 39;
            this.chbSelect.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbSelect.UncheckedState.BorderRadius = 2;
            this.chbSelect.UncheckedState.BorderThickness = 0;
            this.chbSelect.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbSelect.Click += new System.EventHandler(this.chbSelect_Click);
            // 
            // lblUnavailable
            // 
            this.lblUnavailable.AutoSize = true;
            this.lblUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.lblUnavailable.Location = new System.Drawing.Point(1073, 167);
            this.lblUnavailable.Name = "lblUnavailable";
            this.lblUnavailable.Size = new System.Drawing.Size(150, 29);
            this.lblUnavailable.TabIndex = 37;
            this.lblUnavailable.Text = "Unavailable";
            this.lblUnavailable.Visible = false;
            // 
            // btnIncreaseCount
            // 
            this.btnIncreaseCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnIncreaseCount.FlatAppearance.BorderSize = 0;
            this.btnIncreaseCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseCount.ForeColor = System.Drawing.Color.White;
            this.btnIncreaseCount.Location = new System.Drawing.Point(463, 161);
            this.btnIncreaseCount.Name = "btnIncreaseCount";
            this.btnIncreaseCount.Size = new System.Drawing.Size(38, 29);
            this.btnIncreaseCount.TabIndex = 36;
            this.btnIncreaseCount.Text = "+";
            this.btnIncreaseCount.UseVisualStyleBackColor = false;
            this.btnIncreaseCount.Click += new System.EventHandler(this.btnIncreaseCount_Click);
            // 
            // btnDecreaseCount
            // 
            this.btnDecreaseCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnDecreaseCount.FlatAppearance.BorderSize = 0;
            this.btnDecreaseCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseCount.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseCount.Location = new System.Drawing.Point(339, 161);
            this.btnDecreaseCount.Name = "btnDecreaseCount";
            this.btnDecreaseCount.Size = new System.Drawing.Size(38, 29);
            this.btnDecreaseCount.TabIndex = 35;
            this.btnDecreaseCount.Text = "-";
            this.btnDecreaseCount.UseVisualStyleBackColor = false;
            this.btnDecreaseCount.Click += new System.EventHandler(this.btnDecreaseCount_Click);
            // 
            // lbProductQuantity
            // 
            this.lbProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProductQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbProductQuantity.Location = new System.Drawing.Point(378, 162);
            this.lbProductQuantity.Name = "lbProductQuantity";
            this.lbProductQuantity.Size = new System.Drawing.Size(82, 28);
            this.lbProductQuantity.TabIndex = 34;
            this.lbProductQuantity.Text = "1";
            this.lbProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblDelete.Location = new System.Drawing.Point(533, 162);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(68, 25);
            this.lblDelete.TabIndex = 13;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblProductPrice.Location = new System.Drawing.Point(1084, 20);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(83, 29);
            this.lblProductPrice.TabIndex = 11;
            this.lblProductPrice.Text = "1200$";
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(329, 65);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(894, 80);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "ASUS Chromebook 14 CX1400CMA Full HD Chromebook (Intel Celeron N4020, 4GB RAM, 64" +
    "GB eMMC, Google Chrome OS)";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(329, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(211, 29);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "iphone 14 pro max";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImage.Image = global::Store.Properties.Resources.Iphone_14_removebg_preview;
            this.pbImage.Location = new System.Drawing.Point(40, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.pbImage.Size = new System.Drawing.Size(283, 196);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // ctrlProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Name = "ctrlProductCard";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Size = new System.Drawing.Size(1245, 207);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnIncreaseCount;
        private System.Windows.Forms.Button btnDecreaseCount;
        private System.Windows.Forms.Label lbProductQuantity;
        private System.Windows.Forms.Label lblUnavailable;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chbSelect;
    }
}
