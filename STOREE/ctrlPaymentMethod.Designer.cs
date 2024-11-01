namespace Store
{
    partial class ctrlPaymentMethod
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
            this.pnlPaymentOnDelivery = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbPaymentOnDelivery = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txtCVC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpiration = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCard = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlPaymentOnDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaymentOnDelivery
            // 
            this.pnlPaymentOnDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentOnDelivery.Controls.Add(this.pictureBox2);
            this.pnlPaymentOnDelivery.Controls.Add(this.label5);
            this.pnlPaymentOnDelivery.Controls.Add(this.label4);
            this.pnlPaymentOnDelivery.Controls.Add(this.pictureBox1);
            this.pnlPaymentOnDelivery.Controls.Add(this.rbPaymentOnDelivery);
            this.pnlPaymentOnDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaymentOnDelivery.Location = new System.Drawing.Point(0, 206);
            this.pnlPaymentOnDelivery.Name = "pnlPaymentOnDelivery";
            this.pnlPaymentOnDelivery.Size = new System.Drawing.Size(800, 55);
            this.pnlPaymentOnDelivery.TabIndex = 3;
            this.pnlPaymentOnDelivery.Click += new System.EventHandler(this.PaymentOnDelivery_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Store.Properties.Resources.line_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(90, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(684, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment on delivery selected.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment is made upon delivery. You will be given a warning if you do not receive " +
    "the order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.cash_on_delivery_2_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rbPaymentOnDelivery
            // 
            this.rbPaymentOnDelivery.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rbPaymentOnDelivery.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPaymentOnDelivery.CheckedState.BorderThickness = 0;
            this.rbPaymentOnDelivery.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPaymentOnDelivery.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPaymentOnDelivery.CheckedState.InnerOffset = -4;
            this.rbPaymentOnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rbPaymentOnDelivery.Image = global::Store.Properties.Resources.cash_on_delivery_1_;
            this.rbPaymentOnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPaymentOnDelivery.Location = new System.Drawing.Point(12, 12);
            this.rbPaymentOnDelivery.Name = "rbPaymentOnDelivery";
            this.rbPaymentOnDelivery.Size = new System.Drawing.Size(203, 38);
            this.rbPaymentOnDelivery.TabIndex = 0;
            this.rbPaymentOnDelivery.Text = "Payment on delivery";
            this.rbPaymentOnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPaymentOnDelivery.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPaymentOnDelivery.UncheckedState.BorderThickness = 2;
            this.rbPaymentOnDelivery.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPaymentOnDelivery.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPaymentOnDelivery.Click += new System.EventHandler(this.PaymentOnDelivery_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.txtCVC);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtExpiration);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtCardNumber);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.rbCard);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(800, 206);
            this.pnlCard.TabIndex = 2;
            this.pnlCard.Click += new System.EventHandler(this.Card_Click);
            // 
            // txtCVC
            // 
            this.txtCVC.Animated = true;
            this.txtCVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCVC.DefaultText = "";
            this.txtCVC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCVC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCVC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCVC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCVC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCVC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCVC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCVC.IconRight = global::Store.Properties.Resources.security;
            this.txtCVC.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtCVC.Location = new System.Drawing.Point(317, 159);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.PasswordChar = '\0';
            this.txtCVC.PlaceholderText = "CVC";
            this.txtCVC.SelectedText = "";
            this.txtCVC.Size = new System.Drawing.Size(175, 39);
            this.txtCVC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CVC";
            // 
            // txtExpiration
            // 
            this.txtExpiration.Animated = true;
            this.txtExpiration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpiration.DefaultText = "";
            this.txtExpiration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExpiration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExpiration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpiration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpiration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpiration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpiration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpiration.Location = new System.Drawing.Point(7, 159);
            this.txtExpiration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.PasswordChar = '\0';
            this.txtExpiration.PlaceholderText = "MM / YY";
            this.txtExpiration.SelectedText = "";
            this.txtExpiration.Size = new System.Drawing.Size(175, 39);
            this.txtExpiration.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expiration";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Animated = true;
            this.txtCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNumber.DefaultText = "";
            this.txtCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCardNumber.IconRight = global::Store.Properties.Resources.Credit_Cards_removebg_preview;
            this.txtCardNumber.IconRightSize = new System.Drawing.Size(140, 20);
            this.txtCardNumber.Location = new System.Drawing.Point(3, 92);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNumber.MaxLength = 20;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PasswordChar = '\0';
            this.txtCardNumber.PlaceholderText = "1234 1234 1234 1234";
            this.txtCardNumber.SelectedText = "";
            this.txtCardNumber.Size = new System.Drawing.Size(549, 39);
            this.txtCardNumber.TabIndex = 3;
            this.txtCardNumber.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number";
            // 
            // rbCard
            // 
            this.rbCard.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rbCard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCard.CheckedState.BorderThickness = 0;
            this.rbCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCard.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCard.CheckedState.InnerOffset = -4;
            this.rbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rbCard.Image = global::Store.Properties.Resources.credit_card_3_;
            this.rbCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCard.Location = new System.Drawing.Point(12, 12);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(100, 42);
            this.rbCard.TabIndex = 0;
            this.rbCard.Text = "Card";
            this.rbCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCard.UncheckedState.BorderThickness = 2;
            this.rbCard.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbCard.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbCard.Click += new System.EventHandler(this.Card_Click);
            // 
            // ctrlPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPaymentOnDelivery);
            this.Controls.Add(this.pnlCard);
            this.Name = "ctrlPaymentMethod";
            this.Size = new System.Drawing.Size(800, 263);
            this.Load += new System.EventHandler(this.ctrlPaymentMethod_Load);
            this.pnlPaymentOnDelivery.ResumeLayout(false);
            this.pnlPaymentOnDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaymentOnDelivery;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rbPaymentOnDelivery;
        private System.Windows.Forms.Panel pnlCard;
        private Guna.UI2.WinForms.Guna2TextBox txtCVC;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtExpiration;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCardNumber;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rbCard;
    }
}
