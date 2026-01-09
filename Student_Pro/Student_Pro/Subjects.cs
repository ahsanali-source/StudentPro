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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                SqlCommand cnn = new SqlCommand("INSERT INTO subjecttab VALUES(@SubjectId, @SubjectName)", con);
                cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
                cnn.Parameters.AddWithValue("@SubjectName", textBox2.Text);

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
            SqlCommand cnn = new SqlCommand("select * from subjecttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

            SqlCommand cnn = new SqlCommand("UPDATE subjecttab SET subjectname = @subjectname WHERE subjectid = @subjectid", con);
            cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@SubjectName", textBox2.Text);

            con.Open();
            int rowsAffected = cnn.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("✅ Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("⚠️ No matching record found to update.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete subjecttab where subjectid=@subjectid", con);
            cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from subjecttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            int v = da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from subjecttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
