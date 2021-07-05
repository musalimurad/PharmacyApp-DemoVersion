﻿using Pharmacy1.Helpers;
using Pharmacy1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy1
{
    public partial class SellerLogin : Form
    {
        public SellerLogin()
        {
            InitializeComponent();
        }


        #region exit, showpass hidepass method

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            HomePage homePage = new();
            homePage.Show();
        }

        private void Hidepass_btn_Click(object sender, EventArgs e)
        {
            if (Password_tb.PasswordChar == '\0')
            {
                Showpass_btn.BringToFront();
                Showpass_btn.Visible = true;
                Password_tb.PasswordChar = '•';
            }
        }

        private void Showpass_btn_Click(object sender, EventArgs e)
        {
            if (Password_tb.PasswordChar == '•')
            {
                Hidepass_btn.BringToFront();
                Hidepass_btn.Visible = true;
                Password_tb.PasswordChar = '\0';
            }
        }

        #endregion

        #region Login-seller

        private void LoginSeller()
        {
            using var PharmacyDB = new PharmacyDBContext();
            string Fullname = Fullname_tb.Text;
            string Password = Password_tb.Text;
            string[] Myarr = { Fullname, Password };
            if (Utilities.IsEmpty(Myarr))
            {
                if (PharmacyDB.Admins.Where(x => x.Fullname == Fullname).Count() > 0 && PharmacyDB.Admins.Where(x => x.Password == Password).Count() > 0)
                {
                    SellerDashboard sellerDashboard = new();
                    sellerDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ad və ya Şifrə doğru  deyil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Fullname_tb.Text = default;
                    Password_tb.Text = default;
                }
            }
            else
            {
                MessageBox.Show("Bütün boşluqları doldurun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void LoginAdmin_btn_Click(object sender, EventArgs e)
        {
            LoginSeller();
           
        }
        #endregion
    }
}
