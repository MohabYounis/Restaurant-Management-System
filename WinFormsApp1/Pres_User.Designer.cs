namespace Mohab.Presentation
{
    partial class Pres_User
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
            button1 = new Button();
            button4 = new Button();
            btn_favourit = new Button();
            btn_product = new Button();
            lbl_admin = new Label();
            lbl_adminName = new Label();
            SuspendLayout();
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
            button1.TabIndex = 33;
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
            button4.Location = new Point(508, 12);
            button4.Name = "button4";
            button4.Size = new Size(80, 35);
            button4.TabIndex = 32;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_favourit
            // 
            btn_favourit.BackColor = Color.FromArgb(126, 27, 27);
            btn_favourit.Cursor = Cursors.Hand;
            btn_favourit.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_favourit.ForeColor = Color.White;
            btn_favourit.Location = new Point(170, 381);
            btn_favourit.Name = "btn_favourit";
            btn_favourit.Size = new Size(248, 52);
            btn_favourit.TabIndex = 31;
            btn_favourit.Text = "View Favourits";
            btn_favourit.UseVisualStyleBackColor = false;
            btn_favourit.Click += btn_favourit_Click;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(126, 27, 27);
            btn_product.Cursor = Cursors.Hand;
            btn_product.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(170, 282);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(248, 52);
            btn_product.TabIndex = 30;
            btn_product.Text = "View Products";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // lbl_admin
            // 
            lbl_admin.BackColor = Color.White;
            lbl_admin.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_admin.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_admin.Location = new Point(12, 50);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(576, 46);
            lbl_admin.TabIndex = 29;
            lbl_admin.Text = "Welcome User";
            lbl_admin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_adminName
            // 
            lbl_adminName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lbl_adminName.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_adminName.Location = new Point(12, 114);
            lbl_adminName.Name = "lbl_adminName";
            lbl_adminName.Size = new Size(576, 50);
            lbl_adminName.TabIndex = 34;
            lbl_adminName.Text = "name";
            lbl_adminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pres_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(lbl_adminName);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(btn_favourit);
            Controls.Add(btn_product);
            Controls.Add(lbl_admin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_User";
            Load += Pres_User_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button btn_favourit;
        private Button btn_product;
        private Label lbl_admin;
        private Label lbl_adminName;
    }
}