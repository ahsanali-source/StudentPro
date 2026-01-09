namespace Student_Pro
{
    partial class Student
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label10 = new Label();
            btnNew = new Button();
            btnDisplay = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1457, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(430, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 42);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1457, 430);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._360_F_691732512_vup6Uay348LQQDbQfrgIzoA098P35f74;
            pictureBox1.Location = new Point(973, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(798, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 42);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(475, 89);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 39);
            txtSearch.TabIndex = 23;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gray;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(477, 56);
            label10.Name = "label10";
            label10.Size = new Size(229, 30);
            label10.TabIndex = 22;
            label10.Text = "Search By Name or ID";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Lime;
            btnNew.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(999, 383);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(104, 41);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Lime;
            btnDisplay.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = Color.White;
            btnDisplay.Location = new Point(1131, 383);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(104, 41);
            btnDisplay.TabIndex = 20;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(868, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(726, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 41);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(595, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 41);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(436, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 41);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(174, 327);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(246, 31);
            textBox6.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 364);
            label9.Name = "label9";
            label9.Size = new Size(52, 30);
            label9.TabIndex = 14;
            label9.Text = "GPA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 31);
            textBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 139);
            label8.Name = "label8";
            label8.Size = new Size(103, 30);
            label8.TabIndex = 12;
            label8.Text = "PhoneNo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(174, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 31);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(174, 363);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(246, 31);
            textBox7.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(246, 31);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 31);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 326);
            label7.Name = "label7";
            label7.Size = new Size(104, 30);
            label7.TabIndex = 5;
            label7.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 278);
            label6.Name = "label6";
            label6.Size = new Size(91, 30);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 228);
            label5.Name = "label5";
            label5.Size = new Size(64, 30);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 187);
            label4.Name = "label4";
            label4.Size = new Size(58, 30);
            label4.TabIndex = 2;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 96);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 1;
            label3.Text = "FullName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 46);
            label2.Name = "label2";
            label2.Size = new Size(46, 30);
            label2.TabIndex = 0;
            label2.Text = "SID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 484);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1447, 292);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(1255, 364);
            button1.Name = "button1";
            button1.Size = new Size(121, 56);
            button1.TabIndex = 26;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 794);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private TextBox textBox6;
        private Button btnDisplay;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnNew;
        private Label label10;
        private Button btnSearch;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button button1;
    }
}