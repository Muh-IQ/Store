namespace Store
{
    partial class frmPayment
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
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblExpectedDeliveryTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPriceOfProducts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShippingCompany = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblYourAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpProductsInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDeliveryNotSupported = new System.Windows.Forms.Label();
            this.ctrlPaymentMethod1 = new Store.ctrlPaymentMethod();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 23;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(98, 908);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(556, 49);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "PAY NOW";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.lblDeliveryNotSupported);
            this.guna2Panel1.Controls.Add(this.lblExpectedDeliveryTime);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.lblDeliveryCost);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.lblTotalPriceOfProducts);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.cbShippingCompany);
            this.guna2Panel1.Controls.Add(this.lblYourAddress);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.lblTotalPrice);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.lblNumberOfProducts);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(807, 212);
            this.guna2Panel1.TabIndex = 19;
            // 
            // lblExpectedDeliveryTime
            // 
            this.lblExpectedDeliveryTime.AutoSize = true;
            this.lblExpectedDeliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedDeliveryTime.Location = new System.Drawing.Point(661, 123);
            this.lblExpectedDeliveryTime.Name = "lblExpectedDeliveryTime";
            this.lblExpectedDeliveryTime.Size = new System.Drawing.Size(88, 22);
            this.lblExpectedDeliveryTime.TabIndex = 12;
            this.lblExpectedDeliveryTime.Text = "2001/1/1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Expected delivery time :";
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryCost.Location = new System.Drawing.Point(569, 76);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(121, 22);
            this.lblDeliveryCost.TabIndex = 10;
            this.lblDeliveryCost.Text = "13999.999 $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Delivery cost  :";
            // 
            // lblTotalPriceOfProducts
            // 
            this.lblTotalPriceOfProducts.AutoSize = true;
            this.lblTotalPriceOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceOfProducts.Location = new System.Drawing.Point(248, 123);
            this.lblTotalPriceOfProducts.Name = "lblTotalPriceOfProducts";
            this.lblTotalPriceOfProducts.Size = new System.Drawing.Size(121, 22);
            this.lblTotalPriceOfProducts.TabIndex = 8;
            this.lblTotalPriceOfProducts.Text = "13999.999 $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total price of products  :";
            // 
            // cbShippingCompany
            // 
            this.cbShippingCompany.BackColor = System.Drawing.Color.Transparent;
            this.cbShippingCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShippingCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShippingCompany.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShippingCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShippingCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShippingCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbShippingCompany.ItemHeight = 30;
            this.cbShippingCompany.Location = new System.Drawing.Point(504, 18);
            this.cbShippingCompany.Name = "cbShippingCompany";
            this.cbShippingCompany.Size = new System.Drawing.Size(248, 36);
            this.cbShippingCompany.TabIndex = 6;
            this.cbShippingCompany.SelectedIndexChanged += new System.EventHandler(this.cbShippingCompany_SelectedIndexChanged);
            // 
            // lblYourAddress
            // 
            this.lblYourAddress.AutoSize = true;
            this.lblYourAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAddress.Location = new System.Drawing.Point(198, 168);
            this.lblYourAddress.Name = "lblYourAddress";
            this.lblYourAddress.Size = new System.Drawing.Size(266, 22);
            this.lblYourAddress.TabIndex = 5;
            this.lblYourAddress.Text = "Iraq - Baghdad - Al_Mansore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Delivery Address : ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(142, 76);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(121, 22);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "13999.999 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total price  :";
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfProducts.Location = new System.Drawing.Point(228, 32);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(32, 22);
            this.lblNumberOfProducts.TabIndex = 1;
            this.lblNumberOfProducts.Text = "13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of products  :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 26);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Store.Properties.Resources.Line_2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flpProductsInfo
            // 
            this.flpProductsInfo.AutoScroll = true;
            this.flpProductsInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpProductsInfo.Location = new System.Drawing.Point(0, 238);
            this.flpProductsInfo.Name = "flpProductsInfo";
            this.flpProductsInfo.Size = new System.Drawing.Size(807, 388);
            this.flpProductsInfo.TabIndex = 21;
            // 
            // lblDeliveryNotSupported
            // 
            this.lblDeliveryNotSupported.AutoSize = true;
            this.lblDeliveryNotSupported.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryNotSupported.ForeColor = System.Drawing.Color.Red;
            this.lblDeliveryNotSupported.Location = new System.Drawing.Point(169, 9);
            this.lblDeliveryNotSupported.Name = "lblDeliveryNotSupported";
            this.lblDeliveryNotSupported.Size = new System.Drawing.Size(398, 25);
            this.lblDeliveryNotSupported.TabIndex = 13;
            this.lblDeliveryNotSupported.Text = "Delivery is not supported for this country";
            this.lblDeliveryNotSupported.Visible = false;
            // 
            // ctrlPaymentMethod1
            // 
            this.ctrlPaymentMethod1.Location = new System.Drawing.Point(2, 632);
            this.ctrlPaymentMethod1.Name = "ctrlPaymentMethod1";
            this.ctrlPaymentMethod1.Size = new System.Drawing.Size(800, 263);
            this.ctrlPaymentMethod1.TabIndex = 18;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 963);
            this.Controls.Add(this.flpProductsInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrlPaymentMethod1);
            this.Controls.Add(this.btnPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 1010);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(825, 1010);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.Shown += new System.EventHandler(this.frmPayment_Shown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPay;
        private ctrlPaymentMethod ctrlPaymentMethod1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYourAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpProductsInfo;
        private System.Windows.Forms.Label lblTotalPriceOfProducts;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbShippingCompany;
        private System.Windows.Forms.Label lblExpectedDeliveryTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeliveryNotSupported;
    }
}