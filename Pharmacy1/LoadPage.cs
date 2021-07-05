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
    public partial class LoadPage : Form
    {
        public LoadPage()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width > 825)
            {
                timer1.Stop();
                this.Hide();
                HomePage homePage = new();
                homePage.Show();
            }
        }
    }
}
