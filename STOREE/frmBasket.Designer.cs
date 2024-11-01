namespace Store
{
    partial class frmBasket
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
            this.pnlInfoBasket = new System.Windows.Forms.Panel();
            this.lblInfoCards = new System.Windows.Forms.Label();
            this.lblBuyAllCards = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpBasketProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblSelectAllCards = new System.Windows.Forms.Label();
            this.pnlInfoBasket.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoBasket
            // 
            this.pnlInfoBasket.BackColor = System.Drawing.Color.White;
            this.pnlInfoBasket.Controls.Add(this.lblInfoCards);
            this.pnlInfoBasket.Controls.Add(this.lblBuyAllCards);
            this.pnlInfoBasket.Controls.Add(this.panel1);
            this.pnlInfoBasket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfoBasket.Location = new System.Drawing.Point(10, 641);
            this.pnlInfoBasket.Name = "pnlInfoBasket";
            this.pnlInfoBasket.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlInfoBasket.Size = new System.Drawing.Size(1274, 72);
            this.pnlInfoBasket.TabIndex = 0;
            // 
            // lblInfoCards
            // 
            this.lblInfoCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoCards.AutoSize = true;
            this.lblInfoCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblInfoCards.Location = new System.Drawing.Point(938, 24);
            this.lblInfoCards.Name = "lblInfoCards";
            this.lblInfoCards.Size = new System.Drawing.Size(236, 25);
            this.lblInfoCards.TabIndex = 19;
            this.lblInfoCards.Text = "Subtotal ( 0 Item) :  0.00 $";
            // 
            // lblBuyAllCards
            // 
            this.lblBuyAllCards.AutoSize = true;
            this.lblBuyAllCards.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyAllCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuyAllCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyAllCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblBuyAllCards.Location = new System.Drawing.Point(565, 24);
            this.lblBuyAllCards.Name = "lblBuyAllCards";
            this.lblBuyAllCards.Size = new System.Drawing.Size(123, 25);
            this.lblBuyAllCards.TabIndex = 18;
            this.lblBuyAllCards.Text = "Buy all cards";
            this.lblBuyAllCards.Click += new System.EventHandler(this.lblBuyAllCards_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 1);
            this.panel1.TabIndex = 0;
            // 
            // flpBasketProduct
            // 
            this.flpBasketProduct.AutoScroll = true;
            this.flpBasketProduct.BackColor = System.Drawing.Color.White;
            this.flpBasketProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBasketProduct.Location = new System.Drawing.Point(10, 59);
            this.flpBasketProduct.Name = "flpBasketProduct";
            this.flpBasketProduct.Size = new System.Drawing.Size(1274, 582);
            this.flpBasketProduct.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lblSelectAllCards);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1274, 49);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(565, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shopping Basket";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblDelete.Location = new System.Drawing.Point(23, 666);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(145, 25);
            this.lblDelete.TabIndex = 14;
            this.lblDelete.Text = "Delete all cards";
            this.lblDelete.Click += new System.EventHandler(this.lblDeleteAll_Click);
            // 
            // lblSelectAllCards
            // 
            this.lblSelectAllCards.AutoSize = true;
            this.lblSelectAllCards.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectAllCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAllCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblSelectAllCards.Location = new System.Drawing.Point(13, 13);
            this.lblSelectAllCards.Name = "lblSelectAllCards";
            this.lblSelectAllCards.Size = new System.Drawing.Size(144, 25);
            this.lblSelectAllCards.TabIndex = 15;
            this.lblSelectAllCards.Tag = "0";
            this.lblSelectAllCards.Text = "Select all cards";
            this.lblSelectAllCards.Click += new System.EventHandler(this.lblSelectAllCards_Click);
            // 
            // frmBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1294, 723);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.flpBasketProduct);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlInfoBasket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBasket";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.frmBasket_Shown_1);
            this.pnlInfoBasket.ResumeLayout(false);
            this.pnlInfoBasket.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoBasket;
        private System.Windows.Forms.FlowLayoutPanel flpBasketProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblBuyAllCards;
        private System.Windows.Forms.Label lblInfoCards;
        private System.Windows.Forms.Label lblSelectAllCards;
    }
}