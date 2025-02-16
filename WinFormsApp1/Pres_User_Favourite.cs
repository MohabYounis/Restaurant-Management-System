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

namespace Mohab.Presentation
{
    public partial class Pres_User_Favourite : Form
    {
        Bus_Favourit busFav;
        int userID;

        public Pres_User_Favourite(int _userId)
        {
            InitializeComponent();
            busFav = new Bus_Favourit();
            userID = _userId;
        }

        private void Pres_User_Favourite_Load(object sender, EventArgs e)
        {
            btn_all.Select();

            dgv_fav.DataSource = busFav.GetAllFavProducts(userID);
            dgv_fav.Columns["Pro_Id"].Visible = false;
            dgv_fav.Columns["Cat_Id"].Visible = false;
            dgv_fav.Columns["U_Id"].Visible = false;
            dgv_fav.ColumnHeadersVisible = false;
            btn_removeAll.Visible = true;
            btn_removeBurg.Visible = false;
            btn_removePiz.Visible = false;
            btn_removeDes.Visible = false;

            txt_prodName.Text = "";

            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            dgv_fav.DataSource = busFav.GetAllFavProducts(userID);
            dgv_fav.Columns["Pro_Id"].Visible = false;
            dgv_fav.Columns["Cat_Id"].Visible = false;
            dgv_fav.Columns["U_Id"].Visible = false;
            dgv_fav.ColumnHeadersVisible = false;
            btn_removeAll.Visible = true;
            btn_removeBurg.Visible = false;
            btn_removePiz.Visible = false;
            btn_removeDes.Visible = false;

            txt_prodName.Text = "";

            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_burger_Click(object sender, EventArgs e)
        {
            dgv_fav.DataSource = busFav.GetAllFavProducts("1", userID);
            dgv_fav.Columns["Pro_Id"].Visible = false;
            dgv_fav.Columns["Cat_Id"].Visible = false;
            dgv_fav.Columns["U_Id"].Visible = false;
            dgv_fav.ColumnHeadersVisible = false;
            btn_removeAll.Visible = false;
            btn_removeBurg.Visible = true;
            btn_removePiz.Visible = false;
            btn_removeDes.Visible = false;

            txt_prodName.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(126, 27, 27);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_pizza_Click(object sender, EventArgs e)
        {
            dgv_fav.DataSource = busFav.GetAllFavProducts("2", userID);
            dgv_fav.Columns["Pro_Id"].Visible = false;
            dgv_fav.Columns["Cat_Id"].Visible = false;
            dgv_fav.Columns["U_Id"].Visible = false;
            dgv_fav.ColumnHeadersVisible = false;
            btn_removeAll.Visible = false;
            btn_removeBurg.Visible = false;
            btn_removePiz.Visible = true;
            btn_removeDes.Visible = false;

            txt_prodName.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_dessert.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_dessert_Click(object sender, EventArgs e)
        {
            dgv_fav.DataSource = busFav.GetAllFavProducts("3", userID);
            dgv_fav.Columns["Pro_Id"].Visible = false;
            dgv_fav.Columns["Cat_Id"].Visible = false;
            dgv_fav.Columns["U_Id"].Visible = false;
            dgv_fav.ColumnHeadersVisible = false;
            btn_removeAll.Visible = false;
            btn_removeBurg.Visible = false;
            btn_removePiz.Visible = false;
            btn_removeDes.Visible = true;

            txt_prodName.Text = "";

            btn_all.BackColor = Color.FromArgb(255, 255, 255);
            btn_burger.BackColor = Color.FromArgb(255, 255, 255);
            btn_pizza.BackColor = Color.FromArgb(255, 255, 255);
            btn_dessert.BackColor = Color.FromArgb(126, 27, 27);
        }

        int ProdId;
        private void dgv_fav_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProdId = (int)dgv_fav.SelectedRows[0].Cells[0].Value;

            DataGridViewRow row = dgv_fav.SelectedRows[0];

            txt_prodName.Text = row.Cells["Pro_Name"].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_prodName.Text = "";
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


        private void btn_removeAll_Click(object sender, EventArgs e)
        {
            string prod_name = txt_prodName.Text;

            if (MessageBox.Show($"Are You Sure You Want To Remove {prod_name} From Favourite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? rowsAffected = busFav.DeleteItemFromfvourite(userID, ProdId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{prod_name.ToUpper()} Deleted Successfully");
                    txt_prodName.Text = "";

                    dgv_fav.DataSource = busFav.GetAllFavProducts(userID);
                    dgv_fav.Columns["Pro_Id"].Visible = false;
                    dgv_fav.Columns["Cat_Id"].Visible = false;
                    dgv_fav.Columns["U_Id"].Visible = false;
                    dgv_fav.ColumnHeadersVisible = false;

                }
            }
        }

        private void btn_removeDes_Click(object sender, EventArgs e)
        {
            string prod_name = txt_prodName.Text;

            if (MessageBox.Show($"Are You Sure You Want To Remove {prod_name} From Favourite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? rowsAffected = busFav.DeleteItemFromfvourite(userID, ProdId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{prod_name.ToUpper()} Deleted Successfully");
                    txt_prodName.Text = "";

                    dgv_fav.DataSource = busFav.GetAllFavProducts("3", userID);
                    dgv_fav.Columns["Pro_Id"].Visible = false;
                    dgv_fav.Columns["Cat_Id"].Visible = false;
                    dgv_fav.Columns["U_Id"].Visible = false;
                    dgv_fav.ColumnHeadersVisible = false;

                }
            }
        }

        private void btn_removeBurg_Click(object sender, EventArgs e)
        {
            string prod_name = txt_prodName.Text;

            if (MessageBox.Show($"Are You Sure You Want To Remove {prod_name} From Favourite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? rowsAffected = busFav.DeleteItemFromfvourite(userID, ProdId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{prod_name.ToUpper()} Deleted Successfully");
                    txt_prodName.Text = "";

                    dgv_fav.DataSource = busFav.GetAllFavProducts("1", userID);
                    dgv_fav.Columns["Pro_Id"].Visible = false;
                    dgv_fav.Columns["Cat_Id"].Visible = false;
                    dgv_fav.Columns["U_Id"].Visible = false;
                    dgv_fav.ColumnHeadersVisible = false;

                }
            }
        }

        private void btn_removePiz_Click(object sender, EventArgs e)
        {
            string prod_name = txt_prodName.Text;

            if (MessageBox.Show($"Are You Sure You Want To Remove {prod_name} From Favourite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? rowsAffected = busFav.DeleteItemFromfvourite(userID, ProdId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{prod_name.ToUpper()} Deleted Successfully");
                    txt_prodName.Text = "";

                    dgv_fav.DataSource = busFav.GetAllFavProducts("2", userID);
                    dgv_fav.Columns["Pro_Id"].Visible = false;
                    dgv_fav.Columns["Cat_Id"].Visible = false;
                    dgv_fav.Columns["U_Id"].Visible = false;
                    dgv_fav.ColumnHeadersVisible = false;

                }
            }
        }

    }
}
