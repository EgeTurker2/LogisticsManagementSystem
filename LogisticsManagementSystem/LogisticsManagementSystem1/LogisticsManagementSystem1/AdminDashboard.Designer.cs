namespace LogisticsManagementSystem1
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdminMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnUpdateShipmentStatus = new System.Windows.Forms.Button();
            this.panelAdminContent = new System.Windows.Forms.Panel();
            this.panelAdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminMenu
            // 
            this.panelAdminMenu.Controls.Add(this.btnLogout);
            this.panelAdminMenu.Controls.Add(this.btnManageUsers);
            this.panelAdminMenu.Controls.Add(this.btnCargo);
            this.panelAdminMenu.Controls.Add(this.btnUpdateShipmentStatus);
            this.panelAdminMenu.Location = new System.Drawing.Point(6, 4);
            this.panelAdminMenu.Name = "panelAdminMenu";
            this.panelAdminMenu.Size = new System.Drawing.Size(184, 440);
            this.panelAdminMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(6, 364);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(6, 69);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(175, 41);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(6, 163);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(175, 41);
            this.btnCargo.TabIndex = 1;
            this.btnCargo.Text = "Cargo";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnUpdateShipmentStatus
            // 
            this.btnUpdateShipmentStatus.Location = new System.Drawing.Point(6, 116);
            this.btnUpdateShipmentStatus.Name = "btnUpdateShipmentStatus";
            this.btnUpdateShipmentStatus.Size = new System.Drawing.Size(175, 41);
            this.btnUpdateShipmentStatus.TabIndex = 0;
            this.btnUpdateShipmentStatus.Text = "Update Shipment Status";
            this.btnUpdateShipmentStatus.UseVisualStyleBackColor = true;
            this.btnUpdateShipmentStatus.Click += new System.EventHandler(this.btnUpdateShipmentStatus_Click);
            // 
            // panelAdminContent
            // 
            this.panelAdminContent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAdminContent.Location = new System.Drawing.Point(196, 4);
            this.panelAdminContent.Name = "panelAdminContent";
            this.panelAdminContent.Size = new System.Drawing.Size(1098, 440);
            this.panelAdminContent.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.panelAdminContent);
            this.Controls.Add(this.panelAdminMenu);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panelAdminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminMenu;
        private System.Windows.Forms.Panel panelAdminContent;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnUpdateShipmentStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}