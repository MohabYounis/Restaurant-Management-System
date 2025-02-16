namespace Mohab.Presentation
{
    partial class Pres_User_Favourite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_User_Favourite));
            btn_clear = new Button();
            label1 = new Label();
            lbl_prodName = new Label();
            txt_prodName = new TextBox();
            button1 = new Button();
            button4 = new Button();
            btn_removeAll = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgv_fav = new DataGridView();
            btn_all = new Button();
            btn_dessert = new Button();
            btn_pizza = new Button();
            btn_burger = new Button();
            btn_removePiz = new Button();
            btn_removeBurg = new Button();
            btn_removeDes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_fav).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(126, 27, 27);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 10F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(447, 258);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(89, 98);
            btn_clear.TabIndex = 76;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(126, 27, 27);
            label1.Location = new Point(72, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(14, 5, 14, 5);
            label1.Size = new Size(456, 56);
            label1.TabIndex = 75;
            label1.Text = "My Favourite";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_prodName
            // 
            lbl_prodName.AutoSize = true;
            lbl_prodName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_prodName.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_prodName.Location = new Point(63, 266);
            lbl_prodName.Name = "lbl_prodName";
            lbl_prodName.Size = new Size(73, 23);
            lbl_prodName.TabIndex = 73;
            lbl_prodName.Text = "Product";
            // 
            // txt_prodName
            // 
            txt_prodName.Location = new Point(146, 266);
            txt_prodName.Multiline = true;
            txt_prodName.Name = "txt_prodName";
            txt_prodName.ReadOnly = true;
            txt_prodName.Size = new Size(275, 27);
            txt_prodName.TabIndex = 71;
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
            button1.TabIndex = 70;
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
            button4.TabIndex = 69;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_removeAll
            // 
            btn_removeAll.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeAll.Cursor = Cursors.Hand;
            btn_removeAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_removeAll.ForeColor = Color.White;
            btn_removeAll.Location = new Point(63, 310);
            btn_removeAll.Name = "btn_removeAll";
            btn_removeAll.Size = new Size(358, 46);
            btn_removeAll.TabIndex = 68;
            btn_removeAll.Text = "Remove From Favourite";
            btn_removeAll.UseVisualStyleBackColor = false;
            btn_removeAll.Click += btn_removeAll_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(457, 212);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 67;
            label8.Text = "Dessert";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(333, 212);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 66;
            label7.Text = "Pizza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(207, 212);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 65;
            label6.Text = "Burger";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(92, 212);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 64;
            label5.Text = "All";
            // 
            // dgv_fav
            // 
            dgv_fav.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_fav.BackgroundColor = Color.White;
            dgv_fav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_fav.Dock = DockStyle.Bottom;
            dgv_fav.Location = new Point(0, 411);
            dgv_fav.Name = "dgv_fav";
            dgv_fav.RowHeadersWidth = 51;
            dgv_fav.Size = new Size(600, 289);
            dgv_fav.TabIndex = 63;
            dgv_fav.RowHeaderMouseDoubleClick += dgv_fav_RowHeaderMouseDoubleClick;
            // 
            // btn_all
            // 
            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_all.BackgroundImage = (Image)resources.GetObject("btn_all.BackgroundImage");
            btn_all.BackgroundImageLayout = ImageLayout.Center;
            btn_all.Cursor = Cursors.Hand;
            btn_all.Location = new Point(63, 105);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(94, 88);
            btn_all.TabIndex = 62;
            btn_all.UseVisualStyleBackColor = false;
            btn_all.Click += btn_all_Click;
            // 
            // btn_dessert
            // 
            btn_dessert.BackColor = Color.FromArgb(126, 27, 27);
            btn_dessert.BackgroundImage = (Image)resources.GetObject("btn_dessert.BackgroundImage");
            btn_dessert.BackgroundImageLayout = ImageLayout.Center;
            btn_dessert.Cursor = Cursors.Hand;
            btn_dessert.Location = new Point(442, 105);
            btn_dessert.Name = "btn_dessert";
            btn_dessert.Size = new Size(94, 88);
            btn_dessert.TabIndex = 61;
            btn_dessert.UseVisualStyleBackColor = false;
            btn_dessert.Click += btn_dessert_Click;
            // 
            // btn_pizza
            // 
            btn_pizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_pizza.BackgroundImage = (Image)resources.GetObject("btn_pizza.BackgroundImage");
            btn_pizza.BackgroundImageLayout = ImageLayout.Center;
            btn_pizza.Cursor = Cursors.Hand;
            btn_pizza.Location = new Point(315, 105);
            btn_pizza.Name = "btn_pizza";
            btn_pizza.Size = new Size(94, 88);
            btn_pizza.TabIndex = 60;
            btn_pizza.UseVisualStyleBackColor = false;
            btn_pizza.Click += btn_pizza_Click;
            // 
            // btn_burger
            // 
            btn_burger.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackgroundImage = (Image)resources.GetObject("btn_burger.BackgroundImage");
            btn_burger.BackgroundImageLayout = ImageLayout.Center;
            btn_burger.Cursor = Cursors.Hand;
            btn_burger.Location = new Point(193, 105);
            btn_burger.Name = "btn_burger";
            btn_burger.Size = new Size(94, 88);
            btn_burger.TabIndex = 59;
            btn_burger.UseVisualStyleBackColor = false;
            btn_burger.Click += btn_burger_Click;
            // 
            // btn_removePiz
            // 
            btn_removePiz.BackColor = Color.FromArgb(126, 27, 27);
            btn_removePiz.Cursor = Cursors.Hand;
            btn_removePiz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_removePiz.ForeColor = Color.White;
            btn_removePiz.Location = new Point(63, 310);
            btn_removePiz.Name = "btn_removePiz";
            btn_removePiz.Size = new Size(358, 46);
            btn_removePiz.TabIndex = 77;
            btn_removePiz.Text = "Remove From Favourite";
            btn_removePiz.UseVisualStyleBackColor = false;
            btn_removePiz.Click += btn_removePiz_Click;
            // 
            // btn_removeBurg
            // 
            btn_removeBurg.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeBurg.Cursor = Cursors.Hand;
            btn_removeBurg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_removeBurg.ForeColor = Color.White;
            btn_removeBurg.Location = new Point(63, 310);
            btn_removeBurg.Name = "btn_removeBurg";
            btn_removeBurg.Size = new Size(358, 46);
            btn_removeBurg.TabIndex = 78;
            btn_removeBurg.Text = "Remove From Favourite";
            btn_removeBurg.UseVisualStyleBackColor = false;
            btn_removeBurg.Click += btn_removeBurg_Click;
            // 
            // btn_removeDes
            // 
            btn_removeDes.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeDes.Cursor = Cursors.Hand;
            btn_removeDes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_removeDes.ForeColor = Color.White;
            btn_removeDes.Location = new Point(63, 310);
            btn_removeDes.Name = "btn_removeDes";
            btn_removeDes.Size = new Size(358, 46);
            btn_removeDes.TabIndex = 79;
            btn_removeDes.Text = "Remove From Favourite";
            btn_removeDes.UseVisualStyleBackColor = false;
            btn_removeDes.Click += btn_removeDes_Click;
            // 
            // Pres_User_Favourite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(btn_removeDes);
            Controls.Add(btn_removeBurg);
            Controls.Add(btn_removePiz);
            Controls.Add(btn_clear);
            Controls.Add(label1);
            Controls.Add(lbl_prodName);
            Controls.Add(txt_prodName);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(btn_removeAll);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgv_fav);
            Controls.Add(btn_all);
            Controls.Add(btn_dessert);
            Controls.Add(btn_pizza);
            Controls.Add(btn_burger);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_User_Favourite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_User_Favourite";
            Load += Pres_User_Favourite_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_fav).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clear;
        private Label label1;
        private Label lbl_prodName;
        private TextBox txt_prodName;
        private Button button1;
        private Button button4;
        private Button btn_removeAll;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgv_fav;
        private Button btn_all;
        private Button btn_dessert;
        private Button btn_pizza;
        private Button btn_burger;
        private Button btn_removePiz;
        private Button btn_removeBurg;
        private Button btn_removeDes;
    }
}