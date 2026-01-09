namespace Student_Pro
{
    partial class Subjects
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
            btnNew = new Button();
            btnDisplay = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
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
            panel1.Size = new Size(1085, 56);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 42);
            label1.TabIndex = 0;
            label1.Text = "Subjects";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1085, 356);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subject Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.books;
            pictureBox1.Location = new Point(521, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(552, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Lime;
            btnNew.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(398, 186);
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
            btnDisplay.Location = new Point(398, 269);
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
            btnDelete.Location = new Point(219, 269);
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
            btnUpdate.Location = new Point(41, 269);
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
            btnAdd.Location = new Point(219, 186);
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
            btnSave.Location = new Point(41, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 41);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 1;
            label3.Text = "Subject Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 0;
            label2.Text = "Subject ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 424);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1085, 302);
            dataGridView1.TabIndex = 3;
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 725);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Subjects";
            Text = "Subjects";
            Load += Subjects_Load;
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
        private PictureBox pictureBox1;
        private Button btnNew;
        private Button btnDisplay;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
    }
}