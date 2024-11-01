namespace Store
{
    partial class frmEditCustomerData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnShow_Hide_Old = new System.Windows.Forms.Button();
            this.btnShow_Hide = new System.Windows.Forms.Button();
            this.btnShow_Hide_verification = new System.Windows.Forms.Button();
            this.pbMatchPasswordVerification = new System.Windows.Forms.PictureBox();
            this.pbMatchPassword = new System.Windows.Forms.PictureBox();
            this.tbOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbVerificationPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.chbPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlYourInfo = new System.Windows.Forms.Panel();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.chbYourInfo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.cbRegions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCities = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chbAddress = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatchPasswordVerification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatchPassword)).BeginInit();
            this.pnlYourInfo.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update customer information";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.btnShow_Hide_Old);
            this.pnlPassword.Controls.Add(this.btnShow_Hide);
            this.pnlPassword.Controls.Add(this.btnShow_Hide_verification);
            this.pnlPassword.Controls.Add(this.pbMatchPasswordVerification);
            this.pnlPassword.Controls.Add(this.pbMatchPassword);
            this.pnlPassword.Controls.Add(this.tbOldPassword);
            this.pnlPassword.Controls.Add(this.tbVerificationPassword);
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Controls.Add(this.chbPassword);
            this.pnlPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPassword.Location = new System.Drawing.Point(0, 64);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(1312, 210);
            this.pnlPassword.TabIndex = 1;
            this.pnlPassword.Click += new System.EventHandler(this.pnlPassword_Click);
            // 
            // btnShow_Hide_Old
            // 
            this.btnShow_Hide_Old.BackColor = System.Drawing.Color.White;
            this.btnShow_Hide_Old.FlatAppearance.BorderSize = 0;
            this.btnShow_Hide_Old.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShow_Hide_Old.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnShow_Hide_Old.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow_Hide_Old.Image = global::Store.Properties.Resources.show;
            this.btnShow_Hide_Old.Location = new System.Drawing.Point(316, 115);
            this.btnShow_Hide_Old.Name = "btnShow_Hide_Old";
            this.btnShow_Hide_Old.Size = new System.Drawing.Size(38, 29);
            this.btnShow_Hide_Old.TabIndex = 41;
            this.btnShow_Hide_Old.UseVisualStyleBackColor = false;
            this.btnShow_Hide_Old.Click += new System.EventHandler(this.btnShow_Hide_Click);
            // 
            // btnShow_Hide
            // 
            this.btnShow_Hide.BackColor = System.Drawing.Color.White;
            this.btnShow_Hide.FlatAppearance.BorderSize = 0;
            this.btnShow_Hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShow_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnShow_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow_Hide.Image = global::Store.Properties.Resources.show;
            this.btnShow_Hide.Location = new System.Drawing.Point(740, 115);
            this.btnShow_Hide.Name = "btnShow_Hide";
            this.btnShow_Hide.Size = new System.Drawing.Size(38, 29);
            this.btnShow_Hide.TabIndex = 40;
            this.btnShow_Hide.UseVisualStyleBackColor = false;
            this.btnShow_Hide.Click += new System.EventHandler(this.btnShow_Hide_Click);
            // 
            // btnShow_Hide_verification
            // 
            this.btnShow_Hide_verification.BackColor = System.Drawing.Color.White;
            this.btnShow_Hide_verification.FlatAppearance.BorderSize = 0;
            this.btnShow_Hide_verification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShow_Hide_verification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnShow_Hide_verification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow_Hide_verification.Image = global::Store.Properties.Resources.show;
            this.btnShow_Hide_verification.Location = new System.Drawing.Point(1165, 115);
            this.btnShow_Hide_verification.Name = "btnShow_Hide_verification";
            this.btnShow_Hide_verification.Size = new System.Drawing.Size(38, 29);
            this.btnShow_Hide_verification.TabIndex = 39;
            this.btnShow_Hide_verification.UseVisualStyleBackColor = false;
            this.btnShow_Hide_verification.Click += new System.EventHandler(this.btnShow_Hide_Click);
            // 
            // pbMatchPasswordVerification
            // 
            this.pbMatchPasswordVerification.Image = global::Store.Properties.Resources.delete;
            this.pbMatchPasswordVerification.Location = new System.Drawing.Point(1214, 108);
            this.pbMatchPasswordVerification.Name = "pbMatchPasswordVerification";
            this.pbMatchPasswordVerification.Size = new System.Drawing.Size(34, 41);
            this.pbMatchPasswordVerification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMatchPasswordVerification.TabIndex = 33;
            this.pbMatchPasswordVerification.TabStop = false;
            this.pbMatchPasswordVerification.Visible = false;
            // 
            // pbMatchPassword
            // 
            this.pbMatchPassword.Image = global::Store.Properties.Resources.circle;
            this.pbMatchPassword.Location = new System.Drawing.Point(792, 110);
            this.pbMatchPassword.Name = "pbMatchPassword";
            this.pbMatchPassword.Size = new System.Drawing.Size(34, 41);
            this.pbMatchPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMatchPassword.TabIndex = 32;
            this.pbMatchPassword.TabStop = false;
            this.pbMatchPassword.Visible = false;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Animated = true;
            this.tbOldPassword.BorderRadius = 12;
            this.tbOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldPassword.DefaultText = "";
            this.tbOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldPassword.Location = new System.Drawing.Point(29, 106);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '●';
            this.tbOldPassword.PlaceholderText = "Old Password";
            this.tbOldPassword.SelectedText = "";
            this.tbOldPassword.Size = new System.Drawing.Size(331, 48);
            this.tbOldPassword.TabIndex = 31;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbVerificationPassword
            // 
            this.tbVerificationPassword.Animated = true;
            this.tbVerificationPassword.BorderRadius = 12;
            this.tbVerificationPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVerificationPassword.DefaultText = "";
            this.tbVerificationPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbVerificationPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbVerificationPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVerificationPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVerificationPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVerificationPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbVerificationPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVerificationPassword.Location = new System.Drawing.Point(877, 106);
            this.tbVerificationPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVerificationPassword.Name = "tbVerificationPassword";
            this.tbVerificationPassword.PasswordChar = '●';
            this.tbVerificationPassword.PlaceholderText = "Verification password";
            this.tbVerificationPassword.SelectedText = "";
            this.tbVerificationPassword.Size = new System.Drawing.Size(331, 48);
            this.tbVerificationPassword.TabIndex = 30;
            this.tbVerificationPassword.UseSystemPasswordChar = true;
            this.tbVerificationPassword.TextChanged += new System.EventHandler(this.tbVerificationPassword_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.BorderRadius = 12;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(453, 106);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(331, 48);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // chbPassword
            // 
            this.chbPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbPassword.CheckedState.BorderRadius = 0;
            this.chbPassword.CheckedState.BorderThickness = 0;
            this.chbPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbPassword.Image = global::Store.Properties.Resources.reset_password;
            this.chbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbPassword.Location = new System.Drawing.Point(12, 6);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(150, 42);
            this.chbPassword.TabIndex = 0;
            this.chbPassword.Text = "     Password";
            this.chbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbPassword.UncheckedState.BorderRadius = 0;
            this.chbPassword.UncheckedState.BorderThickness = 0;
            this.chbPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbPassword.CheckedChanged += new System.EventHandler(this.chbGeneral_CheckedChanged);
            // 
            // pnlYourInfo
            // 
            this.pnlYourInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYourInfo.Controls.Add(this.tbFirstName);
            this.pnlYourInfo.Controls.Add(this.tbPhone);
            this.pnlYourInfo.Controls.Add(this.tbLastName);
            this.pnlYourInfo.Controls.Add(this.chbYourInfo);
            this.pnlYourInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlYourInfo.Location = new System.Drawing.Point(0, 274);
            this.pnlYourInfo.Name = "pnlYourInfo";
            this.pnlYourInfo.Size = new System.Drawing.Size(1312, 65);
            this.pnlYourInfo.TabIndex = 2;
            this.pnlYourInfo.Click += new System.EventHandler(this.pnlYourInfo_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderRadius = 12;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(29, 97);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(331, 48);
            this.tbFirstName.TabIndex = 30;
            // 
            // tbPhone
            // 
            this.tbPhone.BorderRadius = 12;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(877, 97);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderText = "Phone";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(331, 48);
            this.tbPhone.TabIndex = 32;
            // 
            // tbLastName
            // 
            this.tbLastName.BorderRadius = 12;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(453, 97);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(331, 48);
            this.tbLastName.TabIndex = 31;
            // 
            // chbYourInfo
            // 
            this.chbYourInfo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbYourInfo.CheckedState.BorderRadius = 0;
            this.chbYourInfo.CheckedState.BorderThickness = 0;
            this.chbYourInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbYourInfo.Image = global::Store.Properties.Resources.information;
            this.chbYourInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbYourInfo.Location = new System.Drawing.Point(12, 12);
            this.chbYourInfo.Name = "chbYourInfo";
            this.chbYourInfo.Size = new System.Drawing.Size(189, 56);
            this.chbYourInfo.TabIndex = 0;
            this.chbYourInfo.Text = "   Your Information";
            this.chbYourInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbYourInfo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbYourInfo.UncheckedState.BorderRadius = 0;
            this.chbYourInfo.UncheckedState.BorderThickness = 0;
            this.chbYourInfo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbYourInfo.CheckedChanged += new System.EventHandler(this.chbGeneral_CheckedChanged);
            // 
            // pnlAddress
            // 
            this.pnlAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddress.Controls.Add(this.cbRegions);
            this.pnlAddress.Controls.Add(this.cbCities);
            this.pnlAddress.Controls.Add(this.cbCountries);
            this.pnlAddress.Controls.Add(this.chbAddress);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 339);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(1312, 70);
            this.pnlAddress.TabIndex = 3;
            this.pnlAddress.Click += new System.EventHandler(this.pnlAddress_Click);
            // 
            // cbRegions
            // 
            this.cbRegions.BackColor = System.Drawing.Color.Transparent;
            this.cbRegions.BorderRadius = 12;
            this.cbRegions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRegions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRegions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRegions.ItemHeight = 30;
            this.cbRegions.Items.AddRange(new object[] {
            "Select Region"});
            this.cbRegions.Location = new System.Drawing.Point(877, 99);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(349, 36);
            this.cbRegions.StartIndex = 0;
            this.cbRegions.TabIndex = 33;
            // 
            // cbCities
            // 
            this.cbCities.BackColor = System.Drawing.Color.Transparent;
            this.cbCities.BorderRadius = 12;
            this.cbCities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCities.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCities.ItemHeight = 30;
            this.cbCities.Items.AddRange(new object[] {
            "Select City"});
            this.cbCities.Location = new System.Drawing.Point(435, 99);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(349, 36);
            this.cbCities.StartIndex = 0;
            this.cbCities.TabIndex = 32;
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.cbCities_SelectedIndexChanged);
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderRadius = 12;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Items.AddRange(new object[] {
            "Select Country"});
            this.cbCountries.Location = new System.Drawing.Point(29, 99);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(349, 36);
            this.cbCountries.StartIndex = 0;
            this.cbCountries.TabIndex = 31;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // chbAddress
            // 
            this.chbAddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAddress.CheckedState.BorderRadius = 0;
            this.chbAddress.CheckedState.BorderThickness = 0;
            this.chbAddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAddress.Image = global::Store.Properties.Resources.address;
            this.chbAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbAddress.Location = new System.Drawing.Point(12, 12);
            this.chbAddress.Name = "chbAddress";
            this.chbAddress.Size = new System.Drawing.Size(136, 56);
            this.chbAddress.TabIndex = 0;
            this.chbAddress.Text = "Address";
            this.chbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbAddress.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAddress.UncheckedState.BorderRadius = 0;
            this.chbAddress.UncheckedState.BorderThickness = 0;
            this.chbAddress.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAddress.CheckedChanged += new System.EventHandler(this.chbGeneral_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lblWarning);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 326);
            this.panel2.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 23;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(295, 221);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(556, 49);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = " UPDATE NOW";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(102)))), ((int)(((byte)(1)))));
            this.lblWarning.Location = new System.Drawing.Point(12, 102);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(849, 25);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "* Warning: Your basic information and address will be modified for all accounts l" +
    "inked to this email";
            this.lblWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(102)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "* To update any section, you must select it";
            // 
            // frmEditCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlYourInfo);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditCustomerData";
            this.Text = "frmEditCustomerData";
            this.Load += new System.EventHandler(this.frmEditCustomerData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatchPasswordVerification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatchPassword)).EndInit();
            this.pnlYourInfo.ResumeLayout(false);
            this.pnlAddress.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbOldPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbVerificationPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Panel pnlYourInfo;
        private Guna.UI2.WinForms.Guna2CheckBox chbYourInfo;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private System.Windows.Forms.Panel pnlAddress;
        private Guna.UI2.WinForms.Guna2CheckBox chbAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cbRegions;
        private Guna.UI2.WinForms.Guna2ComboBox cbCities;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.PictureBox pbMatchPassword;
        private System.Windows.Forms.PictureBox pbMatchPasswordVerification;
        private System.Windows.Forms.Button btnShow_Hide_verification;
        private System.Windows.Forms.Button btnShow_Hide_Old;
        private System.Windows.Forms.Button btnShow_Hide;
    }
}