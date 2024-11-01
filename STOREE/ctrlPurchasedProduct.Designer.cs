namespace Store
{
    partial class ctrlPurchasedProduct
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
            this.lblShippingDetails = new System.Windows.Forms.Label();
            this.lblPaymentBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfProductPurchased = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnlShippingDetails = new System.Windows.Forms.Panel();
            this.lblAddressDelivery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActualDeliveryDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExpectedDeliveryDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblShippingStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShippingCompany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRating = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostComment = new Guna.UI2.WinForms.Guna2Button();
            this.tbComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlShippingDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblShippingDetails);
            this.panel1.Controls.Add(this.lblPaymentBy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumberOfProductPurchased);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(1179, 200);
            this.panel1.TabIndex = 3;
            // 
            // lblShippingDetails
            // 
            this.lblShippingDetails.AutoSize = true;
            this.lblShippingDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShippingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(226)))));
            this.lblShippingDetails.Location = new System.Drawing.Point(1002, 123);
            this.lblShippingDetails.Name = "lblShippingDetails";
            this.lblShippingDetails.Size = new System.Drawing.Size(156, 22);
            this.lblShippingDetails.TabIndex = 22;
            this.lblShippingDetails.Tag = "0";
            this.lblShippingDetails.Text = "Shipping Details";
            this.lblShippingDetails.Click += new System.EventHandler(this.lblShippingDetails_Click);
            // 
            // lblPaymentBy
            // 
            this.lblPaymentBy.AutoSize = true;
            this.lblPaymentBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblPaymentBy.Location = new System.Drawing.Point(140, 167);
            this.lblPaymentBy.Name = "lblPaymentBy";
            this.lblPaymentBy.Size = new System.Drawing.Size(198, 22);
            this.lblPaymentBy.TabIndex = 21;
            this.lblPaymentBy.Text = "Payment On Delivery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(8, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Payment by :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblDate.Location = new System.Drawing.Point(1036, 167);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 22);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "2001/12/23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(846, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date of purchase : ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(741, 167);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 22);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "1200$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(615, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Price : ";
            // 
            // lblNumberOfProductPurchased
            // 
            this.lblNumberOfProductPurchased.AutoSize = true;
            this.lblNumberOfProductPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfProductPurchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblNumberOfProductPurchased.Location = new System.Drawing.Point(360, 167);
            this.lblNumberOfProductPurchased.Name = "lblNumberOfProductPurchased";
            this.lblNumberOfProductPurchased.Size = new System.Drawing.Size(206, 22);
            this.lblNumberOfProductPurchased.TabIndex = 14;
            this.lblNumberOfProductPurchased.Text = "(*) Purchased product";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblProductPrice.Location = new System.Drawing.Point(1059, 20);
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
            this.lbDescription.Size = new System.Drawing.Size(813, 80);
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
            this.pbImage.Image = global::Store.Properties.Resources.Iphone_14_removebg_preview;
            this.pbImage.Location = new System.Drawing.Point(40, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.pbImage.Size = new System.Drawing.Size(283, 152);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // pnlShippingDetails
            // 
            this.pnlShippingDetails.BackColor = System.Drawing.Color.White;
            this.pnlShippingDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlShippingDetails.Controls.Add(this.lblAddressDelivery);
            this.pnlShippingDetails.Controls.Add(this.label5);
            this.pnlShippingDetails.Controls.Add(this.lblActualDeliveryDate);
            this.pnlShippingDetails.Controls.Add(this.label9);
            this.pnlShippingDetails.Controls.Add(this.lblExpectedDeliveryDate);
            this.pnlShippingDetails.Controls.Add(this.label10);
            this.pnlShippingDetails.Controls.Add(this.lblShippingStatus);
            this.pnlShippingDetails.Controls.Add(this.label12);
            this.pnlShippingDetails.Controls.Add(this.lblTrackingNumber);
            this.pnlShippingDetails.Controls.Add(this.label8);
            this.pnlShippingDetails.Controls.Add(this.lblShippingCompany);
            this.pnlShippingDetails.Controls.Add(this.label7);
            this.pnlShippingDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShippingDetails.Location = new System.Drawing.Point(3, 202);
            this.pnlShippingDetails.Name = "pnlShippingDetails";
            this.pnlShippingDetails.Size = new System.Drawing.Size(1179, 160);
            this.pnlShippingDetails.TabIndex = 7;
            this.pnlShippingDetails.Visible = false;
            // 
            // lblAddressDelivery
            // 
            this.lblAddressDelivery.AutoSize = true;
            this.lblAddressDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblAddressDelivery.Location = new System.Drawing.Point(618, 13);
            this.lblAddressDelivery.Name = "lblAddressDelivery";
            this.lblAddressDelivery.Size = new System.Drawing.Size(92, 22);
            this.lblAddressDelivery.TabIndex = 35;
            this.lblAddressDelivery.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(380, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address Delivery :";
            // 
            // lblActualDeliveryDate
            // 
            this.lblActualDeliveryDate.AutoSize = true;
            this.lblActualDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblActualDeliveryDate.Location = new System.Drawing.Point(1042, 123);
            this.lblActualDeliveryDate.Name = "lblActualDeliveryDate";
            this.lblActualDeliveryDate.Size = new System.Drawing.Size(92, 22);
            this.lblActualDeliveryDate.TabIndex = 33;
            this.lblActualDeliveryDate.Text = "Unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label9.Location = new System.Drawing.Point(804, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Actual Delivery Date :";
            // 
            // lblExpectedDeliveryDate
            // 
            this.lblExpectedDeliveryDate.AutoSize = true;
            this.lblExpectedDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblExpectedDeliveryDate.Location = new System.Drawing.Point(626, 65);
            this.lblExpectedDeliveryDate.Name = "lblExpectedDeliveryDate";
            this.lblExpectedDeliveryDate.Size = new System.Drawing.Size(92, 22);
            this.lblExpectedDeliveryDate.TabIndex = 31;
            this.lblExpectedDeliveryDate.Text = "Unknown";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label10.Location = new System.Drawing.Point(380, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Expected Delivery Date :";
            // 
            // lblShippingStatus
            // 
            this.lblShippingStatus.AutoSize = true;
            this.lblShippingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblShippingStatus.Location = new System.Drawing.Point(195, 65);
            this.lblShippingStatus.Name = "lblShippingStatus";
            this.lblShippingStatus.Size = new System.Drawing.Size(92, 22);
            this.lblShippingStatus.TabIndex = 29;
            this.lblShippingStatus.Text = "Unknown";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label12.Location = new System.Drawing.Point(9, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "Shipping Status :";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblTrackingNumber.Location = new System.Drawing.Point(204, 123);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(92, 22);
            this.lblTrackingNumber.TabIndex = 27;
            this.lblTrackingNumber.Text = "Unknown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(3, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tracking Number :";
            // 
            // lblShippingCompany
            // 
            this.lblShippingCompany.AutoSize = true;
            this.lblShippingCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblShippingCompany.Location = new System.Drawing.Point(204, 13);
            this.lblShippingCompany.Name = "lblShippingCompany";
            this.lblShippingCompany.Size = new System.Drawing.Size(92, 22);
            this.lblShippingCompany.TabIndex = 25;
            this.lblShippingCompany.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Shipping Company :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbRating);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnPostComment);
            this.panel3.Controls.Add(this.tbComment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 173);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rating : ";
            // 
            // cbRating
            // 
            this.cbRating.BackColor = System.Drawing.Color.Transparent;
            this.cbRating.BorderRadius = 7;
            this.cbRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRating.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRating.ItemHeight = 30;
            this.cbRating.Items.AddRange(new object[] {
            "No rating yet",
            "1 Star",
            "2 Star",
            "3 Star",
            "4 Star",
            "5 Star"});
            this.cbRating.Location = new System.Drawing.Point(114, 7);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(174, 36);
            this.cbRating.StartIndex = 0;
            this.cbRating.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Store.Properties.Resources.x;
            this.btnDelete.ImageSize = new System.Drawing.Size(22, 22);
            this.btnDelete.Location = new System.Drawing.Point(302, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Store.Properties.Resources.edit_button;
            this.btnEdit.ImageSize = new System.Drawing.Size(28, 28);
            this.btnEdit.Location = new System.Drawing.Point(363, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPostComment
            // 
            this.btnPostComment.Animated = true;
            this.btnPostComment.BorderRadius = 12;
            this.btnPostComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostComment.ForeColor = System.Drawing.Color.White;
            this.btnPostComment.Location = new System.Drawing.Point(977, 132);
            this.btnPostComment.Name = "btnPostComment";
            this.btnPostComment.Size = new System.Drawing.Size(180, 35);
            this.btnPostComment.TabIndex = 15;
            this.btnPostComment.Text = "Post Comment";
            this.btnPostComment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnPostComment.Click += new System.EventHandler(this.btnPostComment_Click);
            // 
            // tbComment
            // 
            this.tbComment.Animated = true;
            this.tbComment.AutoScroll = true;
            this.tbComment.BackColor = System.Drawing.Color.White;
            this.tbComment.BorderRadius = 9;
            this.tbComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComment.DefaultText = "";
            this.tbComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbComment.Location = new System.Drawing.Point(294, 7);
            this.tbComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.PasswordChar = '\0';
            this.tbComment.PlaceholderText = "Did not comment";
            this.tbComment.SelectedText = "";
            this.tbComment.Size = new System.Drawing.Size(863, 123);
            this.tbComment.TabIndex = 0;
            // 
            // ctrlPurchasedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlShippingDetails);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlPurchasedProduct";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Size = new System.Drawing.Size(1182, 533);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlShippingDetails.ResumeLayout(false);
            this.pnlShippingDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfProductPurchased;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaymentBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShippingDetails;
        private System.Windows.Forms.Panel pnlShippingDetails;
        private System.Windows.Forms.Label lblActualDeliveryDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExpectedDeliveryDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblShippingStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShippingCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbRating;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnPostComment;
        private Guna.UI2.WinForms.Guna2TextBox tbComment;
        private System.Windows.Forms.Label lblAddressDelivery;
        private System.Windows.Forms.Label label5;
    }
}
