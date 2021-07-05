using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy1.Helpers;
using Pharmacy1.Models;

namespace Pharmacy1
{
    public partial class AddSeller : Form
    {
        public AddSeller()
        {
            InitializeComponent();
        }

        PharmacyDBContext PharmacyDB = new();

        #region Show, Hide, Exit button

        private void Hidepass_btn_Click(object sender, EventArgs e)
        {
            if (Password_tb.PasswordChar == '\0' && RePassword_tb.PasswordChar == '\0')
            {
                Showpass_btn.BringToFront();
                Showpass_btn.Visible = true;
                Password_tb.PasswordChar = '•';
                RePassword_tb.PasswordChar = '•';
            }
        }

        private void Showpass_btn_Click(object sender, EventArgs e)
        {
            if (Password_tb.PasswordChar == '•' && RePassword_tb.PasswordChar == '•')
            {
                Hidepass_btn.BringToFront();
                Hidepass_btn.Visible = true;
                Password_tb.PasswordChar = '\0';
                RePassword_tb.PasswordChar = '\0';
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new();
            adminDashboard.Show();
        }

        #endregion

        #region Fill Method

        private void FillDataGrid()
        {
            Seller_dgv.DataSource = PharmacyDB.Admins.Select(b=> new
            {
             ID =  b.AdminId,
             Ad =  b.Fullname,
             Telefon = b.Phone,
             Şifrə = b.Password,
                
            }).ToList();
            Seller_dgv.Columns[0].Visible = false;
        }

        #endregion

        #region Method AddSeller, Method Clear

        private void Clear()
        {
            Name_tb.Text = default;
            Phone_tb.Text = default;
            Password_tb.Text = default;
            RePassword_tb.Text = default;
        }

        private void SellerAdd()
        {
            using var pharmacyDB = new PharmacyDBContext();

            string Fullname = Name_tb.Text;
            string Phone = Phone_tb.Text;
            string Password = Password_tb.Text;
            string RePassword = RePassword_tb.Text;
            string[] Myarr = { Fullname, Phone, Password, RePassword };
            if (Utilities.IsEmpty(Myarr))
            {
                if (Password.Length >= 6 && RePassword.Length >= 6)
                {
                    if (Password == RePassword)
                    {

                        Models.Admin selectedAdmin = pharmacyDB.Admins.FirstOrDefault(x => x.Phone == Phone);
                        if (selectedAdmin == null)
                        {
                            pharmacyDB.Admins.Add(new Admin()
                            {
                                Fullname = Fullname,
                                Phone = Phone,
                                Password = Password,
                                RePassword = RePassword
                            });
                            pharmacyDB.SaveChanges();
                            MessageBox.Show("Əlavə olundu!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDataGrid();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Bu telefon nömrəsi ilə artıq qeydiyyatdan keçilib!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifrələr eyni deyil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Şifrə uzunluğu ən az 6 simvoldan ibarət olmalıdır!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bütün boşluqları doldurun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void RegisterAdmin_btn_Click(object sender, EventArgs e)
        {
            SellerAdd();
        }


        #endregion

        #region Load method

        private void AddSeller_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        #endregion

        #region Delete, Edit method

        Admin selectedAdmin;
        
        private void Seller_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int AdminID = (int)Seller_dgv.Rows[e.RowIndex].Cells[0].Value;
            selectedAdmin = PharmacyDB.Admins.First(x => x.AdminId == AdminID);

            Name_tb.Text = selectedAdmin.Fullname;
            Phone_tb.Text = selectedAdmin.Phone;
            Password_tb.Text = selectedAdmin.Password;
            RePassword_tb.Text = selectedAdmin.RePassword;

            Edit_btn.Visible = true;
            Delete_btn.Visible = true;
            Back_btn.Visible = true;
            RegisterAdmin_btn.Visible = false;
        }

        private void HideButton()
        {
            Edit_btn.Visible = false;
            Delete_btn.Visible = false;
            Back_btn.Visible = false;
            RegisterAdmin_btn.Visible = true;
        }

        private void DeleteButton()
        {
            PharmacyDB.Admins.Remove(selectedAdmin);
            PharmacyDB.SaveChanges();
            Clear();
            HideButton();
            FillDataGrid();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( text: "Satıcı məlumatını silmək istəyirsiniz?", caption: "Sual", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                DeleteButton();

            }
           
            MessageBox.Show( text: "Satıcı silindi!", caption: "Məlumat", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Clear();
            FillDataGrid();
            HideButton();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            SellerAdd();
            DeleteButton();
            FillDataGrid();
        }

        #endregion


    }
}
