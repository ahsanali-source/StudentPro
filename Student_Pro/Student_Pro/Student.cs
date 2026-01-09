using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Pro
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into studenttab values(@sid,@fullname,@phoneno,@dob,@email,@address,@semester,@gpa)", con);
            cnn.Parameters.AddWithValue("@SID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@FullName", textBox2.Text);
            cnn.Parameters.AddWithValue("@PhoneNo", textBox3.Text);
            cnn.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.Parameters.AddWithValue("@Semester", textBox6.Text);
            cnn.Parameters.AddWithValue("@GPA", textBox7.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Saved Successfully!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

            SqlCommand cnn = new SqlCommand("update studenttab set fullname=@fullname,phoneno=@phoneno,dob=@dob,email=@email,address=@address,semester=@semester,gpa=@gpa where sid=@sid", con);
            cnn.Parameters.AddWithValue("@SID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@FullName", textBox2.Text);
            cnn.Parameters.AddWithValue("@PhoneNo", textBox3.Text);
            cnn.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.Parameters.AddWithValue("@Semester", textBox6.Text);
            cnn.Parameters.AddWithValue("@GPA", textBox7.Text);
            con.Open();
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete studenttab where sid=@sid", con);
            cnn.Parameters.AddWithValue("@SID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Recode Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "SELECT * FROM studenttab WHERE CAST(SID AS VARCHAR) LIKE @search OR FullName LIKE @search";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("✅ Record Found Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    textBox1.Text = row["SID"].ToString();
                    textBox2.Text = row["FullName"].ToString();
                    textBox3.Text = row["PhoneNo"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row["DOB"]);
                    textBox4.Text = row["Email"].ToString();
                    textBox5.Text = row["Address"].ToString();
                    textBox6.Text = row["Semester"].ToString();
                    textBox7.Text = row["GPA"].ToString();
                }
            }
            else
            {
                MessageBox.Show("❌ No matching record found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Optional: clear previous data from textboxes
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}