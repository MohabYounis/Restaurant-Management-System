using Mohab.Business;
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
    public partial class Pres_User_Prod : Form
    {
        Bus_Product busProduct;
        Bus_Favourit busFavourt;
        Bus_User bus_User;

        int userID; 
        public Pres_User_Prod()
        {
            
        }

        public Pres_User_Prod(int _userId)
        {
            InitializeComponent();
            busProduct = new Bus_Product();
            busFavourt = new Bus_Favourit();
            bus_User = new Bus_User();
            userID = _userId;
        }


        private void Pres_User_Prod_Load(object sender, EventArgs e)
        {
            btn_all.Select();

            dgv_prod.DataSource = busProduct.GetAllProducts();
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            dgv_prod.DataSource = busProduct.GetAllProducts();
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_burger_Click(object sender, EventArgs e)
        {
            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("1");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(126, 27, 27);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_pizza_Click(object sender, EventArgs e)
        {
            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("2");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_dessert_Click(object sender, EventArgs e)
        {
            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("3");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(126, 27, 27);
        }

        int ProdId;
        private void dgv_prod_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProdId = (int)dgv_prod.SelectedRows[0].Cells[0].Value;

            DataGridViewRow row = dgv_prod.SelectedRows[0];

            txt_prodName.Text = row.Cells["Pro_Name"].Value.ToString();
            txt_prodPrice.Text = row.Cells["Pro_Price"].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_prodName.Text = txt_prodPrice.Text = "";
        }

        private void btn_addBurg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add To Favourite?", "Favourite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                // Product Name
                string prod_name = txt_prodName.Text;

                int? rowsAffected = busFavourt.AddItemToFavourite(userID, ProdId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{prod_name.ToUpper()} Added Successfully");
                    txt_prodName.Text = txt_prodPrice.Text = "";
                }
                else
                {
                    MessageBox.Show($"{prod_name.ToUpper()} is already Added");
                    txt_prodName.Text = txt_prodPrice.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_User pres_user = new Pres_User(userID);
            pres_user.Show();
        }

    }
}
