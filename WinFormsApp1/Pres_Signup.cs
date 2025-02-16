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
    public partial class Pres_Signup : Form
    {
        Bus_User user;
        public Pres_Signup()
        {
            InitializeComponent();
            user = new Bus_User();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string userEmail = txt_email.Text;
            string userPass = txt_pass.Text;
            int userAge = (int)num_age.Value;
            string userAddress = txt_address.Text;

            DataTable dtUser = new DataTable();
            dtUser = user.NewUserCheckByEmail(userEmail);

            if (dtUser.Rows.Count > 0)
            {
                MessageBox.Show("This Email is already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int rowAffect = user.Add(userName, userPass, userEmail, userAge, userAddress);
                if (rowAffect > 0)
                {
                    MessageBox.Show($"Welcome {userName}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Pres_login pres_Login = new Pres_login();
                    pres_Login.Show();
                }
            }

        }

        private void lbl_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Pres_login pres_Login = new Pres_login();
            pres_Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_login pres_login = new Pres_login();
            pres_login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
