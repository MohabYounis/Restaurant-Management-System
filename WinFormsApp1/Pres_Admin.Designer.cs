namespace Mohab.Presentation
{
    partial class Pres_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Admin));
            pictureBox1 = new PictureBox();
            lbl_admin = new Label();
            btn_product = new Button();
            btn_users = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(218, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_admin
            // 
            lbl_admin.AutoSize = true;
            lbl_admin.BackColor = Color.White;
            lbl_admin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_admin.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_admin.Location = new Point(171, 155);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(249, 41);
            lbl_admin.TabIndex = 1;
            lbl_admin.Text = "Welcome Admin";
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(126, 27, 27);
            btn_product.Cursor = Cursors.Hand;
            btn_product.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(155, 281);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(274, 52);
            btn_product.TabIndex = 2;
            btn_product.Text = "View Products";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // btn_users
            // 
            btn_users.BackColor = Color.FromArgb(126, 27, 27);
            btn_users.Cursor = Cursors.Hand;
            btn_users.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_users.ForeColor = Color.White;
            btn_users.Location = new Point(155, 387);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(274, 52);
            btn_users.TabIndex = 3;
            btn_users.Text = "View Users";
            btn_users.UseVisualStyleBackColor = false;
            btn_users.Click += btn_users_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(126, 27, 27);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(80, 35);
            button1.TabIndex = 27;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(126, 27, 27);
            button4.Location = new Point(508, 11);
            button4.Name = "button4";
            button4.Size = new Size(80, 35);
            button4.TabIndex = 26;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Pres_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(btn_users);
            Controls.Add(btn_product);
            Controls.Add(lbl_admin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_admin;
        private Button btn_product;
        private Button btn_users;
        private Button button1;
        private Button button4;
    }
}