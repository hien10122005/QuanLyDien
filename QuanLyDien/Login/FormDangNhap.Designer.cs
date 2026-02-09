partial class FormDangNhap
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panelUnderlineUser = new System.Windows.Forms.Panel();
            this.panelUnderlinePass = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Controls.Add(this.labelAppName);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(333, 467);
            this.panelLeft.TabIndex = 10;
            // 
            // labelAppName
            // 
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(4, 302);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(329, 55);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "Chào mừng bạn đến với Hệ thống Quản lý Công ty Điện lực PVH";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblTitle.Location = new System.Drawing.Point(487, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtUsername.Location = new System.Drawing.Point(435, 134);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(347, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // panelUnderlineUser
            // 
            this.panelUnderlineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelUnderlineUser.Location = new System.Drawing.Point(387, 164);
            this.panelUnderlineUser.Margin = new System.Windows.Forms.Padding(4);
            this.panelUnderlineUser.Name = "panelUnderlineUser";
            this.panelUnderlineUser.Size = new System.Drawing.Size(400, 2);
            this.panelUnderlineUser.TabIndex = 11;
            // 
            // panelUnderlinePass
            // 
            this.panelUnderlinePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelUnderlinePass.Location = new System.Drawing.Point(387, 240);
            this.panelUnderlinePass.Margin = new System.Windows.Forms.Padding(4);
            this.panelUnderlinePass.Name = "panelUnderlinePass";
            this.panelUnderlinePass.Size = new System.Drawing.Size(400, 2);
            this.panelUnderlinePass.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtPassword.Location = new System.Drawing.Point(435, 206);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(347, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.btnDangNhap.Location = new System.Drawing.Point(387, 283);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(400, 49);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblClose.Location = new System.Drawing.Point(793, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.BackColor = System.Drawing.SystemColors.Window;
            this.btnQuenMK.FlatAppearance.BorderSize = 0;
            this.btnQuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMK.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnQuenMK.Location = new System.Drawing.Point(341, 398);
            this.btnQuenMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(169, 30);
            this.btnQuenMK.TabIndex = 13;
            this.btnQuenMK.Text = "Quên mật khẩu !";
            this.btnQuenMK.UseVisualStyleBackColor = false;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMk_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.White;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnDangKy.Location = new System.Drawing.Point(618, 398);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(169, 30);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng ký tài khoản ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::QuanLyDien.Properties.Resources.Use;
            this.pictureBox2.Image = global::QuanLyDien.Properties.Resources.Pass;
            this.pictureBox2.InitialImage = global::QuanLyDien.Properties.Resources.Pass;
            this.pictureBox2.Location = new System.Drawing.Point(390, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::QuanLyDien.Properties.Resources.Use;
            this.pictureBox1.Image = global::QuanLyDien.Properties.Resources.account_child_invert_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.InitialImage = global::QuanLyDien.Properties.Resources.Pass;
            this.pictureBox1.Location = new System.Drawing.Point(389, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::QuanLyDien.Properties.Resources._572c661b_9135_404b_8784_1c36f75b5506_removebg_preview;
            this.pictureBoxLogo.Location = new System.Drawing.Point(47, 85);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(217, 195);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.panelUnderlinePass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panelUnderlineUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Panel panelUnderlineUser;
    private System.Windows.Forms.Panel panelUnderlinePass;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnDangNhap;
    private System.Windows.Forms.Label lblClose;
    private System.Windows.Forms.Label labelAppName;
    private System.Windows.Forms.Button btnQuenMK;
    private System.Windows.Forms.Button btnDangKy;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBoxLogo;
}