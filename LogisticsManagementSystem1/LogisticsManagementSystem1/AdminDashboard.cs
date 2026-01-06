using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsManagementSystem1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void LoadFormInPanel(Form form)
        {
            panelAdminContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelAdminContent.Controls.Add(form);
            form.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageUsersForm());
        }

        private void btnUpdateShipmentStatus_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new UpdateShipmentForm());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CargoForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
