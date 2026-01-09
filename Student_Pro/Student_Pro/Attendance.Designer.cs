namespace Student_Pro
{
    partial class Attendance
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnNew = new Button();
            btnDisplay = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 48);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 42);
            label1.TabIndex = 0;
            label1.Text = "Attendance";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 402);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1011, 263);
            dataGridView1.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1013, 342);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Tag = " ";
            groupBox1.Text = "Attendance Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNew);
            groupBox2.Controls.Add(btnDisplay);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(8, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(999, 334);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Tag = " ";
            groupBox2.Text = "Attendance Information";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Lime;
            btnNew.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(445, 217);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(104, 41);
            btnNew.TabIndex = 27;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Lime;
            btnDisplay.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = Color.White;
            btnDisplay.Location = new Point(445, 287);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(104, 41);
            btnDisplay.TabIndex = 26;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(291, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 41);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(136, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 41);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(291, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 41);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(136, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 41);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Present", "Absent", "Leave" });
            comboBox1.Location = new Point(272, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 33);
            comboBox1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(127, 154);
            label8.Name = "label8";
            label8.Size = new Size(70, 30);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 31);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 31);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 99);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 15;
            label3.Text = "StudentName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 48);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 14;
            label2.Text = "AID";
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 662);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Attendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            Load += Attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnNew;
        private Button btnDisplay;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
    }
}