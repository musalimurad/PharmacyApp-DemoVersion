using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy1.Models;
using Microsoft.Office;

namespace Pharmacy1
{
    public partial class SellerDashboard : Form
    {
        public SellerDashboard()
        {
            InitializeComponent();
        }

        private const string Reseptli = "reseptli";
        private const string Reseptsiz = "reseptsiz";

        PharmacyDBContext PharmacyDB = new();

        #region close minimize button

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            HomePage homePage = new();
            homePage.Show();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Add medicine

        private void AddMedicine_btn_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new();
            addMedicine.Show();
        }

        #endregion

        #region Fill  method

        private void FillMedicineCombo()
        {
            Medicine_cb.Items.AddRange(PharmacyDB.Medicines.Select(x => x.MedicineName).ToArray());
        }

        private void FillFirmCombo()
        {
            Firm_cb.Items.AddRange(PharmacyDB.Firms.Select(x => x.FirmName).ToArray());
        }

        public void FillDataGridMedicine()
        {
            Medicine_dgv.DataSource = PharmacyDB.MedicineToTags.Where(m=>m.Medicine.MedicineName.Contains(Medicine_cb.Text) && m.Medicine.Firm.FirmName.Contains(Firm_cb.Text)).Select(b => new
            {
                ID = b.MedicineId,
                Ad = b.Medicine.MedicineName,
                Firma = b.Medicine.Firm.FirmName,
                Xəstəlik = b.Tag.TagName,
                Resept = b.Medicine.IsReceipt ? Reseptli : Reseptsiz,
                SonIstifadə = b.Medicine.ExpirationDate,
                Qiymət = b.Medicine.Price,
                Say = b.Medicine.Quantity,
                Barkod = b.Medicine.Barcode,
               
            }).ToList();

            Medicine_dgv.Columns[0].Visible = false;
            Medicine_dgv.Columns[5].DefaultCellStyle.Format = "dd MMMM yyyy";

            for (int i = 0; i < Medicine_dgv.RowCount; i++)
            {
                int Quantity = (int)Medicine_dgv.Rows[i].Cells[7].Value;
                if (Quantity <= 0)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
                DateTime ExpirationDate = (DateTime)Medicine_dgv.Rows[i].Cells[5].Value;
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

        #endregion

        #region Load method

        private void SellerDashboard_Load(object sender, EventArgs e)
        {
            FillDataGridMedicine();
            FillFirmCombo();
            FillMedicineCombo();
        }

        #endregion

        #region Export Excel

        private void PrintExcel_btn_Click(object sender, EventArgs e)
        {
            DataObject copyData = Medicine_dgv.GetClipboardContent();

            if (copyData != null)
            {
                Clipboard.SetDataObject(copyData);
            }

            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();

            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            object missedData = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(missedData);

            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];

            xlr.Select();
            xlSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        #endregion

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            Sale sale = new();
            sale.ShowDialog();
        }

        #region Search Filter method

        private void Medicine_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridMedicine();
        }

        private void Medicine_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Medicine_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Medicine_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Firm_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Firm_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Firm_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGridMedicine();

        }

        private void Firm_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGridMedicine();

        }

        #endregion

        
    }
}
