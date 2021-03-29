using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranchUsersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ranchUsersDataSet.Users);

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT users([UserName],[UserPassword],[FirstName],[LastName],[DateCreated]) VALUES (@UserName, @UserPassword, @FirstName, @LastName, @DateCreated)";
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtUsername.Text;
                    cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = txtUserPasswd.Text;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = txtFirstname.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = txtLastname.Text;
                    cmd.Parameters.Add("@DateCreated", SqlDbType.Date).Value = dtbdatecreated.Value;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            this.usersTableAdapter.Fill(this.ranchUsersDataSet.Users);
        }
    }
}
