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
using Pharmacy1.Models;

namespace Pharmacy1
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        PharmacyDBContext PharmacyDB = new();

        #region Exit, MouseMove method

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int Mouse_X;
        int Mouse_Y;
        bool Move;

        private void Sale_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
            Move = true;
        }

        private void Sale_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void Sale_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
            Move = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        #endregion

        #region Fill method

        private void FillMedicineCombo()
        {
            Medicine_cb.Items.AddRange(PharmacyDB.Medicines.Select(m => m.MedicineName).ToArray());
        }

        private void FillDataGrid()
        {
            Medicine_dgv.DataSource = PharmacyDB.MedicineToTags.Where(m => m.Medicine.MedicineName.Contains(Medicine_cb.Text)).Select(m => new
            {
                ID = m.MedicineId,
                Dərman = m.Medicine.MedicineName,
                Xəstəlik  = m.Tag.TagName,
                Say = m.Medicine.Quantity,
                Qiymət =  m.Medicine.Price,
                Sonİstifadə = m.Medicine.ExpirationDate

            }).ToList();
            Medicine_dgv.Columns[0].Visible = false;
            Medicine_dgv.Columns[5].DefaultCellStyle.Format = "dd MMMM yyyy";

            for (int i = 0; i < Medicine_dgv.RowCount; i++)
            {
                int Quantity = (int)Medicine_dgv.Rows[i].Cells[3].Value;
                if (Quantity<=0)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkViolet;
                }

                DateTime ExpirationDate = (DateTime)Medicine_dgv.Rows[i].Cells[5].Value;
                if (ExpirationDate< DateTime.Now)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkOrange;
                }

                if (Quantity<=0 && ExpirationDate < DateTime.Now)
                {
                    Medicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        #region Search Filter method

        private void Medicine_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
            Add_btn.Visible = true;
        }

        private void Medicine_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGrid();
        }

        private void Medicine_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGrid();
            Add_btn.Visible = true;
        }


        #endregion

        #region Load method

        private void Sale_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillMedicineCombo();
        }

        #endregion

        

        MedicineToTag selectedMedicine;

        private void Medicine_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel2.Visible = true;
            int MedID = (int)Medicine_dgv.Rows[e.RowIndex].Cells[0].Value;
            selectedMedicine = PharmacyDB.MedicineToTags.Include(x=>x.Medicine).FirstOrDefault(x => x.MedicineId == MedID);
            Medicine_cb.Text = selectedMedicine.Medicine.MedicineName;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }
    }
}
