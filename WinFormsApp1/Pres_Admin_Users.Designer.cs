namespace Mohab.Presentation
{
    partial class Pres_Admin_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_users = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            btn_removeUser = new Button();
            btn_updateUser = new Button();
            label1 = new Label();
            txt_userEmail = new TextBox();
            cb_userRole = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_users.BackgroundColor = Color.White;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Dock = DockStyle.Bottom;
            dgv_users.Location = new Point(0, 391);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(600, 309);
            dgv_users.TabIndex = 0;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(126, 27, 27);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 29);
            button1.TabIndex = 21;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(126, 27, 27);
            button4.Location = new Point(534, 12);
            button4.Name = "button4";
            button4.Size = new Size(54, 29);
            button4.TabIndex = 20;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_removeUser
            // 
            btn_removeUser.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeUser.Cursor = Cursors.Hand;
            btn_removeUser.Font = new Font("Segoe UI", 10F);
            btn_removeUser.ForeColor = Color.White;
            btn_removeUser.Location = new Point(321, 250);
            btn_removeUser.Name = "btn_removeUser";
            btn_removeUser.Size = new Size(155, 46);
            btn_removeUser.TabIndex = 24;
            btn_removeUser.Text = "Remove";
            btn_removeUser.UseVisualStyleBackColor = false;
            btn_removeUser.Click += btn_removeUser_Click;
            // 
            // btn_updateUser
            // 
            btn_updateUser.BackColor = Color.FromArgb(126, 27, 27);
            btn_updateUser.Cursor = Cursors.Hand;
            btn_updateUser.Font = new Font("Segoe UI", 10F);
            btn_updateUser.ForeColor = Color.White;
            btn_updateUser.Location = new Point(124, 250);
            btn_updateUser.Name = "btn_updateUser";
            btn_updateUser.Size = new Size(155, 46);
            btn_updateUser.TabIndex = 23;
            btn_updateUser.Text = "Update";
            btn_updateUser.UseVisualStyleBackColor = false;
            btn_updateUser.Click += btn_updateUser_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(126, 27, 27);
            label1.Location = new Point(70, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 5, 10, 5);
            label1.Size = new Size(458, 58);
            label1.TabIndex = 25;
            label1.Text = "Users Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_userEmail
            // 
            txt_userEmail.Location = new Point(184, 121);
            txt_userEmail.Multiline = true;
            txt_userEmail.Name = "txt_userEmail";
            txt_userEmail.ReadOnly = true;
            txt_userEmail.Size = new Size(210, 27);
            txt_userEmail.TabIndex = 26;
            // 
            // cb_userRole
            // 
            cb_userRole.FormattingEnabled = true;
            cb_userRole.Location = new Point(184, 170);
            cb_userRole.Name = "cb_userRole";
            cb_userRole.Size = new Size(210, 28);
            cb_userRole.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(126, 27, 27);
            label2.Location = new Point(124, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 28;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(126, 27, 27);
            label3.Location = new Point(124, 171);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 29;
            label3.Text = "Role";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(126, 27, 27);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 10F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(409, 121);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(67, 77);
            btn_clear.TabIndex = 30;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Pres_Admin_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(btn_clear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_userRole);
            Controls.Add(txt_userEmail);
            Controls.Add(label1);
            Controls.Add(btn_removeUser);
            Controls.Add(btn_updateUser);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dgv_users);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Admin_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Admin_Users";
            Load += Pres_Admin_Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_users;
        private Button button1;
        private Button button4;
        private Button btn_removeUser;
        private Button btn_updateUser;
        private Label label1;
        private TextBox txt_userEmail;
        private ComboBox cb_userRole;
        private Label label2;
        private Label label3;
        private Button btn_clear;
    }
}