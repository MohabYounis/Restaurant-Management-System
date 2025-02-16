using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mohab.Business;

namespace Mohab.Presentation
{
    public partial class Pres_Admin : Form
    {
        Bus_User admin;
        public Pres_Admin()
        {
            InitializeComponent();
            admin = new Bus_User();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Admin_Products pres_Admin_Products = new Pres_Admin_Products();
            pres_Admin_Products.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Admin_Users pres_admin_user = new Pres_Admin_Users();
            pres_admin_user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Pres_login pres_login = new Pres_login();
                pres_login.Show();
            }
        }
    }
}
