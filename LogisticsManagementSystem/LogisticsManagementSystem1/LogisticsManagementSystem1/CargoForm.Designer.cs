namespace LogisticsManagementSystem1
{
    partial class CargoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.txtStatusDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.dgvShipments = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receiver Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status Description:";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(73, 57);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(146, 22);
            this.txtSenderName.TabIndex = 4;
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Location = new System.Drawing.Point(507, 57);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(141, 134);
            this.txtReceiverAddress.TabIndex = 6;
            // 
            // txtStatusDescription
            // 
            this.txtStatusDescription.Location = new System.Drawing.Point(670, 57);
            this.txtStatusDescription.Multiline = true;
            this.txtStatusDescription.Name = "txtStatusDescription";
            this.txtStatusDescription.Size = new System.Drawing.Size(168, 134);
            this.txtStatusDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver Name:";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(311, 57);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(146, 22);
            this.txtReceiverName.TabIndex = 8;
            // 
            // dgvShipments
            // 
            this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipments.Location = new System.Drawing.Point(38, 213);
            this.dgvShipments.Name = "dgvShipments";
            this.dgvShipments.RowHeadersWidth = 51;
            this.dgvShipments.RowTemplate.Height = 24;
            this.dgvShipments.Size = new System.Drawing.Size(918, 225);
            this.dgvShipments.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(209, 138);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 37);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // CargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 520);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvShipments);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.txtStatusDescription);
            this.Controls.Add(this.txtReceiverAddress);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CargoForm";
            this.Text = "CargoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.TextBox txtStatusDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.DataGridView dgvShipments;
        private System.Windows.Forms.Button btnCreate;
    }
}