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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        #region Exit, minimize button, mouse  move 

        int Mouse_X;
        int Mouse_Y;
        bool Move;

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

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
            Move = true;
        }

        private void AdminDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void AdminDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new();
            homePage.Show();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #endregion

        private void MedicineAdd_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMedicine addMedicine = new();
            addMedicine.Show();
        }

        private void SellerAdd_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSeller addSeller = new();
            addSeller.Show();
        }

        private void DataBase_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBase dataBase = new();
            dataBase.Show();
        }
    }
}
