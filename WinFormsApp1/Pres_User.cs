using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Mohab.Business;

namespace Mohab.Presentation
{
    public partial class Pres_User : Form
    {
        Bus_Product bus_prod;
        Bus_Favourit bus_fav;
        Bus_User bus_user;
        int UserID;

        public Pres_User(int _UserId)
        {
            InitializeComponent();
            bus_fav = new Bus_Favourit();
            bus_prod = new Bus_Product();
            bus_user = new Bus_User();
            UserID = _UserId;
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

        private void btn_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_User_Prod pres_user_prod = new Pres_User_Prod(UserID);
            pres_user_prod.Show();
        }

        private void btn_favourit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_User_Favourite pres_user_favourite = new Pres_User_Favourite(UserID);
            pres_user_favourite.Show();
        }


        private void Pres_User_Load(object sender, EventArgs e)
        {
            string userName = bus_user.GetUserNameById(UserID);
            lbl_adminName.Text = userName.ToUpper();
        }
    }
}
