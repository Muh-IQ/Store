namespace Store
{
    partial class ctrlShowPages
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
            this.flpPages = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPages
            // 
            this.flpPages.AutoSize = true;
            this.flpPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPages.Location = new System.Drawing.Point(0, 0);
            this.flpPages.Name = "flpPages";
            this.flpPages.Size = new System.Drawing.Size(316, 55);
            this.flpPages.TabIndex = 0;
            // 
            // ctrlShowPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flpPages);
            this.Name = "ctrlShowPages";
            this.Size = new System.Drawing.Size(316, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPages;
    }
}
