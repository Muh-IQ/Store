namespace Store
{
    partial class ctrlProductShowInMainForm
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblProcudtName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.pbRating = new System.Windows.Forms.PictureBox();
            this.lblCountOfRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.Image = global::Store.Properties.Resources.iphone_12;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(266, 103);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.Controls_Click);
            // 
            // lblProcudtName
            // 
            this.lblProcudtName.AutoSize = true;
            this.lblProcudtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcudtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(130)))));
            this.lblProcudtName.Location = new System.Drawing.Point(4, 108);
            this.lblProcudtName.Name = "lblProcudtName";
            this.lblProcudtName.Size = new System.Drawing.Size(81, 20);
            this.lblProcudtName.TabIndex = 18;
            this.lblProcudtName.Text = "Iphone 12";
            this.lblProcudtName.Click += new System.EventHandler(this.Controls_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.lblProductPrice.Location = new System.Drawing.Point(174, 108);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(59, 20);
            this.lblProductPrice.TabIndex = 20;
            this.lblProductPrice.Text = "1200$";
            this.lblProductPrice.Click += new System.EventHandler(this.Controls_Click);
            // 
            // pbRating
            // 
            this.pbRating.Image = global::Store.Properties.Resources.satr_5_removebg_preview;
            this.pbRating.Location = new System.Drawing.Point(8, 153);
            this.pbRating.Name = "pbRating";
            this.pbRating.Size = new System.Drawing.Size(102, 30);
            this.pbRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRating.TabIndex = 21;
            this.pbRating.TabStop = false;
            this.pbRating.Click += new System.EventHandler(this.Controls_Click);
            // 
            // lblCountOfRating
            // 
            this.lblCountOfRating.AutoSize = true;
            this.lblCountOfRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOfRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.lblCountOfRating.Location = new System.Drawing.Point(126, 158);
            this.lblCountOfRating.Name = "lblCountOfRating";
            this.lblCountOfRating.Size = new System.Drawing.Size(33, 20);
            this.lblCountOfRating.TabIndex = 22;
            this.lblCountOfRating.Text = "(2)";
            this.lblCountOfRating.Click += new System.EventHandler(this.Controls_Click);
            // 
            // ctrlProductShowInMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCountOfRating);
            this.Controls.Add(this.pbRating);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProcudtName);
            this.Controls.Add(this.pbImage);
            this.Name = "ctrlProductShowInMainForm";
            this.Size = new System.Drawing.Size(266, 186);
            this.Click += new System.EventHandler(this.Controls_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblProcudtName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.PictureBox pbRating;
        private System.Windows.Forms.Label lblCountOfRating;
    }
}
