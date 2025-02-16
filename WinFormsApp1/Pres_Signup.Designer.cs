namespace Mohab.Presentation
{
    partial class Pres_Signup
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
            pct_box1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            lbl_signUp = new LinkLabel();
            groupBox5 = new GroupBox();
            txt_address = new TextBox();
            groupBox6 = new GroupBox();
            num_age = new NumericUpDown();
            btn_register = new Button();
            groupBox4 = new GroupBox();
            txt_pass = new TextBox();
            groupBox2 = new GroupBox();
            txt_email = new TextBox();
            groupBox1 = new GroupBox();
            txt_userName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_box1).BeginInit();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pct_box1
            // 
            pct_box1.BackColor = Color.FromArgb(126, 27, 27);
            pct_box1.BackgroundImage = Properties.Resources.pexels_jonathan_borba_19247567_removebg_preview_2x;
            pct_box1.BackgroundImageLayout = ImageLayout.Stretch;
            pct_box1.Location = new Point(216, 69);
            pct_box1.Name = "pct_box1";
            pct_box1.Size = new Size(150, 105);
            pct_box1.TabIndex = 3;
            pct_box1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_signUp);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(96, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 491);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(98, 442);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 13;
            label3.Text = "Do have account?";
            // 
            // lbl_signUp
            // 
            lbl_signUp.AutoSize = true;
            lbl_signUp.Cursor = Cursors.Hand;
            lbl_signUp.Font = new Font("Segoe UI", 10F);
            lbl_signUp.ForeColor = Color.FromArgb(126, 27, 2);
            lbl_signUp.LinkBehavior = LinkBehavior.NeverUnderline;
            lbl_signUp.LinkColor = Color.FromArgb(126, 27, 2);
            lbl_signUp.Location = new Point(241, 442);
            lbl_signUp.Name = "lbl_signUp";
            lbl_signUp.Size = new Size(52, 23);
            lbl_signUp.TabIndex = 12;
            lbl_signUp.TabStop = true;
            lbl_signUp.Text = "Login";
            lbl_signUp.LinkClicked += lbl_signUp_LinkClicked;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_address);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox5.ForeColor = Color.FromArgb(126, 27, 2);
            groupBox5.Location = new Point(45, 293);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(306, 64);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Cursor = Cursors.Hand;
            txt_address.Font = new Font("Segoe UI", 9F);
            txt_address.Location = new Point(12, 26);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(277, 27);
            txt_address.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(num_age);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox6.ForeColor = Color.FromArgb(126, 27, 2);
            groupBox6.Location = new Point(45, 223);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(306, 64);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Age";
            // 
            // num_age
            // 
            num_age.Cursor = Cursors.Hand;
            num_age.Font = new Font("Segoe UI", 9F);
            num_age.Location = new Point(12, 26);
            num_age.Name = "num_age";
            num_age.Size = new Size(277, 27);
            num_age.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(126, 27, 27);
            btn_register.Cursor = Cursors.Hand;
            btn_register.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(120, 375);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(150, 47);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_pass);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(126, 27, 2);
            groupBox4.Location = new Point(45, 153);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(306, 64);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Cursor = Cursors.Hand;
            txt_pass.Font = new Font("Segoe UI", 9F);
            txt_pass.Location = new Point(12, 26);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(277, 27);
            txt_pass.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_email);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(126, 27, 2);
            groupBox2.Location = new Point(45, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 64);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Cursor = Cursors.Hand;
            txt_email.Font = new Font("Segoe UI", 9F);
            txt_email.Location = new Point(12, 26);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "example@email.com";
            txt_email.Size = new Size(277, 27);
            txt_email.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_userName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(126, 27, 2);
            groupBox1.Location = new Point(45, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 64);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // txt_userName
            // 
            txt_userName.Cursor = Cursors.Hand;
            txt_userName.Font = new Font("Segoe UI", 9F);
            txt_userName.Location = new Point(12, 26);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "name";
            txt_userName.ShortcutsEnabled = false;
            txt_userName.Size = new Size(277, 27);
            txt_userName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(126, 27, 27);
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 57);
            label1.TabIndex = 4;
            label1.Text = "Register";
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
            // Pres_Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 27, 2);
            ClientSize = new Size(600, 700);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(pct_box1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Signup";
            ((System.ComponentModel.ISupportInitialize)pct_box1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_box1;
        private Panel panel1;
        private Button btn_register;
        private GroupBox groupBox4;
        private TextBox txt_pass;
        private GroupBox groupBox2;
        private TextBox txt_email;
        private GroupBox groupBox1;
        private TextBox txt_userName;
        private Label label1;
        private GroupBox groupBox5;
        private TextBox txt_address;
        private GroupBox groupBox6;
        private NumericUpDown num_age;
        private Label label3;
        private LinkLabel lbl_signUp;
        private Button button1;
        private Button button4;
    }
}