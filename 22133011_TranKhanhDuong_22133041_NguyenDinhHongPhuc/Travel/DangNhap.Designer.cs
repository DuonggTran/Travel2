namespace Travel
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.ErrorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelFollow = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkAccUser = new System.Windows.Forms.RadioButton();
            this.chkAccAdmin = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImageButtonFB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PBTwitter = new System.Windows.Forms.PictureBox();
            this.ImageButtonInsta = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProviderUsername
            // 
            this.ErrorProviderUsername.ContainerControl = this;
            // 
            // ErrorProviderPassword
            // 
            this.ErrorProviderPassword.ContainerControl = this;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.BorderRadius = 15;
            this.PanelLogin.Controls.Add(this.ImageButtonFB);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Controls.Add(this.LabelFollow);
            this.PanelLogin.Controls.Add(this.txtTenDangNhap);
            this.PanelLogin.Controls.Add(this.PBTwitter);
            this.PanelLogin.Controls.Add(this.ImageButtonInsta);
            this.PanelLogin.Controls.Add(this.chkAccUser);
            this.PanelLogin.Controls.Add(this.chkAccAdmin);
            this.PanelLogin.Controls.Add(this.btnDangNhap);
            this.PanelLogin.Controls.Add(this.txtMatKhau);
            this.PanelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin.Location = new System.Drawing.Point(-2, 3);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(504, 594);
            this.PanelLogin.TabIndex = 5;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelLogin.Location = new System.Drawing.Point(138, 60);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(237, 91);
            this.LabelLogin.TabIndex = 22;
            this.LabelLogin.Text = "Login";
            // 
            // LabelFollow
            // 
            this.LabelFollow.AutoSize = true;
            this.LabelFollow.Location = new System.Drawing.Point(160, 420);
            this.LabelFollow.Name = "LabelFollow";
            this.LabelFollow.Size = new System.Drawing.Size(194, 16);
            this.LabelFollow.TabIndex = 21;
            this.LabelFollow.Text = "----------------Follow Us----------------";
            this.LabelFollow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.AutoRoundedCorners = true;
            this.txtTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtTenDangNhap.BorderRadius = 17;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FillColor = System.Drawing.Color.Gainsboro;
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenDangNhap.HideSelection = false;
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTenDangNhap.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenDangNhap.Location = new System.Drawing.Point(133, 174);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "Username";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.ShadowDecoration.BorderRadius = 17;
            this.txtTenDangNhap.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenDangNhap.ShadowDecoration.Depth = 20;
            this.txtTenDangNhap.ShadowDecoration.Enabled = true;
            this.txtTenDangNhap.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtTenDangNhap.Size = new System.Drawing.Size(255, 37);
            this.txtTenDangNhap.TabIndex = 19;
            this.txtTenDangNhap.Tag = "";
            this.txtTenDangNhap.WordWrap = false;
            // 
            // chkAccUser
            // 
            this.chkAccUser.AutoSize = true;
            this.chkAccUser.Location = new System.Drawing.Point(290, 361);
            this.chkAccUser.Name = "chkAccUser";
            this.chkAccUser.Size = new System.Drawing.Size(57, 20);
            this.chkAccUser.TabIndex = 10;
            this.chkAccUser.TabStop = true;
            this.chkAccUser.Text = "User";
            this.chkAccUser.UseVisualStyleBackColor = true;
            this.chkAccUser.CheckedChanged += new System.EventHandler(this.chkAccUser_CheckedChanged);
            // 
            // chkAccAdmin
            // 
            this.chkAccAdmin.AutoSize = true;
            this.chkAccAdmin.Location = new System.Drawing.Point(133, 361);
            this.chkAccAdmin.Name = "chkAccAdmin";
            this.chkAccAdmin.Size = new System.Drawing.Size(66, 20);
            this.chkAccAdmin.TabIndex = 9;
            this.chkAccAdmin.TabStop = true;
            this.chkAccAdmin.Text = "Admin";
            this.chkAccAdmin.UseVisualStyleBackColor = true;
            this.chkAccAdmin.CheckedChanged += new System.EventHandler(this.chkAccAdmin_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.BorderRadius = 16;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.DarkOrange;
            this.btnDangNhap.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(133, 308);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(255, 34);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderRadius = 17;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FillColor = System.Drawing.Color.Gainsboro;
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtMatKhau.HideSelection = false;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMatKhau.Location = new System.Drawing.Point(133, 231);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "Password";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.BorderRadius = 17;
            this.txtMatKhau.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtMatKhau.ShadowDecoration.Depth = 20;
            this.txtMatKhau.ShadowDecoration.Enabled = true;
            this.txtMatKhau.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtMatKhau.Size = new System.Drawing.Size(255, 37);
            this.txtMatKhau.TabIndex = 20;
            this.txtMatKhau.Tag = "";
            this.txtMatKhau.WordWrap = false;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::Travel.Properties.Resources._9;
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(499, -46);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(500, 643);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            // 
            // ImageButtonFB
            // 
            this.ImageButtonFB.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonFB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.Image = ((System.Drawing.Image)(resources.GetObject("ImageButtonFB.Image")));
            this.ImageButtonFB.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonFB.ImageRotate = 0F;
            this.ImageButtonFB.ImageSize = new System.Drawing.Size(60, 60);
            this.ImageButtonFB.Location = new System.Drawing.Point(102, 459);
            this.ImageButtonFB.Name = "ImageButtonFB";
            this.ImageButtonFB.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonFB.Size = new System.Drawing.Size(70, 70);
            this.ImageButtonFB.TabIndex = 23;
            // 
            // PBTwitter
            // 
            this.PBTwitter.Image = ((System.Drawing.Image)(resources.GetObject("PBTwitter.Image")));
            this.PBTwitter.Location = new System.Drawing.Point(211, 459);
            this.PBTwitter.Name = "PBTwitter";
            this.PBTwitter.Size = new System.Drawing.Size(84, 70);
            this.PBTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTwitter.TabIndex = 17;
            this.PBTwitter.TabStop = false;
            // 
            // ImageButtonInsta
            // 
            this.ImageButtonInsta.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonInsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageButtonInsta.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.Image = ((System.Drawing.Image)(resources.GetObject("ImageButtonInsta.Image")));
            this.ImageButtonInsta.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonInsta.ImageRotate = 0F;
            this.ImageButtonInsta.ImageSize = new System.Drawing.Size(70, 70);
            this.ImageButtonInsta.Location = new System.Drawing.Point(336, 459);
            this.ImageButtonInsta.Name = "ImageButtonInsta";
            this.ImageButtonInsta.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.Size = new System.Drawing.Size(64, 64);
            this.ImageButtonInsta.TabIndex = 7;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 600);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PanelLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTwitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ErrorProvider ErrorProviderUsername;
        public Guna.UI2.WinForms.Guna2PictureBox PictureBox;
        public Guna.UI2.WinForms.Guna2Panel PanelLogin;
        public Guna.UI2.WinForms.Guna2ImageButton ImageButtonFB;
        public System.Windows.Forms.Label LabelLogin;
        public System.Windows.Forms.Label LabelFollow;
        public Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        public System.Windows.Forms.PictureBox PBTwitter;
        public Guna.UI2.WinForms.Guna2ImageButton ImageButtonInsta;
        public System.Windows.Forms.RadioButton chkAccUser;
        public System.Windows.Forms.RadioButton chkAccAdmin;
        public Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        public Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        public System.Windows.Forms.ErrorProvider ErrorProviderPassword;
    }
}