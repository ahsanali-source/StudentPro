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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
            con.Open(); 
            string username=txtUsername.Text;
            string password=txtPassword.Text;
            SqlCommand cnn=new SqlCommand("Select username,password,Password from logintab where Username='" + txtUsername.Text + "' and Password='" +  txtPassword.Text + "'", con);
            SqlDataAdapter da=new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                MessageBox.Show("Login Successful!");
                MainForm mn=new MainForm();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }

            con.Close();    


        }
    }
}
