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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Proqramdan çıxış etmək istəyirsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new();
            adminLogin.Show();
        }

        private void Seller_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerLogin sellerLogin = new();
            sellerLogin.Show();
        }
    }
}
