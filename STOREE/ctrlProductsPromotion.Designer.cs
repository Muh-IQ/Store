namespace Store
{
    partial class ctrlProductsPromotion
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
            this.ctrlDisplayProductsAsLinear1 = new Store.ctrlDisplayProductsAsLinear();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlDisplayProductsAsLinear1
            // 
            this.ctrlDisplayProductsAsLinear1.Location = new System.Drawing.Point(1, 32);
            this.ctrlDisplayProductsAsLinear1.Name = "ctrlDisplayProductsAsLinear1";
            this.ctrlDisplayProductsAsLinear1.Size = new System.Drawing.Size(1260, 221);
            this.ctrlDisplayProductsAsLinear1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Promoted Products";
            // 
            // ctrlProductsPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlDisplayProductsAsLinear1);
            this.Name = "ctrlProductsPromotion";
            this.Size = new System.Drawing.Size(1262, 285);
            this.Load += new System.EventHandler(this.ctrlProductsPromotion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDisplayProductsAsLinear ctrlDisplayProductsAsLinear1;
        private System.Windows.Forms.Label label2;
    }
}
