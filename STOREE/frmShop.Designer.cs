namespace Store
{
    partial class frmShop
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cbStar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new Guna.UI2.WinForms.Guna2Button();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbManualFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpProductCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSubCategories = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlShowPages1 = new Store.ctrlShowPages();
            this.guna2Panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnlFilter);
            this.guna2Panel1.Controls.Add(this.flpProductCategories);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.flpProducts);
            this.guna2Panel1.Controls.Add(this.pnlTitle);
            this.guna2Panel1.Controls.Add(this.pnlSubCategories);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 12);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1289, 755);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cbStar);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.btnGo);
            this.pnlFilter.Controls.Add(this.txtTo);
            this.pnlFilter.Controls.Add(this.txtFrom);
            this.pnlFilter.Controls.Add(this.txtProductName);
            this.pnlFilter.Controls.Add(this.cbManualFilter);
            this.pnlFilter.Controls.Add(this.cbFilter);
            this.pnlFilter.Location = new System.Drawing.Point(13, 132);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1273, 54);
            this.pnlFilter.TabIndex = 0;
            this.pnlFilter.Visible = false;
            // 
            // cbStar
            // 
            this.cbStar.BackColor = System.Drawing.Color.Transparent;
            this.cbStar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStar.ItemHeight = 30;
            this.cbStar.Items.AddRange(new object[] {
            "None",
            "1 star",
            "2 star",
            "3 star",
            "4 star",
            "5 star"});
            this.cbStar.Location = new System.Drawing.Point(831, 5);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(134, 36);
            this.cbStar.StartIndex = 0;
            this.cbStar.TabIndex = 8;
            this.cbStar.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Store.Properties.Resources.Filter_1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter      ";
            // 
            // btnGo
            // 
            this.btnGo.BorderThickness = 1;
            this.btnGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGo.FillColor = System.Drawing.Color.White;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(1131, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(71, 46);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtTo
            // 
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Location = new System.Drawing.Point(948, 4);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderText = "Price to";
            this.txtTo.SelectedText = "";
            this.txtTo.Size = new System.Drawing.Size(168, 46);
            this.txtTo.TabIndex = 5;
            this.txtTo.Visible = false;
            // 
            // txtFrom
            // 
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.Location = new System.Drawing.Point(765, 4);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderText = "Price from";
            this.txtFrom.SelectedText = "";
            this.txtFrom.Size = new System.Drawing.Size(168, 46);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Visible = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(582, 4);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "Product name ";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(168, 46);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.Visible = false;
            // 
            // cbManualFilter
            // 
            this.cbManualFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbManualFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbManualFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManualFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbManualFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbManualFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbManualFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbManualFilter.ItemHeight = 30;
            this.cbManualFilter.Items.AddRange(new object[] {
            "Price",
            "Rating"});
            this.cbManualFilter.Location = new System.Drawing.Point(430, 5);
            this.cbManualFilter.Name = "cbManualFilter";
            this.cbManualFilter.Size = new System.Drawing.Size(146, 36);
            this.cbManualFilter.StartIndex = 0;
            this.cbManualFilter.TabIndex = 1;
            this.cbManualFilter.Visible = false;
            this.cbManualFilter.SelectedIndexChanged += new System.EventHandler(this.cbManualFilter_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Price: Low to High",
            "Price: High to Low",
            "Rating: Low to High",
            "Rating:  High to Low",
            "Manual"});
            this.cbFilter.Location = new System.Drawing.Point(184, 5);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(225, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // flpProductCategories
            // 
            this.flpProductCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flpProductCategories.Location = new System.Drawing.Point(16, 132);
            this.flpProductCategories.Margin = new System.Windows.Forms.Padding(0);
            this.flpProductCategories.Name = "flpProductCategories";
            this.flpProductCategories.Size = new System.Drawing.Size(1273, 54);
            this.flpProductCategories.TabIndex = 9;
            this.flpProductCategories.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ctrlShowPages1);
            this.panel1.Location = new System.Drawing.Point(10, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 80);
            this.panel1.TabIndex = 11;
            // 
            // flpProducts
            // 
            this.flpProducts.BackgroundImage = global::Store.Properties.Resources.in_stock_removebg_preview;
            this.flpProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpProducts.Location = new System.Drawing.Point(13, 189);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1273, 500);
            this.flpProducts.TabIndex = 10;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.panel2);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1289, 62);
            this.pnlTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Shop";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 723);
            this.panel2.TabIndex = 0;
            // 
            // pnlSubCategories
            // 
            this.pnlSubCategories.AutoScroll = true;
            this.pnlSubCategories.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(227)))));
            this.pnlSubCategories.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlSubCategories.Location = new System.Drawing.Point(13, 75);
            this.pnlSubCategories.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubCategories.Name = "pnlSubCategories";
            this.pnlSubCategories.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlSubCategories.Size = new System.Drawing.Size(1276, 53);
            this.pnlSubCategories.TabIndex = 8;
            // 
            // ctrlShowPages1
            // 
            this.ctrlShowPages1.AutoSize = true;
            this.ctrlShowPages1.Location = new System.Drawing.Point(358, 4);
            this.ctrlShowPages1.Name = "ctrlShowPages1";
            this.ctrlShowPages1.Size = new System.Drawing.Size(544, 70);
            this.ctrlShowPages1.TabIndex = 0;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 779);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShop";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "frmShop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpProductCategories;
        private Guna.UI2.WinForms.Guna2Panel pnlSubCategories;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel panel1;
        private ctrlShowPages ctrlShowPages1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbManualFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Guna.UI2.WinForms.Guna2Button btnGo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbStar;
    }
}