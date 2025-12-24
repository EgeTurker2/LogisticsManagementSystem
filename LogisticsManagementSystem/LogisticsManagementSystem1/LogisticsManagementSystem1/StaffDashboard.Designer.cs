namespace LogisticsManagementSystem1
{
    partial class StaffDashboard
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
            this.panelStaffMenu = new System.Windows.Forms.Panel();
            this.panelStaffContent = new System.Windows.Forms.Panel();
            this.btnUpdateShipmentStatus = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelStaffMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStaffMenu
            // 
            this.panelStaffMenu.Controls.Add(this.btnLogout);
            this.panelStaffMenu.Controls.Add(this.btnCargo);
            this.panelStaffMenu.Controls.Add(this.btnUpdateShipmentStatus);
            this.panelStaffMenu.Location = new System.Drawing.Point(2, 2);
            this.panelStaffMenu.Name = "panelStaffMenu";
            this.panelStaffMenu.Size = new System.Drawing.Size(183, 446);
            this.panelStaffMenu.TabIndex = 0;
            // 
            // panelStaffContent
            // 
            this.panelStaffContent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelStaffContent.Location = new System.Drawing.Point(191, 2);
            this.panelStaffContent.Name = "panelStaffContent";
            this.panelStaffContent.Size = new System.Drawing.Size(597, 446);
            this.panelStaffContent.TabIndex = 1;
            // 
            // btnUpdateShipmentStatus
            // 
            this.btnUpdateShipmentStatus.Location = new System.Drawing.Point(10, 100);
            this.btnUpdateShipmentStatus.Name = "btnUpdateShipmentStatus";
            this.btnUpdateShipmentStatus.Size = new System.Drawing.Size(167, 34);
            this.btnUpdateShipmentStatus.TabIndex = 0;
            this.btnUpdateShipmentStatus.Text = "Update Shipment Status";
            this.btnUpdateShipmentStatus.UseVisualStyleBackColor = true;
            this.btnUpdateShipmentStatus.Click += new System.EventHandler(this.btnUpdateShipmentStatus_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(10, 140);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(167, 34);
            this.btnCargo.TabIndex = 1;
            this.btnCargo.Text = "Cargo";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(10, 378);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(167, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStaffContent);
            this.Controls.Add(this.panelStaffMenu);
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.panelStaffMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStaffMenu;
        private System.Windows.Forms.Button btnUpdateShipmentStatus;
        private System.Windows.Forms.Panel panelStaffContent;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnLogout;
    }
}