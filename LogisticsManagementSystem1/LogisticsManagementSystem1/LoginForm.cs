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

namespace LogisticsManagementSystem1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = @"Server=.;Database=LogisticsSystemDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Role FROM Users 
                         WHERE Username = @username AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        OpenDashboard(role);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        }
        private void OpenDashboard(string role)
        {
            this.Hide();

            if (role == "Admin")
            {
                AdminDashboard adminForm = new AdminDashboard();
                adminForm.Show();
            }
            else if (role == "Staff")
            {
                StaffDashboard staffForm = new StaffDashboard();
                staffForm.Show();
            }
            else
            {
                MessageBox.Show("Unknown role");
                this.Show();
            }
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            trackingForm trackingForm = new trackingForm();
            trackingForm.Show();
        }
    }
}
