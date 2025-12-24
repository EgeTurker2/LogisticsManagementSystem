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
    public partial class UpdateShipmentForm : Form
    {
        public UpdateShipmentForm()
        {
            InitializeComponent();
            LoadShipments();
        }
        string connectionString = @"Server=.;Database=LogisticsSystemDB;Trusted_Connection=True;";


        private void UpdateShipmentForm_Load(object sender, EventArgs e)
        {

        }
        private string GetSelectedStatus()
        {
            foreach (Control ctrl in grpStatus.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }

        private void SetStatusRadio(string status)
        {
            foreach (Control ctrl in grpStatus.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = rb.Text == status;
                }
            }
        }
        private void dgvShipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvShipments.Rows[e.RowIndex];

            SetStatusRadio(row.Cells["CurrentStatus"].Value.ToString());

            txtStatusDescription.Text =
                row.Cells["StatusDescription"].Value == DBNull.Value
                ? ""
                : row.Cells["StatusDescription"].Value.ToString();
        }

        private void LoadShipments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                ShipmentID,
                TrackingNumber,
                CurrentStatus,
                StatusDescription
            FROM Shipments";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShipments.DataSource = dt;
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvShipments.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir kargo seçin.");
                return;
            }

            string selectedStatus = GetSelectedStatus();

            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Lütfen bir durum seçin.");
                return;
            }

            int shipmentId = Convert.ToInt32(
                dgvShipments.CurrentRow.Cells["ShipmentID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            UPDATE Shipments
            SET
                CurrentStatus = @CurrentStatus,
                StatusDescription = @StatusDescription
            WHERE ShipmentID = @ShipmentID", conn);

                cmd.Parameters.AddWithValue("@CurrentStatus", selectedStatus);
                cmd.Parameters.AddWithValue("@StatusDescription", txtStatusDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@ShipmentID", shipmentId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kargo durumu güncellendi.");
            LoadShipments();
        }

        private void txtStatusDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
