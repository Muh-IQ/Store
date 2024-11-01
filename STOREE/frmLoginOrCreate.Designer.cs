namespace Store
{
    partial class frmLoginOrCreate
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
            this.pnlCreateAccount = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlCreateAccount
            // 
            this.pnlCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.pnlCreateAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateAccount.Name = "pnlCreateAccount";
            this.pnlCreateAccount.Size = new System.Drawing.Size(550, 558);
            this.pnlCreateAccount.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin.Location = new System.Drawing.Point(550, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(550, 558);
            this.pnlLogin.TabIndex = 1;
            // 
            // frmLoginOrCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 558);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlCreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLoginOrCreate";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginOrCreate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateAccount;
        private System.Windows.Forms.Panel pnlLogin;
    }
}