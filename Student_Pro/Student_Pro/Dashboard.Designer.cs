namespace Student_Pro
{
    partial class Dashboard
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 65);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 42);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 650);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images1;
            pictureBox1.Location = new Point(23, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(360, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 237);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(662, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 237);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(360, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 237);
            panel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 107);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 0;
            label2.Text = "Student:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 107);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 1;
            label3.Text = "Subjects:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 105);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 1;
            label4.Text = "Attendance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(159, 107);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(192, 105);
            label6.Name = "label6";
            label6.Size = new Size(27, 32);
            label6.TabIndex = 2;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(174, 104);
            label7.Name = "label7";
            label7.Size = new Size(27, 32);
            label7.TabIndex = 2;
            label7.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1296, 715);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
    }
}