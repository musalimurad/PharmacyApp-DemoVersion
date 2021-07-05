using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy1.Helpers;
using Pharmacy1.Models; 

namespace Pharmacy1
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        PharmacyDBContext PharmacyDB = new();

        #region Minimize Exit Button

        private void Min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new();
            adminDashboard.Show();
        }

        #endregion

        #region Fill Method

        private void FillFirmCombo()
        {
            Firm_cb.Items.AddRange(PharmacyDB.Firms.Select(x => x.FirmName).ToArray());
        }

        private void FillMedicineCombo()
        {
            Medicine_cb.Items.AddRange(PharmacyDB.Medicines.Select(x => x.MedicineName).ToArray());
        }

        private void FillSellerNameCombo()
        {
            Seller_cb.Items.AddRange(PharmacyDB.Admins.Select(x => x.Fullname).ToArray());
        }

        private void FillSellerPhoneCombo()
        {
            Phone_cb.Items.AddRange(PharmacyDB.Admins.Select(x => x.Phone).ToArray());
        }

        private void FillDataGrid()
        {
            Medicine_dgv.DataSource = PharmacyDB.MedicineToTags.Where(m=>m.Medicine.MedicineName.Contains(Medicine_cb.Text) && m.Medicine.Firm.FirmName.Contains(Firm_cb.Text)).Select(b => new
            {
                ID = b.MedicineId,
                Ad = b.Medicine.MedicineName,
                Firma = b.Medicine.Firm.FirmName,
                Xəstəlik = b.Tag.TagName,
                Resept = b.Medicine.IsReceipt ? "reseptli" : "reseptsiz",
                Say = b.Medicine.Quantity,
                Qiymət = b.Medicine.Price,
                Barkod =b.Medicine.Barcode,
                Buraxılış = b.Medicine.PublishDate,
                SonIstifadə = b.Medicine.ExpirationDate
               

            }).Distinct().ToList();
            Medicine_dgv.Columns[0].Visible = false;
            Medicine_dgv.Columns[8].DefaultCellStyle.Format = "dd MMMM yyyy";
            Medicine_dgv.Columns[9].DefaultCellStyle.Format = "dd MMMM yyyy";

            for (int i = 0; i < Medicine_dgv.RowCount; i++)
            {
                int Quantity = (int)Medicine_dgv.Rows[i].Cells[5].Value;
                if (Quantity <= 0)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
                DateTime ExpirationDate = (DateTime)Medicine_dgv.Rows[i].Cells[9].Value;
                if (ExpirationDate < DateTime.Now)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
                if (Quantity <= 0 && ExpirationDate < DateTime.Now)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            PharmacyDB.SaveChanges();
        }

        private void FillSellerDataGrid()
        {
            Seller_dgv.DataSource = PharmacyDB.Admins.Where(a=> a.Fullname.Contains(Seller_cb.Text) && a.Phone.Contains(Phone_cb.Text)).Select(b => new
            {
                ID = b.AdminId,
                Ad = b.Fullname,
                Telefon = b.Phone,
                Şifrə = b.Password
            }).ToList();

        }

        #endregion

        #region Load method

        private void DataBase_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillSellerDataGrid();
            FillFirmCombo();
            FillSellerNameCombo();
            FillSellerPhoneCombo();
            FillMedicineCombo();
        }
        #endregion

        #region Search filter method

        private void Medicine_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void Medicine_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDataGrid();
        }

        private void Medicine_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGrid();
        }

        private void Medicine_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGrid();
        }

        private void Firm_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void Firm_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDataGrid();
        }

        private void Firm_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGrid();
        }

        private void Firm_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGrid();
        }

        private void Seller_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Seller_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Seller_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Seller_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Phone_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Phone_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Phone_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillSellerDataGrid();
        }

        private void Phone_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillSellerDataGrid();
        }

        #endregion
    }
}
