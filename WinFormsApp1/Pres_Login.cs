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
using WinFormsApp1;

namespace Mohab.Presentation
{
    public partial class Pres_login : Form
    {
        Bus_User user;
        public Pres_login()
        {
            InitializeComponent();
            user = new Bus_User();
        }


        private void login_Load(object sender, EventArgs e)
        {
            pct_box1.BringToFront();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //check existancy of user
            string email = txt_email.Text;
            string pass = txt_pass.Text;

            DataTable selectUser = new DataTable();
            selectUser = user.GetUser(email, pass);

            if (selectUser.Rows.Count > 0)
            {
                DataRow firRow = selectUser.Rows[0];
                int UserId = Convert.ToInt32(firRow["U_Id"].ToString());

                if (firRow["U_Role"].ToString() == "admin")
                {
                    Pres_Admin pres_admin = new Pres_Admin();
                    pres_admin.Show();
                }
                else
                {
                    Pres_User pres_user = new Pres_User(UserId);
                    pres_user.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //---------------------------------------------------------------

        }


        private void lbl_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Pres_Signup pres_Signup = new Pres_Signup();
            pres_Signup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Start pres_Start = new Pres_Start();
            pres_Start.Show();
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !checkBox_showPass.Checked;
        }
    }
}
