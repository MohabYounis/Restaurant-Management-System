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
    public partial class Pres_Admin_Products : Form
    {
        Bus_Product busProduct;
        public Pres_Admin_Products()
        {
            InitializeComponent();
            busProduct = new Bus_Product();
        }


        public void textBoxesAndLabelsVisibility(bool x)
        {
            txt_prodName.Visible = x;
            txt_prodPrice.Visible = x;
            lbl_prodName.Visible = x;
            lbl_prodPrice.Visible = x;
        }
        public void burgerButtonsVisibility(bool x)
        {
            btn_addBurg.Visible = x;
            btn_updateBurg.Visible = x;
            btn_removeBurg.Visible = x;
        }
        public void pizzaButtonsVisibility(bool x)
        {
            btn_addPizza.Visible = x;
            btn_updatePizza.Visible = x;
            btn_removePizza.Visible = x;
        }
        public void dessertButtonsVisibility(bool x)
        {
            btn_addDessert.Visible = x;
            btn_updateDessert.Visible = x;
            btn_removeDessert.Visible = x;
        }
        public void addItemsToSpecificCategory(int categoryId)
        {
            string prodName = txt_prodName.Text;
            int prodPrice = Convert.ToInt32(txt_prodPrice.Text);

            int rowsAffected = busProduct.AddItem(prodName, prodPrice, categoryId);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Added Successfully");
            }
        }
        public void updateItemsToSpecificCategory(int prodId)
        {
            string prodName = txt_prodName.Text;
            int prodPrice = Convert.ToInt32(txt_prodPrice.Text);

            int rowsAffected = busProduct.UpdateItem(prodName, prodPrice, prodId);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
        }
        public void deleteItemsToSpecificCategory(int prodId)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string prodName = txt_prodName.Text;
                int prodPrice = Convert.ToInt32(txt_prodPrice.Text);

                int rowsAffected = busProduct.DeleteItem(prodId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Removed Successfully");
                }
            }
        }

        private void Pres_Admin_Products_Load(object sender, EventArgs e)
        {
            btn_all.Select();

            dgv_prod.DataSource = busProduct.GetAllProducts();
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
            btn_clear.Visible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            burgerButtonsVisibility(false);

            pizzaButtonsVisibility(false);

            dessertButtonsVisibility(false);

            textBoxesAndLabelsVisibility(false);

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
            btn_clear.Visible = false;

            txt_prodName.Text = txt_prodPrice.Text = "";

            burgerButtonsVisibility(false);

            pizzaButtonsVisibility(false);

            dessertButtonsVisibility(false);

            textBoxesAndLabelsVisibility(false);

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
            btn_clear.Visible = true;

            txt_prodName.Text = txt_prodPrice.Text = "";

            burgerButtonsVisibility(true);

            pizzaButtonsVisibility(false);

            dessertButtonsVisibility(false);

            textBoxesAndLabelsVisibility(true);

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
            btn_clear.Visible = true;

            txt_prodName.Text = txt_prodPrice.Text = "";

            burgerButtonsVisibility(false);

            pizzaButtonsVisibility(true);

            dessertButtonsVisibility(false);

            textBoxesAndLabelsVisibility(true);

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
            btn_clear.Visible = true;

            txt_prodName.Text = txt_prodPrice.Text = "";

            burgerButtonsVisibility(false);

            pizzaButtonsVisibility(false);

            dessertButtonsVisibility(true);

            textBoxesAndLabelsVisibility(true);

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(126, 27, 27);
        }

        // Add Item  --------------------------------------------------------
        public void btn_addBurg_Click(object sender, EventArgs e)
        {
            addItemsToSpecificCategory(1);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("1");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        private void btn_addPizza_Click(object sender, EventArgs e)
        {
            addItemsToSpecificCategory(2);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("2");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        private void btn_addDessert_Click_1(object sender, EventArgs e)
        {
            addItemsToSpecificCategory(3);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("3");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        // ---------------------------------------------------------------------

        // Update Item  --------------------------------------------------------
        private void btn_updateBurg_Click(object sender, EventArgs e)
        {
            updateItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("1");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        private void btn_updatePizza_Click(object sender, EventArgs e)
        {
            updateItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("2");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        private void btn_updateDessert_Click(object sender, EventArgs e)
        {
            updateItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("3");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        // ---------------------------------------------------------------------

        // Delete Item  --------------------------------------------------------
        private void btn_removeBurg_Click(object sender, EventArgs e)
        {
            deleteItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("1");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        private void btn_removePizza_Click(object sender, EventArgs e)
        {
            deleteItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("2");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }

        private void btn_removeDessert_Click(object sender, EventArgs e)
        {
            deleteItemsToSpecificCategory(id);

            txt_prodName.Text = txt_prodPrice.Text = "";

            dgv_prod.DataSource = busProduct.GetAllCategoryProducts("3");
            dgv_prod.Columns["Pro_Id"].Visible = false;
            dgv_prod.Columns["Cat_Id"].Visible = false;
            dgv_prod.ColumnHeadersVisible = false;
        }
        // ---------------------------------------------------------------------

        int id;
        private void dgv_prod_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_prod.SelectedRows[0].Cells[0].Value;

            DataGridViewRow row = dgv_prod.SelectedRows[0];

            txt_prodName.Text = row.Cells["Pro_Name"].Value.ToString();
            txt_prodPrice.Text = row.Cells["Pro_Price"].Value.ToString();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_prodName.Text = txt_prodPrice.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Admin pres_Admin = new Pres_Admin();
            pres_Admin.Show();
        }
    }
}
