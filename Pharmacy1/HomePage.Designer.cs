
namespace Pharmacy1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admin_btn = new System.Windows.Forms.Button();
            this.Seller_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 42);
            this.panel1.TabIndex = 10;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = global::Pharmacy1.Properties.Resources.icons8_close_window_44;
            this.Exit_btn.Location = new System.Drawing.Point(685, -1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(44, 41);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Pharmacy1.Properties.Resources.icons8_shrink_44;
            this.button1.Location = new System.Drawing.Point(641, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy1.Properties.Resources._00_pharmacist_shutterstock_1345420442_770;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_btn
            // 
            this.Admin_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Admin_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.Admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_btn.FlatAppearance.BorderSize = 0;
            this.Admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Admin_btn.ForeColor = System.Drawing.Color.White;
            this.Admin_btn.Location = new System.Drawing.Point(12, 406);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(167, 50);
            this.Admin_btn.TabIndex = 12;
            this.Admin_btn.Text = "Admin";
            this.Admin_btn.UseVisualStyleBackColor = false;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Seller_btn
            // 
            this.Seller_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Seller_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Seller_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seller_btn.FlatAppearance.BorderSize = 0;
            this.Seller_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seller_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seller_btn.ForeColor = System.Drawing.Color.White;
            this.Seller_btn.Location = new System.Drawing.Point(550, 406);
            this.Seller_btn.Name = "Seller_btn";
            this.Seller_btn.Size = new System.Drawing.Size(167, 50);
            this.Seller_btn.TabIndex = 13;
            this.Seller_btn.Text = "Satıcı";
            this.Seller_btn.UseVisualStyleBackColor = false;
            this.Seller_btn.Click += new System.EventHandler(this.Seller_btn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 491);
            this.Controls.Add(this.Seller_btn);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Admin_btn;
        private System.Windows.Forms.Button Seller_btn;
    }
}