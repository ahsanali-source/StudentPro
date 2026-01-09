using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Pro
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                SqlCommand cnn = new SqlCommand("INSERT INTO attendancetab VALUES(@AID, @StudentName,@Status)", con);
                cnn.Parameters.AddWithValue("@AID", int.Parse(textBox1.Text));
                cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
                cnn.Parameters.AddWithValue("@Status", comboBox1.SelectedItem.ToString());

                cnn.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Record Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("⚠️ This Subject ID already exists. Please use a unique ID.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("❌ SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from attendancetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

            SqlCommand cnn = new SqlCommand("update attendancetab set studentname=@studentname,status=@status WHERE aid=@aid", con);
            cnn.Parameters.AddWithValue("@AID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Status", comboBox1.SelectedItem.ToString());
            con.Open();
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete attendancetab where aid=@aid", con);
            cnn.Parameters.AddWithValue("@AID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from attendancetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from attendancetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        
    }
}
