namespace Store
{
    partial class frmProfileMenu
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBasket = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblLogin_Or_Create = new System.Windows.Forms.Label();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.pbClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.Transparent;
            this.lblAccount.Location = new System.Drawing.Point(12, 18);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(82, 22);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.BackColor = System.Drawing.Color.Transparent;
            this.lblBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasket.ForeColor = System.Drawing.Color.Transparent;
            this.lblBasket.Location = new System.Drawing.Point(12, 71);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(71, 22);
            this.lblBasket.TabIndex = 1;
            this.lblBasket.Text = "Basket";
            this.lblBasket.Click += new System.EventHandler(this.lblBasket_Click);
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases.ForeColor = System.Drawing.Color.Transparent;
            this.lblPurchases.Location = new System.Drawing.Point(12, 124);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(104, 22);
            this.lblPurchases.TabIndex = 2;
            this.lblPurchases.Text = "Purchases";
            this.lblPurchases.Click += new System.EventHandler(this.lblPurchases_Click);
            // 
            // lblLogin_Or_Create
            // 
            this.lblLogin_Or_Create.AccessibleDescription = "";
            this.lblLogin_Or_Create.AccessibleName = "";
            this.lblLogin_Or_Create.AutoSize = true;
            this.lblLogin_Or_Create.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin_Or_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin_Or_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_Or_Create.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogin_Or_Create.Location = new System.Drawing.Point(12, 177);
            this.lblLogin_Or_Create.Name = "lblLogin_Or_Create";
            this.lblLogin_Or_Create.Size = new System.Drawing.Size(137, 22);
            this.lblLogin_Or_Create.TabIndex = 3;
            this.lblLogin_Or_Create.Text = "Login / Create";
            this.lblLogin_Or_Create.Click += new System.EventHandler(this.lblLogin_Or_Create_Click);
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lblSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.lblSignOut.Location = new System.Drawing.Point(17, 177);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(84, 22);
            this.lblSignOut.TabIndex = 4;
            this.lblSignOut.Text = "Sign out";
            this.lblSignOut.Click += new System.EventHandler(this.lblSignOut_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.pbClose.Image = global::Store.Properties.Resources.more;
            this.pbClose.ImageRotate = 0F;
            this.pbClose.Location = new System.Drawing.Point(59, 216);
            this.pbClose.Name = "pbClose";
            this.pbClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbClose.Size = new System.Drawing.Size(42, 42);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Store.Properties.Resources.Line_2_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(5, 164);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.panel1.Size = new System.Drawing.Size(144, 10);
            this.panel1.TabIndex = 5;
            // 
            // frmProfileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(161, 264);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSignOut);
            this.Controls.Add(this.lblLogin_Or_Create);
            this.Controls.Add(this.lblPurchases);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.lblAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfileMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmProfileMenu";
            this.Load += new System.EventHandler(this.frmProfileMenu_Load);
            this.MouseLeave += new System.EventHandler(this.frmProfileMenu_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Label lblLogin_Or_Create;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbClose;
    }
}