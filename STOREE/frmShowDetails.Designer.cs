namespace Store
{
    partial class frmShowDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDetails));
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblShippingTime = new System.Windows.Forms.Label();
            this.btnCard = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockIn = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductname = new System.Windows.Forms.Label();
            this.btnDecreaseCount = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncreaseCount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbProductCount = new System.Windows.Forms.Label();
            this.pbFavorites = new System.Windows.Forms.PictureBox();
            this.pbShipping = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.flpImagesAndComment = new System.Windows.Forms.FlowLayoutPanel();
            this.lblShowMore = new System.Windows.Forms.Label();
            this.ctrlShowImagesForProduct1 = new Store.ctrlShowImagesForProduct();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShipping)).BeginInit();
            this.flpImagesAndComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Animated = true;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.BorderRadius = 15;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(183)))));
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(15, 310);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(556, 49);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "BUY NOW";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblShippingTime
            // 
            this.lblShippingTime.AutoSize = true;
            this.lblShippingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingTime.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.lblShippingTime.Location = new System.Drawing.Point(307, 391);
            this.lblShippingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingTime.Name = "lblShippingTime";
            this.lblShippingTime.Size = new System.Drawing.Size(173, 28);
            this.lblShippingTime.TabIndex = 23;
            this.lblShippingTime.Text = "1 BUSINESS DAY";
            // 
            // btnCard
            // 
            this.btnCard.Animated = true;
            this.btnCard.BackColor = System.Drawing.Color.Transparent;
            this.btnCard.BorderRadius = 15;
            this.btnCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.btnCard.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.ForeColor = System.Drawing.Color.White;
            this.btnCard.Location = new System.Drawing.Point(242, 237);
            this.btnCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(329, 49);
            this.btnCard.TabIndex = 14;
            this.btnCard.Text = "ADD TO CARD";
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(102, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Estimated Shipping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(102, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add to Favorites";
            // 
            // lblStockIn
            // 
            this.lblStockIn.AutoSize = true;
            this.lblStockIn.BackColor = System.Drawing.Color.Transparent;
            this.lblStockIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(186)))), ((int)(((byte)(69)))));
            this.lblStockIn.Location = new System.Drawing.Point(470, 8);
            this.lblStockIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockIn.Name = "lblStockIn";
            this.lblStockIn.Size = new System.Drawing.Size(88, 28);
            this.lblStockIn.TabIndex = 22;
            this.lblStockIn.Text = "Stock in";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(17, 189);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(126, 32);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "1285.99 $";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.lblDescription.Location = new System.Drawing.Point(27, 55);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(537, 127);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "iPhone 15 Pro Max : Cutting-edge tech, sleek design, unmatched performance\r\n";
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.BackColor = System.Drawing.Color.Transparent;
            this.lblProductname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.lblProductname.Location = new System.Drawing.Point(27, 8);
            this.lblProductname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(192, 28);
            this.lblProductname.TabIndex = 19;
            this.lblProductname.Text = "iPhone 15 Pro Max";
            // 
            // btnDecreaseCount
            // 
            this.btnDecreaseCount.Animated = true;
            this.btnDecreaseCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecreaseCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecreaseCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecreaseCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecreaseCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(183)))));
            this.btnDecreaseCount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseCount.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseCount.Location = new System.Drawing.Point(15, 241);
            this.btnDecreaseCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecreaseCount.Name = "btnDecreaseCount";
            this.btnDecreaseCount.Size = new System.Drawing.Size(44, 46);
            this.btnDecreaseCount.TabIndex = 17;
            this.btnDecreaseCount.Text = "-";
            this.btnDecreaseCount.Click += new System.EventHandler(this.btnDecreaseCount_Click);
            // 
            // btnIncreaseCount
            // 
            this.btnIncreaseCount.Animated = true;
            this.btnIncreaseCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncreaseCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncreaseCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncreaseCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncreaseCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(183)))));
            this.btnIncreaseCount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseCount.ForeColor = System.Drawing.Color.White;
            this.btnIncreaseCount.Location = new System.Drawing.Point(161, 241);
            this.btnIncreaseCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncreaseCount.Name = "btnIncreaseCount";
            this.btnIncreaseCount.Size = new System.Drawing.Size(44, 46);
            this.btnIncreaseCount.TabIndex = 0;
            this.btnIncreaseCount.Text = "+";
            this.btnIncreaseCount.Click += new System.EventHandler(this.btnIncreaseCount_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbProductCount);
            this.guna2Panel1.Controls.Add(this.btnBuy);
            this.guna2Panel1.Controls.Add(this.lblShippingTime);
            this.guna2Panel1.Controls.Add(this.btnCard);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.pbFavorites);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pbShipping);
            this.guna2Panel1.Controls.Add(this.lblStockIn);
            this.guna2Panel1.Controls.Add(this.lblPrice);
            this.guna2Panel1.Controls.Add(this.lblDescription);
            this.guna2Panel1.Controls.Add(this.lblProductname);
            this.guna2Panel1.Controls.Add(this.btnDecreaseCount);
            this.guna2Panel1.Controls.Add(this.btnIncreaseCount);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(595, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(678, 500);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lbProductCount
            // 
            this.lbProductCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProductCount.Font = new System.Drawing.Font("Arial", 18.95F);
            this.lbProductCount.Location = new System.Drawing.Point(60, 242);
            this.lbProductCount.Name = "lbProductCount";
            this.lbProductCount.Size = new System.Drawing.Size(100, 44);
            this.lbProductCount.TabIndex = 28;
            this.lbProductCount.Text = "1";
            this.lbProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFavorites
            // 
            this.pbFavorites.Image = ((System.Drawing.Image)(resources.GetObject("pbFavorites.Image")));
            this.pbFavorites.Location = new System.Drawing.Point(39, 443);
            this.pbFavorites.Margin = new System.Windows.Forms.Padding(4);
            this.pbFavorites.Name = "pbFavorites";
            this.pbFavorites.Size = new System.Drawing.Size(43, 39);
            this.pbFavorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavorites.TabIndex = 26;
            this.pbFavorites.TabStop = false;
            // 
            // pbShipping
            // 
            this.pbShipping.Image = ((System.Drawing.Image)(resources.GetObject("pbShipping.Image")));
            this.pbShipping.Location = new System.Drawing.Point(30, 380);
            this.pbShipping.Margin = new System.Windows.Forms.Padding(4);
            this.pbShipping.Name = "pbShipping";
            this.pbShipping.Size = new System.Drawing.Size(64, 47);
            this.pbShipping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShipping.TabIndex = 24;
            this.pbShipping.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.BorderRadius = 12;
            this.btnBack.BorderThickness = 1;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(84)))), ((int)(((byte)(93)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::Store.Properties.Resources.saman_pb_removebg_preview;
            this.btnBack.ImageSize = new System.Drawing.Size(60, 20);
            this.btnBack.Location = new System.Drawing.Point(2, 467);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 31);
            this.btnBack.TabIndex = 29;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flpImagesAndComment
            // 
            this.flpImagesAndComment.AutoScroll = true;
            this.flpImagesAndComment.Controls.Add(this.ctrlShowImagesForProduct1);
            this.flpImagesAndComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpImagesAndComment.Location = new System.Drawing.Point(0, 0);
            this.flpImagesAndComment.Name = "flpImagesAndComment";
            this.flpImagesAndComment.Size = new System.Drawing.Size(595, 460);
            this.flpImagesAndComment.TabIndex = 30;
            // 
            // lblShowMore
            // 
            this.lblShowMore.AutoSize = true;
            this.lblShowMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.lblShowMore.Location = new System.Drawing.Point(456, 467);
            this.lblShowMore.Name = "lblShowMore";
            this.lblShowMore.Size = new System.Drawing.Size(132, 25);
            this.lblShowMore.TabIndex = 31;
            this.lblShowMore.Text = "Show More ...";
            this.lblShowMore.Visible = false;
            this.lblShowMore.Click += new System.EventHandler(this.lblShowMore_Click);
            // 
            // ctrlShowImagesForProduct1
            // 
            this.ctrlShowImagesForProduct1.Location = new System.Drawing.Point(3, 3);
            this.ctrlShowImagesForProduct1.Name = "ctrlShowImagesForProduct1";
            this.ctrlShowImagesForProduct1.Size = new System.Drawing.Size(557, 328);
            this.ctrlShowImagesForProduct1.TabIndex = 0;
            // 
            // frmShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 500);
            this.Controls.Add(this.lblShowMore);
            this.Controls.Add(this.flpImagesAndComment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowDetails";
            this.Text = "Product details";
            this.Load += new System.EventHandler(this.frmShowDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShipping)).EndInit();
            this.flpImagesAndComment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private System.Windows.Forms.Label lblShippingTime;
        private Guna.UI2.WinForms.Guna2Button btnCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFavorites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbShipping;
        private System.Windows.Forms.Label lblStockIn;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProductname;
        private Guna.UI2.WinForms.Guna2Button btnDecreaseCount;
        private Guna.UI2.WinForms.Guna2Button btnIncreaseCount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbProductCount;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flpImagesAndComment;
        private ctrlShowImagesForProduct ctrlShowImagesForProduct1;
        private System.Windows.Forms.Label lblShowMore;
    }
}