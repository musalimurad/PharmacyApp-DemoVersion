
namespace Pharmacy1
{
    partial class AddSeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeller));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.RegisterAdmin_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.RePassword_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hidepass_btn = new System.Windows.Forms.Button();
            this.Showpass_btn = new System.Windows.Forms.Button();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username_lb = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminLogin_lb = new System.Windows.Forms.Label();
            this.Seller_dgv = new System.Windows.Forms.DataGridView();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seller_dgv)).BeginInit();
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
            this.Exit_btn.Location = new System.Drawing.Point(905, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(41, 41);
            this.Exit_btn.TabIndex = 49;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // RegisterAdmin_btn
            // 
            this.RegisterAdmin_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.RegisterAdmin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterAdmin_btn.FlatAppearance.BorderSize = 0;
            this.RegisterAdmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterAdmin_btn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterAdmin_btn.ForeColor = System.Drawing.Color.White;
            this.RegisterAdmin_btn.Location = new System.Drawing.Point(12, 473);
            this.RegisterAdmin_btn.Name = "RegisterAdmin_btn";
            this.RegisterAdmin_btn.Size = new System.Drawing.Size(346, 62);
            this.RegisterAdmin_btn.TabIndex = 65;
            this.RegisterAdmin_btn.Text = "Əlavə et";
            this.RegisterAdmin_btn.UseVisualStyleBackColor = false;
            this.RegisterAdmin_btn.Click += new System.EventHandler(this.RegisterAdmin_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "Telefon";
            // 
            // Phone_tb
            // 
            this.Phone_tb.AcceptsTab = true;
            this.Phone_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.Phone_tb.AllowDrop = true;
            this.Phone_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Phone_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Phone_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone_tb.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Phone_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Phone_tb.Location = new System.Drawing.Point(76, 232);
            this.Phone_tb.Multiline = true;
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.PlaceholderText = "Telefon...";
            this.Phone_tb.ShortcutsEnabled = false;
            this.Phone_tb.Size = new System.Drawing.Size(201, 35);
            this.Phone_tb.TabIndex = 63;
            this.Phone_tb.UseSystemPasswordChar = true;
            // 
            // RePassword_tb
            // 
            this.RePassword_tb.AcceptsTab = true;
            this.RePassword_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.RePassword_tb.AllowDrop = true;
            this.RePassword_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.RePassword_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.RePassword_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePassword_tb.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RePassword_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.RePassword_tb.Location = new System.Drawing.Point(74, 356);
            this.RePassword_tb.Multiline = true;
            this.RePassword_tb.Name = "RePassword_tb";
            this.RePassword_tb.PasswordChar = '•';
            this.RePassword_tb.PlaceholderText = "Şifrə təkrarı...";
            this.RePassword_tb.ShortcutsEnabled = false;
            this.RePassword_tb.Size = new System.Drawing.Size(201, 35);
            this.RePassword_tb.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Şifrə təkrarı";
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
            this.Hidepass_btn.Image = global::Pharmacy1.Properties.Resources.icons8_eye_checked_241;
            this.Hidepass_btn.Location = new System.Drawing.Point(277, 325);
            this.Hidepass_btn.Name = "Hidepass_btn";
            this.Hidepass_btn.Size = new System.Drawing.Size(36, 35);
            this.Hidepass_btn.TabIndex = 60;
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
            this.Showpass_btn.Image = global::Pharmacy1.Properties.Resources.icons8_eye_unchecked_241;
            this.Showpass_btn.Location = new System.Drawing.Point(277, 325);
            this.Showpass_btn.Name = "Showpass_btn";
            this.Showpass_btn.Size = new System.Drawing.Size(36, 35);
            this.Showpass_btn.TabIndex = 59;
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
            this.Password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_tb.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Password_tb.Location = new System.Drawing.Point(74, 294);
            this.Password_tb.Multiline = true;
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '•';
            this.Password_tb.PlaceholderText = "Şifrə...";
            this.Password_tb.ShortcutsEnabled = false;
            this.Password_tb.Size = new System.Drawing.Size(201, 35);
            this.Password_tb.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Şifrə";
            // 
            // Username_lb
            // 
            this.Username_lb.AutoSize = true;
            this.Username_lb.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_lb.ForeColor = System.Drawing.Color.White;
            this.Username_lb.Location = new System.Drawing.Point(74, 147);
            this.Username_lb.Name = "Username_lb";
            this.Username_lb.Size = new System.Drawing.Size(101, 21);
            this.Username_lb.TabIndex = 56;
            this.Username_lb.Text = "Ad və Soyad";
            // 
            // Name_tb
            // 
            this.Name_tb.AcceptsTab = true;
            this.Name_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.Name_tb.AllowDrop = true;
            this.Name_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Name_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Name_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_tb.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_tb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Name_tb.Location = new System.Drawing.Point(76, 171);
            this.Name_tb.Multiline = true;
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.PlaceholderText = "Ad və Soyad...";
            this.Name_tb.ShortcutsEnabled = false;
            this.Name_tb.Size = new System.Drawing.Size(201, 35);
            this.Name_tb.TabIndex = 55;
            this.Name_tb.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy1.Properties.Resources.icons8_add_user_group_woman_man_48;
            this.pictureBox1.Location = new System.Drawing.Point(137, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin_lb
            // 
            this.AdminLogin_lb.AutoSize = true;
            this.AdminLogin_lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminLogin_lb.ForeColor = System.Drawing.Color.White;
            this.AdminLogin_lb.Location = new System.Drawing.Point(105, 85);
            this.AdminLogin_lb.Name = "AdminLogin_lb";
            this.AdminLogin_lb.Size = new System.Drawing.Size(168, 26);
            this.AdminLogin_lb.TabIndex = 53;
            this.AdminLogin_lb.Text = "Satıcı Qeydiyyat";
            // 
            // Seller_dgv
            // 
            this.Seller_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seller_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Seller_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Seller_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Seller_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Seller_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Seller_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seller_dgv.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Seller_dgv.Location = new System.Drawing.Point(364, 171);
            this.Seller_dgv.Name = "Seller_dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Seller_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Seller_dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Seller_dgv.RowTemplate.Height = 25;
            this.Seller_dgv.Size = new System.Drawing.Size(570, 364);
            this.Seller_dgv.TabIndex = 118;
            this.Seller_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seller_dgv_RowHeaderMouseDoubleClick);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(191, 473);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(167, 62);
            this.Delete_btn.TabIndex = 120;
            this.Delete_btn.Text = "Sil";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Visible = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.Edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(12, 473);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(173, 62);
            this.Edit_btn.TabIndex = 119;
            this.Edit_btn.Text = "Düzəliş et";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Visible = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(119, 438);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(128, 29);
            this.Back_btn.TabIndex = 121;
            this.Back_btn.Text = "Geri qayıt";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Visible = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(345, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 48);
            this.label6.TabIndex = 122;
            this.label6.Text = "EuroMED Aptek";
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Seller_dgv);
            this.Controls.Add(this.RegisterAdmin_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone_tb);
            this.Controls.Add(this.RePassword_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hidepass_btn);
            this.Controls.Add(this.Showpass_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_lb);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdminLogin_lb);
            this.Controls.Add(this.Exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeller";
            this.Load += new System.EventHandler(this.AddSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seller_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button RegisterAdmin_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Phone_tb;
        private System.Windows.Forms.TextBox RePassword_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Hidepass_btn;
        private System.Windows.Forms.Button Showpass_btn;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username_lb;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminLogin_lb;
        private System.Windows.Forms.DataGridView Seller_dgv;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label6;
    }
}