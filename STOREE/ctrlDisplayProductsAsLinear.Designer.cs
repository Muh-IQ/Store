namespace Store
{
    partial class ctrlDisplayProductsAsLinear
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
            this.btnScrollRight = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnScrollLeft = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flpShowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnScrollRight
            // 
            this.btnScrollRight.Animated = true;
            this.btnScrollRight.BackColor = System.Drawing.Color.Transparent;
            this.btnScrollRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScrollRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScrollRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScrollRight.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScrollRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScrollRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnScrollRight.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnScrollRight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrollRight.ForeColor = System.Drawing.Color.White;
            this.btnScrollRight.Location = new System.Drawing.Point(1215, 63);
            this.btnScrollRight.Name = "btnScrollRight";
            this.btnScrollRight.Size = new System.Drawing.Size(44, 75);
            this.btnScrollRight.TabIndex = 8;
            this.btnScrollRight.Text = "> ";
            this.btnScrollRight.Click += new System.EventHandler(this.btnScrollRight_Click);
            // 
            // btnScrollLeft
            // 
            this.btnScrollLeft.Animated = true;
            this.btnScrollLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScrollLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScrollLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScrollLeft.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScrollLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScrollLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnScrollLeft.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnScrollLeft.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrollLeft.ForeColor = System.Drawing.Color.White;
            this.btnScrollLeft.Location = new System.Drawing.Point(0, 63);
            this.btnScrollLeft.Name = "btnScrollLeft";
            this.btnScrollLeft.Size = new System.Drawing.Size(44, 75);
            this.btnScrollLeft.TabIndex = 7;
            this.btnScrollLeft.Text = "<";
            this.btnScrollLeft.Visible = false;
            this.btnScrollLeft.Click += new System.EventHandler(this.btnScrollLeft_Click);
            // 
            // flpShowProducts
            // 
            this.flpShowProducts.AutoScroll = true;
            this.flpShowProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpShowProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpShowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShowProducts.Location = new System.Drawing.Point(0, 0);
            this.flpShowProducts.Name = "flpShowProducts";
            this.flpShowProducts.Size = new System.Drawing.Size(1260, 193);
            this.flpShowProducts.TabIndex = 6;
            this.flpShowProducts.WrapContents = false;
            this.flpShowProducts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flpShowProducts_Scroll);
            //this.flpShowProducts.MouseEnter += new System.EventHandler(this.flpShowProducts_MouseEnter);
            //this.flpShowProducts.MouseLeave += new System.EventHandler(this.flpShowProducts_MouseLeave);

            // 
            // ctrlDisplayProductsAsLinear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnScrollRight);
            this.Controls.Add(this.btnScrollLeft);
            this.Controls.Add(this.flpShowProducts);
            this.Name = "ctrlDisplayProductsAsLinear";
            this.Size = new System.Drawing.Size(1260, 193);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnScrollRight;
        private Guna.UI2.WinForms.Guna2GradientButton btnScrollLeft;
        private System.Windows.Forms.FlowLayoutPanel flpShowProducts;
    }
}
