namespace Store
{
    partial class ctrlShowComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowComment));
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbRating = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComment
            // 
            this.tbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComment.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbComment.Location = new System.Drawing.Point(0, 28);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComment.Size = new System.Drawing.Size(556, 43);
            this.tbComment.TabIndex = 0;
            this.tbComment.Text = resources.GetString("tbComment.Text");
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ali Taha  fdsf sd s fdsf";
            // 
            // pbRating
            // 
            this.pbRating.Image = global::Store.Properties.Resources.satr_5_removebg_preview;
            this.pbRating.Location = new System.Drawing.Point(447, 3);
            this.pbRating.Name = "pbRating";
            this.pbRating.Size = new System.Drawing.Size(98, 24);
            this.pbRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRating.TabIndex = 13;
            this.pbRating.TabStop = false;
            // 
            // ctrlShowComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbRating);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbComment);
            this.Name = "ctrlShowComment";
            this.Size = new System.Drawing.Size(556, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbRating;
    }
}
