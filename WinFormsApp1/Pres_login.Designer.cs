namespace Mohab.Presentation
{
    partial class Pres_login
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
            label1 = new Label();
            panel1 = new Panel();
            checkBox_showPass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            lbl_signUp = new LinkLabel();
            linkLabel1 = new LinkLabel();
            btn_login = new Button();
            groupBox2 = new GroupBox();
            txt_pass = new TextBox();
            groupBox1 = new GroupBox();
            txt_email = new TextBox();
            pct_box1 = new PictureBox();
            button1 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pct_box1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(126, 27, 27);
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 57);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox_showPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_signUp);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(95, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 450);
            panel1.TabIndex = 2;
            // 
            // checkBox_showPass
            // 
            checkBox_showPass.AutoSize = true;
            checkBox_showPass.Cursor = Cursors.Hand;
            checkBox_showPass.Location = new Point(213, 184);
            checkBox_showPass.Name = "checkBox_showPass";
            checkBox_showPass.Size = new Size(132, 24);
            checkBox_showPass.TabIndex = 12;
            checkBox_showPass.Text = "Show Password";
            checkBox_showPass.UseVisualStyleBackColor = true;
            checkBox_showPass.CheckedChanged += checkBox_showPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(60, 365);
            label3.Name = "label3";
            label3.Size = new Size(199, 23);
            label3.TabIndex = 11;
            label3.Text = "Don't have any account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(172, 331);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 10;
            label2.Text = "OR";
            // 
            // lbl_signUp
            // 
            lbl_signUp.AutoSize = true;
            lbl_signUp.Cursor = Cursors.Hand;
            lbl_signUp.Font = new Font("Segoe UI", 10F);
            lbl_signUp.ForeColor = Color.FromArgb(126, 27, 2);
            lbl_signUp.LinkBehavior = LinkBehavior.NeverUnderline;
            lbl_signUp.LinkColor = Color.FromArgb(126, 27, 2);
            lbl_signUp.Location = new Point(256, 365);
            lbl_signUp.Name = "lbl_signUp";
            lbl_signUp.Size = new Size(68, 23);
            lbl_signUp.TabIndex = 9;
            lbl_signUp.TabStop = true;
            lbl_signUp.Text = "Sign up";
            lbl_signUp.LinkClicked += lbl_signUp_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(126, 27, 27);
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.ForeColor = Color.FromArgb(126, 27, 27);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(126, 27, 27);
            linkLabel1.Location = new Point(123, 298);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 23);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            linkLabel1.VisitedLinkColor = Color.FromArgb(126, 27, 27);
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(126, 27, 27);
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(119, 214);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(152, 47);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_pass);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(126, 27, 27);
            groupBox2.Location = new Point(37, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 64);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Cursor = Cursors.Hand;
            txt_pass.Font = new Font("Segoe UI", 9F);
            txt_pass.Location = new Point(12, 26);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(284, 27);
            txt_pass.TabIndex = 3;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_email);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(126, 27, 27);
            groupBox1.Location = new Point(37, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 64);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Cursor = Cursors.Hand;
            txt_email.Font = new Font("Segoe UI", 9F);
            txt_email.Location = new Point(12, 26);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "example@email.com";
            txt_email.Size = new Size(284, 27);
            txt_email.TabIndex = 3;
            // 
            // pct_box1
            // 
            pct_box1.BackColor = Color.FromArgb(126, 27, 27);
            pct_box1.BackgroundImage = Properties.Resources.pexels_jonathan_borba_19247567_removebg_preview_2x;
            pct_box1.BackgroundImageLayout = ImageLayout.Stretch;
            pct_box1.Location = new Point(214, 72);
            pct_box1.Name = "pct_box1";
            pct_box1.Size = new Size(152, 116);
            pct_box1.TabIndex = 0;
            pct_box1.TabStop = false;
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
            button1.TabIndex = 72;
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
            button4.TabIndex = 71;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Pres_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 27, 27);
            ClientSize = new Size(600, 700);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(pct_box1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pct_box1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pct_box1;
        private TextBox txt_email;
        private Button btn_login;
        private GroupBox groupBox2;
        private TextBox txt_pass;
        private GroupBox groupBox1;
        private Label label2;
        private LinkLabel lbl_signUp;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button1;
        private Button button4;
        private CheckBox checkBox_showPass;
    }
}