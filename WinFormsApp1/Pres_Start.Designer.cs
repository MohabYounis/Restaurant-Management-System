namespace WinFormsApp1
{
    partial class Pres_Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_getStart = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_getStart
            // 
            btn_getStart.BackColor = Color.Gainsboro;
            btn_getStart.Font = new Font("Segoe UI", 15F);
            btn_getStart.ForeColor = Color.FromArgb(126, 27, 27);
            btn_getStart.Location = new Point(154, 507);
            btn_getStart.Name = "btn_getStart";
            btn_getStart.Size = new Size(276, 59);
            btn_getStart.TabIndex = 1;
            btn_getStart.Text = "Get Started";
            btn_getStart.UseVisualStyleBackColor = false;
            btn_getStart.Click += btn_getStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 360);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 0, 25, 0);
            label1.Size = new Size(276, 114);
            label1.TabIndex = 2;
            label1.Text = "Enjoy\r\nYour Food\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Mohab.Presentation.Properties.Resources.IMAGE1;
            pictureBox1.Location = new Point(145, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(126, 27, 27);
            button1.Location = new Point(525, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 29);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pres_Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 27, 27);
            ClientSize = new Size(600, 700);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_getStart);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_getStart;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
