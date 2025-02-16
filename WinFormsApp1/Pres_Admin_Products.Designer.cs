namespace Mohab.Presentation
{
    partial class Pres_Admin_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Admin_Products));
            btn_burger = new Button();
            btn_pizza = new Button();
            btn_dessert = new Button();
            btn_all = new Button();
            dgv_prod = new DataGridView();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_addBurg = new Button();
            btn_updateBurg = new Button();
            btn_removeBurg = new Button();
            button4 = new Button();
            btn_removePizza = new Button();
            btn_updatePizza = new Button();
            btn_addPizza = new Button();
            btn_removeDessert = new Button();
            btn_updateDessert = new Button();
            btn_addDessert = new Button();
            button1 = new Button();
            txt_prodName = new TextBox();
            txt_prodPrice = new TextBox();
            lbl_prodName = new Label();
            lbl_prodPrice = new Label();
            label6 = new Label();
            btn_clear = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_prod).BeginInit();
            SuspendLayout();
            // 
            // btn_burger
            // 
            btn_burger.BackColor = Color.FromArgb(126, 27, 27);
            btn_burger.BackgroundImage = (Image)resources.GetObject("btn_burger.BackgroundImage");
            btn_burger.BackgroundImageLayout = ImageLayout.Center;
            btn_burger.Cursor = Cursors.Hand;
            btn_burger.Location = new Point(190, 83);
            btn_burger.Name = "btn_burger";
            btn_burger.Size = new Size(94, 88);
            btn_burger.TabIndex = 0;
            btn_burger.UseVisualStyleBackColor = false;
            btn_burger.Click += btn_burger_Click;
            // 
            // btn_pizza
            // 
            btn_pizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_pizza.BackgroundImage = (Image)resources.GetObject("btn_pizza.BackgroundImage");
            btn_pizza.BackgroundImageLayout = ImageLayout.Center;
            btn_pizza.Cursor = Cursors.Hand;
            btn_pizza.Location = new Point(312, 83);
            btn_pizza.Name = "btn_pizza";
            btn_pizza.Size = new Size(94, 88);
            btn_pizza.TabIndex = 1;
            btn_pizza.UseVisualStyleBackColor = false;
            btn_pizza.Click += btn_pizza_Click;
            // 
            // btn_dessert
            // 
            btn_dessert.BackColor = Color.FromArgb(126, 27, 27);
            btn_dessert.BackgroundImage = (Image)resources.GetObject("btn_dessert.BackgroundImage");
            btn_dessert.BackgroundImageLayout = ImageLayout.Center;
            btn_dessert.Cursor = Cursors.Hand;
            btn_dessert.Location = new Point(439, 83);
            btn_dessert.Name = "btn_dessert";
            btn_dessert.Size = new Size(94, 88);
            btn_dessert.TabIndex = 2;
            btn_dessert.UseVisualStyleBackColor = false;
            btn_dessert.Click += btn_dessert_Click;
            // 
            // btn_all
            // 
            btn_all.BackColor = Color.FromArgb(126, 27, 27);
            btn_all.BackgroundImage = (Image)resources.GetObject("btn_all.BackgroundImage");
            btn_all.BackgroundImageLayout = ImageLayout.Center;
            btn_all.Cursor = Cursors.Hand;
            btn_all.Location = new Point(60, 83);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(94, 88);
            btn_all.TabIndex = 3;
            btn_all.UseVisualStyleBackColor = false;
            btn_all.Click += btn_all_Click;
            // 
            // dgv_prod
            // 
            dgv_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_prod.BackgroundColor = Color.White;
            dgv_prod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prod.Dock = DockStyle.Bottom;
            dgv_prod.Location = new Point(0, 427);
            dgv_prod.Name = "dgv_prod";
            dgv_prod.RowHeadersWidth = 51;
            dgv_prod.Size = new Size(600, 273);
            dgv_prod.TabIndex = 4;
            dgv_prod.RowHeaderMouseDoubleClick += dgv_prod_RowHeaderMouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(89, 190);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 5;
            label5.Text = "All";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(330, 190);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 7;
            label7.Text = "Pizza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(454, 190);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 8;
            label8.Text = "Dessert";
            // 
            // btn_addBurg
            // 
            btn_addBurg.BackColor = Color.FromArgb(126, 27, 27);
            btn_addBurg.Cursor = Cursors.Hand;
            btn_addBurg.Font = new Font("Segoe UI", 10F);
            btn_addBurg.ForeColor = Color.White;
            btn_addBurg.Location = new Point(60, 349);
            btn_addBurg.Name = "btn_addBurg";
            btn_addBurg.Size = new Size(155, 46);
            btn_addBurg.TabIndex = 9;
            btn_addBurg.Text = "Add";
            btn_addBurg.UseVisualStyleBackColor = false;
            btn_addBurg.Click += btn_addBurg_Click;
            // 
            // btn_updateBurg
            // 
            btn_updateBurg.BackColor = Color.FromArgb(126, 27, 27);
            btn_updateBurg.Cursor = Cursors.Hand;
            btn_updateBurg.Font = new Font("Segoe UI", 10F);
            btn_updateBurg.ForeColor = Color.White;
            btn_updateBurg.Location = new Point(218, 349);
            btn_updateBurg.Name = "btn_updateBurg";
            btn_updateBurg.Size = new Size(155, 46);
            btn_updateBurg.TabIndex = 10;
            btn_updateBurg.Text = "Update";
            btn_updateBurg.UseVisualStyleBackColor = false;
            btn_updateBurg.Click += btn_updateBurg_Click;
            // 
            // btn_removeBurg
            // 
            btn_removeBurg.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeBurg.Cursor = Cursors.Hand;
            btn_removeBurg.Font = new Font("Segoe UI", 10F);
            btn_removeBurg.ForeColor = Color.White;
            btn_removeBurg.Location = new Point(378, 349);
            btn_removeBurg.Name = "btn_removeBurg";
            btn_removeBurg.Size = new Size(155, 46);
            btn_removeBurg.TabIndex = 11;
            btn_removeBurg.Text = "Remove";
            btn_removeBurg.UseVisualStyleBackColor = false;
            btn_removeBurg.Click += btn_removeBurg_Click;
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
            button4.TabIndex = 12;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_removePizza
            // 
            btn_removePizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_removePizza.Cursor = Cursors.Hand;
            btn_removePizza.Font = new Font("Segoe UI", 10F);
            btn_removePizza.ForeColor = Color.White;
            btn_removePizza.Location = new Point(378, 349);
            btn_removePizza.Name = "btn_removePizza";
            btn_removePizza.Size = new Size(155, 46);
            btn_removePizza.TabIndex = 15;
            btn_removePizza.Text = "Remove";
            btn_removePizza.UseVisualStyleBackColor = false;
            btn_removePizza.Click += btn_removePizza_Click;
            // 
            // btn_updatePizza
            // 
            btn_updatePizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_updatePizza.Cursor = Cursors.Hand;
            btn_updatePizza.Font = new Font("Segoe UI", 10F);
            btn_updatePizza.ForeColor = Color.White;
            btn_updatePizza.Location = new Point(217, 349);
            btn_updatePizza.Name = "btn_updatePizza";
            btn_updatePizza.Size = new Size(155, 46);
            btn_updatePizza.TabIndex = 14;
            btn_updatePizza.Text = "Update";
            btn_updatePizza.UseVisualStyleBackColor = false;
            btn_updatePizza.Click += btn_updatePizza_Click;
            // 
            // btn_addPizza
            // 
            btn_addPizza.BackColor = Color.FromArgb(126, 27, 27);
            btn_addPizza.Cursor = Cursors.Hand;
            btn_addPizza.Font = new Font("Segoe UI", 10F);
            btn_addPizza.ForeColor = Color.White;
            btn_addPizza.Location = new Point(60, 349);
            btn_addPizza.Name = "btn_addPizza";
            btn_addPizza.Size = new Size(155, 46);
            btn_addPizza.TabIndex = 13;
            btn_addPizza.Text = "Add";
            btn_addPizza.UseVisualStyleBackColor = false;
            btn_addPizza.Click += btn_addPizza_Click;
            // 
            // btn_removeDessert
            // 
            btn_removeDessert.BackColor = Color.FromArgb(126, 27, 27);
            btn_removeDessert.Cursor = Cursors.Hand;
            btn_removeDessert.Font = new Font("Segoe UI", 10F);
            btn_removeDessert.ForeColor = Color.White;
            btn_removeDessert.Location = new Point(378, 349);
            btn_removeDessert.Name = "btn_removeDessert";
            btn_removeDessert.Size = new Size(155, 46);
            btn_removeDessert.TabIndex = 18;
            btn_removeDessert.Text = "Remove";
            btn_removeDessert.UseVisualStyleBackColor = false;
            btn_removeDessert.Click += btn_removeDessert_Click;
            // 
            // btn_updateDessert
            // 
            btn_updateDessert.BackColor = Color.FromArgb(126, 27, 27);
            btn_updateDessert.Cursor = Cursors.Hand;
            btn_updateDessert.Font = new Font("Segoe UI", 10F);
            btn_updateDessert.ForeColor = Color.White;
            btn_updateDessert.Location = new Point(217, 349);
            btn_updateDessert.Name = "btn_updateDessert";
            btn_updateDessert.Size = new Size(155, 46);
            btn_updateDessert.TabIndex = 17;
            btn_updateDessert.Text = "Update";
            btn_updateDessert.UseVisualStyleBackColor = false;
            btn_updateDessert.Click += btn_updateDessert_Click;
            // 
            // btn_addDessert
            // 
            btn_addDessert.BackColor = Color.FromArgb(126, 27, 27);
            btn_addDessert.Cursor = Cursors.Hand;
            btn_addDessert.Font = new Font("Segoe UI", 10F);
            btn_addDessert.ForeColor = Color.White;
            btn_addDessert.Location = new Point(60, 349);
            btn_addDessert.Name = "btn_addDessert";
            btn_addDessert.Size = new Size(155, 46);
            btn_addDessert.TabIndex = 16;
            btn_addDessert.Text = "Add";
            btn_addDessert.UseVisualStyleBackColor = false;
            btn_addDessert.Click += btn_addDessert_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(126, 27, 27);
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(54, 29);
            button1.TabIndex = 19;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_prodName
            // 
            txt_prodName.Location = new Point(143, 244);
            txt_prodName.Multiline = true;
            txt_prodName.Name = "txt_prodName";
            txt_prodName.Size = new Size(275, 27);
            txt_prodName.TabIndex = 20;
            // 
            // txt_prodPrice
            // 
            txt_prodPrice.Location = new Point(143, 286);
            txt_prodPrice.Name = "txt_prodPrice";
            txt_prodPrice.Size = new Size(275, 27);
            txt_prodPrice.TabIndex = 21;
            // 
            // lbl_prodName
            // 
            lbl_prodName.AutoSize = true;
            lbl_prodName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_prodName.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_prodName.Location = new Point(60, 244);
            lbl_prodName.Name = "lbl_prodName";
            lbl_prodName.Size = new Size(73, 23);
            lbl_prodName.TabIndex = 22;
            lbl_prodName.Text = "Product";
            // 
            // lbl_prodPrice
            // 
            lbl_prodPrice.AutoSize = true;
            lbl_prodPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_prodPrice.ForeColor = Color.FromArgb(126, 27, 27);
            lbl_prodPrice.Location = new Point(60, 289);
            lbl_prodPrice.Name = "lbl_prodPrice";
            lbl_prodPrice.Size = new Size(49, 23);
            lbl_prodPrice.TabIndex = 23;
            lbl_prodPrice.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(204, 190);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 6;
            label6.Text = "Burger";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(126, 27, 27);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 10F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(444, 238);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(89, 77);
            btn_clear.TabIndex = 32;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(126, 27, 27);
            label1.Location = new Point(72, 13);
            label1.Name = "label1";
            label1.Padding = new Padding(14, 5, 14, 5);
            label1.Size = new Size(455, 45);
            label1.TabIndex = 31;
            label1.Text = "Products Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pres_Admin_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(btn_clear);
            Controls.Add(label1);
            Controls.Add(lbl_prodPrice);
            Controls.Add(lbl_prodName);
            Controls.Add(txt_prodPrice);
            Controls.Add(txt_prodName);
            Controls.Add(button1);
            Controls.Add(btn_removeDessert);
            Controls.Add(btn_updateDessert);
            Controls.Add(btn_addDessert);
            Controls.Add(btn_removePizza);
            Controls.Add(btn_updatePizza);
            Controls.Add(btn_addPizza);
            Controls.Add(button4);
            Controls.Add(btn_removeBurg);
            Controls.Add(btn_updateBurg);
            Controls.Add(btn_addBurg);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgv_prod);
            Controls.Add(btn_all);
            Controls.Add(btn_dessert);
            Controls.Add(btn_pizza);
            Controls.Add(btn_burger);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Admin_Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Admin_Products";
            Load += Pres_Admin_Products_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_prod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_burger;
        private Button btn_pizza;
        private Button btn_dessert;
        private Button btn_all;
        private DataGridView dgv_prod;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button btn_addBurg;
        private Button btn_updateBurg;
        private Button btn_removeBurg;
        private Button button4;
        private Button btn_removePizza;
        private Button btn_updatePizza;
        private Button btn_addPizza;
        private Button btn_removeDessert;
        private Button btn_updateDessert;
        private Button btn_addDessert;
        private Button button1;
        private TextBox txt_prodName;
        private TextBox txt_prodPrice;
        private Label lbl_prodName;
        private Label lbl_prodPrice;
        private Label label6;
        private Button btn_clear;
        private Label label1;
    }
}