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
    public partial class trackingForm : Form
    {
        public trackingForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=.;Database=LogisticsSystemDB;Trusted_Connection=True;";


        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void dgvShipments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackingNumber.Text))
            {
                MessageBox.Show("Lütfen takip numarasını girin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                TrackingNumber,
                SenderName,
                ReceiverName,
                ReceiverAddress,
                CurrentStatus
            FROM Shipments
            WHERE TrackingNumber = @TrackingNumber
        ";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue(
                    "@TrackingNumber", txtTrackingNumber.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bu takip numarasına ait kargo bulunamadı.");
                    dgvShipments.DataSource = null;
                }
                else
                {
                    dgvShipments.DataSource = dt;
                }
            }
        }
    }
}
