using Microsoft.EntityFrameworkCore;
using Pharmacy1.Helpers;
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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            
        }

        private const string Reseptli = "reseptli";
        private const string Reseptsiz = "reseptsiz";
        PharmacyDBContext PharmacyDB = new();

        #region Exit, minimize button, mouse  move 

        int Mouse_X;
        int Mouse_Y;
        bool Move;

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Maximize_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void AddMedicine_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
            Move = true;
        }

        private void AddMedicine_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void AddMedicine_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        #endregion 

        #region Find method

        private int FindFirm(string Firmname)
        {
            using PharmacyDBContext pharmacyDB = new();

            Firm SelectedFirm = pharmacyDB.Firms.FirstOrDefault(x => x.FirmName == Firmname);
            if (SelectedFirm == null)
            {

                Firm NewFirm = new()
                {
                    FirmName = Firmname
                };
                pharmacyDB.Firms.Add(NewFirm);
                pharmacyDB.SaveChanges();
                return NewFirm.FirmId;
            }
            return SelectedFirm.FirmId;
        }

        #endregion

        #region Fill Method

        private void FillFirmCombo()
        {
            Firmname_cb.Items.AddRange(PharmacyDB.Firms.Select(x => x.FirmName).ToArray());
        }

        private void FillTagCombo()
        {
            TagName_cb.Items.AddRange(PharmacyDB.Tags.Select(x => x.TagName).ToArray());
        }

        private void FillDataGrid()
        {
            AddMedicine_dgv.DataSource = PharmacyDB.MedicineToTags.Select(b => new
            {
                ID = b.MedicineId,
                Ad = b.Medicine.MedicineName,
                Say = b.Medicine.Quantity,
                Qiymət = b.Medicine.Price,
                Barkod = b.Medicine.Barcode,
                Resept = b.Medicine.IsReceipt ? Reseptli : Reseptsiz,
                SonIstifadə = b.Medicine.ExpirationDate,
                Xəstəlik = b.Tag.TagName,
                Firma = b.Medicine.Firm.FirmName,

            }).ToList();
            AddMedicine_dgv.Columns[0].Visible = false;
            AddMedicine_dgv.Columns[6].DefaultCellStyle.Format = "dd MMMM yyyy";

            for (int i = 0; i < AddMedicine_dgv.RowCount; i++)
            {
                int Quantity = (int)AddMedicine_dgv.Rows[i].Cells[2].Value;
                if (Quantity <= 0)
                {
                    AddMedicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
                DateTime ExpirationDate = (DateTime)AddMedicine_dgv.Rows[i].Cells[6].Value;
                if (ExpirationDate<DateTime.Now)
                {
                    AddMedicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
                if (Quantity <= 0 && ExpirationDate < DateTime.Now)
                {
                    AddMedicine_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            PharmacyDB.SaveChanges();
        }

        #endregion

        #region Listbox Fill Tag Method

        private void TagSelectedIndexChange()
        {
            string Tagname = TagName_cb.Text;
            if (!Tag_clb.Items.Contains(Tagname))
            {
                Tag_clb.Items.Add(Tagname, true);
            }
        }

        private void TagName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagSelectedIndexChange();
        }

        private void TagName_cb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TagSelectedIndexChange();
            }
        }

        private void Tag_clb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected = Tag_clb.SelectedIndex;
            if (Selected != -1)
            {
                Tag_clb.Items.RemoveAt(Selected);
            }
        }

        #endregion

        #region Add Method

        private void MedicineAdd()
        {
            string MedicineName = Medicinename_tb.Text;
            string FirmName = Firmname_cb.Text;
            string TagName = TagName_cb.Text;
            string Description = Description_rtb.Text;
            int Quantity = (int)Quantity_num.Value;
            decimal Price = Price_num.Value;
            string Barcode = Barcode_tb.Text;
            DateTime PublishDate = PublishDate_dtp.Value;
            DateTime Expirationdate = ExpirationDate_dtp.Value;
            bool IsReceipt = IsReceipt_chekbox.Checked;

            string[] Myarr = { MedicineName, FirmName, TagName, Description, Barcode };
            if (Utilities.IsEmpty(Myarr))
            {
                if (Price > 0)
                {
                    if (PublishDate <= DateTime.Now)
                    {
                        if (Expirationdate > DateTime.Now)
                        {
                            int FirmId = FindFirm(FirmName);
                            Medicine medicine = new()
                            {
                                MedicineName = MedicineName,
                                Description = Description,
                                FirmId = FirmId,
                                Quantity = Quantity,
                                Price = Price,
                                Barcode = Barcode,
                                PublishDate = PublishDate,
                                ExpirationDate = Expirationdate,
                                IsReceipt = IsReceipt
                            };
                            PharmacyDB.Medicines.Add(medicine);
                            PharmacyDB.SaveChanges();
                            MedicineAddTag(medicine.MedicineId);
                            MessageBox.Show("Dərman əlavə olundu!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            FillDataGrid();
                            FillFirmCombo();
                            FillTagCombo();
                        }
                        else
                        {
                            MessageBox.Show("Son istifadə tarixi bu gün və ya keçmiş tarix ola bilməz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Buraxılış tarixi gələcək tarix ola bilməz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                else
                {
                    MessageBox.Show("qiymət 0Azn ola bilməz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            else
            {
                 MessageBox.Show(text: "Bütün boşluqları doldurun!", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Hand);
            }
        }

        private void AddMedicine_btn_Click_1(object sender, EventArgs e)
        {
            MedicineAdd();
        }

        #endregion

        #region Medicine Add Tag

        private bool CheckedTag(string Tag)
        {
            Tag SelectedTag = PharmacyDB.Tags.FirstOrDefault(x => x.TagName == Tag);
            if (SelectedTag == null)
            {
                return false;
            }
            return true;
        }

        private void MedicineAddTag(int MedicineID)
        {
            for (var i = 0; i < Tag_clb.Items.Count; i++)
            {
                string Tagname = Tag_clb.Items[i].ToString();
                int TagID;
                if (CheckedTag(Tagname))
                {
                    TagID = PharmacyDB.Tags.FirstOrDefault(x => x.TagName == Tagname).TagId;
                }
                else
                {
                    Tag NewTag = new()
                    {
                        TagName = Tagname
                    };
                    PharmacyDB.Tags.Add(NewTag);
                    PharmacyDB.SaveChanges();
                    TagID = NewTag.TagId;
                }
                PharmacyDB.MedicineToTags.Add(new MedicineToTag()
                {
                    TagId = TagID,
                    MedicineId = MedicineID
                });
                PharmacyDB.SaveChanges();
            }
        }

        #endregion

        #region Clear Method

        private void Clear()
        {
            Medicinename_tb.Text = default;
            Firmname_cb.Text = default;
            TagName_cb.Text = default;
            Description_rtb.Text = default;
            IsReceipt_chekbox.Checked = false;
            Price_num.Value = default;
            Barcode_tb.Text = default;
            Quantity_num.Value = 1;
            Tag_clb.Items.Clear();
            PublishDate_dtp.Value = DateTime.Now;
            ExpirationDate_dtp.Value = DateTime.Now;
        }

        #endregion

        #region Load Method

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillFirmCombo();
            FillTagCombo();
        }



        #endregion

        #region Delete Edit Method

        MedicineToTag selectedMedicine;
        MedicineToTag selectedTag;
        Firm selectedFirm;
        private void AddMedicine_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int MedicineID = (int)AddMedicine_dgv.Rows[e.RowIndex].Cells[0].Value;
            int TagID = (int)AddMedicine_dgv.Rows[e.RowIndex].Cells[0].Value;
            int FirmID = (int)AddMedicine_dgv.Rows[e.RowIndex].Cells[0].Value;
            selectedMedicine = PharmacyDB.MedicineToTags.Include(x=>x.Medicine).First(x => x.MedicineId == MedicineID);
            selectedTag = PharmacyDB.MedicineToTags.Include(x => x.Tag).FirstOrDefault(x => x.TagId == TagID);
            selectedFirm = PharmacyDB.Firms.FirstOrDefault(x => x.FirmId == FirmID);
            Medicinename_tb.Text = selectedMedicine.Medicine.MedicineName;
            Quantity_num.Value = selectedMedicine.Medicine.Quantity;
            Price_num.Value = selectedMedicine.Medicine.Price;
            Barcode_tb.Text = selectedMedicine.Medicine.Barcode;
            PublishDate_dtp.Value = selectedMedicine.Medicine.PublishDate;
            ExpirationDate_dtp.Value = selectedMedicine.Medicine.ExpirationDate;
            Description_rtb.Text = selectedMedicine.Medicine.Description;
            IsReceipt_chekbox.Checked = selectedMedicine.Medicine.IsReceipt;
            
            
            Delete_btn.Visible = true;
            Edit_btn.Visible = true;
            Back_btn.Visible = true;
            AddMedicine_btn.Visible = false;
        }
       
        private void HideButton()
        {
            Delete_btn.Visible = false;
            Edit_btn.Visible = false;
            Back_btn.Visible = false;
            AddMedicine_btn.Visible = true;
        }

        private void DeleteButton()
        {
            PharmacyDB.MedicineToTags.Remove(selectedMedicine);
            PharmacyDB.SaveChanges();
            Clear();
            HideButton();
            FillDataGrid();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dərmanı silmək istəyirsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteButton();
            }

            MessageBox.Show("Dərman silindi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Clear();
            HideButton();
            FillDataGrid();
        }

        #endregion

        #region Edit Method

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            MedicineAdd();
            DeleteButton();
        }

        #endregion


    }
}
