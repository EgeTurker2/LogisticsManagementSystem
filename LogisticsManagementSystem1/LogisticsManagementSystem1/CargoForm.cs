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
    public partial class CargoForm : Form
    {
        public CargoForm()
        {
            InitializeComponent();
            LoadShipments();
        }
        string connectionString = @"Server=.;Database=LogisticsSystemDB;Trusted_Connection=True;";
        int selectedShipmentId = 0;

        private void LoadShipments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            ShipmentID,
            TrackingNumber,
            SenderName,
            ReceiverName,
            ReceiverAddress,
            CurrentStatus
        FROM Shipments";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvShipments.DataSource = dt;
            }
        }
        

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenderName.Text) ||
        string.IsNullOrWhiteSpace(txtReceiverName.Text) ||
        string.IsNullOrWhiteSpace(txtReceiverAddress.Text))
            {
                MessageBox.Show("Zorunlu alanlar boş bırakılamaz.");
                return;
            }

            string trackingNumber = GenerateTrackingNumber();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Shipments
            (TrackingNumber, SenderName, ReceiverName, ReceiverAddress, CurrentStatus)
            VALUES
            (@TrackingNumber, @SenderName, @ReceiverName, @ReceiverAddress, 'Created')
        ", conn);

                cmd.Parameters.AddWithValue("@TrackingNumber", trackingNumber);
                cmd.Parameters.AddWithValue("@SenderName", txtSenderName.Text.Trim());
                cmd.Parameters.AddWithValue("@ReceiverName", txtReceiverName.Text.Trim());
                cmd.Parameters.AddWithValue("@ReceiverAddress", txtReceiverAddress.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kargo oluşturuldu.\nTracking No: " + trackingNumber);

            LoadShipments();
        }
        public string GenerateTrackingNumber()
        {
            return new Random().Next(10000000, 99999999).ToString();
        }

        private void dgvShipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvShipments.Rows[e.RowIndex];

                selectedShipmentId = Convert.ToInt32(row.Cells["ShipmentID"].Value);

                txtSenderName.Text = row.Cells["SenderName"].Value.ToString();
                txtReceiverName.Text = row.Cells["ReceiverName"].Value.ToString();
                txtReceiverAddress.Text = row.Cells["ReceiverAddress"].Value.ToString();
                txtStatusDescription.Text = row.Cells["CurrentStatus"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == 0)
            {
                MessageBox.Show("Lütfen güncellemek için listeden bir kargo seçin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Shipments 
                         SET SenderName = @Sender, 
                             ReceiverName = @Receiver, 
                             ReceiverAddress = @Address, 
                             CurrentStatus = @Status 
                         WHERE ShipmentID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Sender", txtSenderName.Text.Trim());
                cmd.Parameters.AddWithValue("@Receiver", txtReceiverName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtReceiverAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", txtStatusDescription.Text); 
                cmd.Parameters.AddWithValue("@ID", selectedShipmentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kargo bilgileri güncellendi.");
                LoadShipments(); 
            }
        }
    }
}
