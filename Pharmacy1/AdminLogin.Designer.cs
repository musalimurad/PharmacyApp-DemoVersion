
namespace Pharmacy1
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Hidepass_btn = new System.Windows.Forms.Button();
            this.Showpass_btn = new System.Windows.Forms.Button();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAdmin_btn = new System.Windows.Forms.Button();
            this.Username_lb = new System.Windows.Forms.Label();
            this.Fullname_tb = new System.Windows.Forms.TextBox();
            this.AdminLogin_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = global::Pharmacy1.Properties.Resources.icons8_close_window_44;
            this.Exit_btn.Location = new System.Drawing.Point(280, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(44, 45);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(104, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 15);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifrəmi unutdum ?";
            // 
            // Hidepass_btn
            // 
            this.Hidepass_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Hidepass_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Hidepass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hidepass_btn.FlatAppearance.BorderSize = 0;
            this.Hidepass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hidepass_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hidepass_btn.ForeColor = System.Drawing.Color.White;
            this.Hidepass_btn.Image = global::Pharmacy1.Properties.Resources.icons8_eye_checked_24;
            this.Hidepass_btn.Location = new System.Drawing.Point(257, 239);
            this.Hidepass_btn.Name = "Hidepass_btn";
            this.Hidepass_btn.Size = new System.Drawing.Size(36, 35);
            this.Hidepass_btn.TabIndex = 38;
            this.Hidepass_btn.UseVisualStyleBackColor = false;
            this.Hidepass_btn.Visible = false;
            this.Hidepass_btn.Click += new System.EventHandler(this.Hidepass_btn_Click);
            // 
            // Showpass_btn
            // 
            this.Showpass_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Showpass_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Showpass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Showpass_btn.FlatAppearance.BorderSize = 0;
            this.Showpass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Showpass_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Showpass_btn.ForeColor = System.Drawing.Color.White;
            this.Showpass_btn.Image = global::Pharmacy1.Properties.Resources.icons8_eye_unchecked_24;
            this.Showpass_btn.Location = new System.Drawing.Point(257, 238);
            this.Showpass_btn.Name = "Showpass_btn";
            this.Showpass_btn.Size = new System.Drawing.Size(36, 35);
            this.Showpass_btn.TabIndex = 37;
            this.Showpass_btn.UseVisualStyleBackColor = false;
            this.Showpass_btn.Click += new System.EventHandler(this.Showpass_btn_Click);
            // 
            // Password_tb
            // 
            this.Password_tb.AcceptsTab = true;
            this.Password_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.Password_tb.AllowDrop = true;
            this.Password_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Password_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Password_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_tb.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_tb.ForeColor = System.Drawing.Color.DarkCyan;
            this.Password_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Password_tb.Location = new System.Drawing.Point(50, 238);
            this.Password_tb.Multiline = true;
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '•';
            this.Password_tb.PlaceholderText = "Şifrə...";
            this.Password_tb.ShortcutsEnabled = false;
            this.Password_tb.Size = new System.Drawing.Size(201, 35);
            this.Password_tb.TabIndex = 36;
            this.Password_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_tb_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy1.Properties.Resources.icons8_admin_settings_male_70;
            this.pictureBox1.Location = new System.Drawing.Point(104, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Şifrə";
            // 
            // LoginAdmin_btn
            // 
            this.LoginAdmin_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.LoginAdmin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAdmin_btn.FlatAppearance.BorderSize = 0;
            this.LoginAdmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdmin_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginAdmin_btn.ForeColor = System.Drawing.Color.White;
            this.LoginAdmin_btn.Location = new System.Drawing.Point(14, 325);
            this.LoginAdmin_btn.Name = "LoginAdmin_btn";
            this.LoginAdmin_btn.Size = new System.Drawing.Size(296, 51);
            this.LoginAdmin_btn.TabIndex = 32;
            this.LoginAdmin_btn.Text = "Daxil ol";
            this.LoginAdmin_btn.UseVisualStyleBackColor = false;
            this.LoginAdmin_btn.Click += new System.EventHandler(this.LoginAdmin_btn_Click);
            // 
            // Username_lb
            // 
            this.Username_lb.AutoSize = true;
            this.Username_lb.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_lb.ForeColor = System.Drawing.Color.White;
            this.Username_lb.Location = new System.Drawing.Point(50, 151);
            this.Username_lb.Name = "Username_lb";
            this.Username_lb.Size = new System.Drawing.Size(101, 21);
            this.Username_lb.TabIndex = 31;
            this.Username_lb.Text = "Ad və Soyad";
            // 
            // Fullname_tb
            // 
            this.Fullname_tb.AcceptsTab = true;
            this.Fullname_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.Fullname_tb.AllowDrop = true;
            this.Fullname_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Fullname_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Fullname_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fullname_tb.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fullname_tb.ForeColor = System.Drawing.Color.DarkCyan;
            this.Fullname_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Fullname_tb.Location = new System.Drawing.Point(50, 176);
            this.Fullname_tb.Multiline = true;
            this.Fullname_tb.Name = "Fullname_tb";
            this.Fullname_tb.PlaceholderText = "Ad və Soyad...";
            this.Fullname_tb.ShortcutsEnabled = false;
            this.Fullname_tb.Size = new System.Drawing.Size(201, 35);
            this.Fullname_tb.TabIndex = 33;
            this.Fullname_tb.UseSystemPasswordChar = true;
            // 
            // AdminLogin_lb
            // 
            this.AdminLogin_lb.AutoSize = true;
            this.AdminLogin_lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminLogin_lb.ForeColor = System.Drawing.Color.White;
            this.AdminLogin_lb.Location = new System.Drawing.Point(91, 113);
            this.AdminLogin_lb.Name = "AdminLogin_lb";
            this.AdminLogin_lb.Size = new System.Drawing.Size(126, 26);
            this.AdminLogin_lb.TabIndex = 30;
            this.AdminLogin_lb.Text = "Admin Giriş";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Hidepass_btn);
            this.Controls.Add(this.Showpass_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginAdmin_btn);
            this.Controls.Add(this.Username_lb);
            this.Controls.Add(this.Fullname_tb);
            this.Controls.Add(this.AdminLogin_lb);
            this.Controls.Add(this.Exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Hidepass_btn;
        private System.Windows.Forms.Button Showpass_btn;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginAdmin_btn;
        private System.Windows.Forms.Label Username_lb;
        private System.Windows.Forms.TextBox Fullname_tb;
        private System.Windows.Forms.Label AdminLogin_lb;
    }
}