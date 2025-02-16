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
    public partial class Pres_Admin_Users : Form
    {
        Bus_User bus_User;
        public Pres_Admin_Users()
        {
            InitializeComponent();
            bus_User = new Bus_User();
        }

        private void Pres_Admin_Users_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = bus_User.SelectAllUsers();
            dgv_users.Columns["U_Id"].Visible = false;
            dgv_users.Columns["U_Pass"].Visible = false;
            dgv_users.ColumnHeadersVisible = false;

            cb_userRole.Items.Clear();
            cb_userRole.Items.Add("user");
            cb_userRole.Items.Add("admin");
            cb_userRole.SelectedIndex = -1;
        }

        int id;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_users.SelectedRows[0].Cells[0].Value;

            DataGridViewRow row = dgv_users.SelectedRows[0];

            txt_userEmail.Text = row.Cells["U_Email"].Value.ToString();
            cb_userRole.SelectedItem = row.Cells["U_Role"].Value.ToString();
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            string userRole = cb_userRole.SelectedItem.ToString();

            int rowsAffected = bus_User.EditRole(userRole, id);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfuly");
            }

            txt_userEmail.Text = "";
            cb_userRole.SelectedIndex = -1;

            dgv_users.DataSource = bus_User.SelectAllUsers();
            dgv_users.Columns["U_Id"].Visible = false;
            dgv_users.Columns["U_Pass"].Visible = false;
            dgv_users.ColumnHeadersVisible = false;
        }

        private void btn_removeUser_Click(object sender, EventArgs e)
        {
            string role = cb_userRole.SelectedItem.ToString();

            if (MessageBox.Show($"Are you sure you want to delete this {role.ToUpper()}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowsAffected = bus_User.DeleteUserOrAdmin(id);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Removed Successfully");
                }

                dgv_users.DataSource = bus_User.SelectAllUsers();
                dgv_users.Columns["U_Id"].Visible = false;
                dgv_users.Columns["U_Pass"].Visible = false;
                dgv_users.ColumnHeadersVisible = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_userEmail.Text = "";
            cb_userRole.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Admin pres_admin = new Pres_Admin();
            pres_admin.Show();
        }
    }
}
