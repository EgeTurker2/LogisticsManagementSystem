namespace LogisticsManagementSystem1
{
    partial class UpdateShipmentForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rbDeliveryFailed = new System.Windows.Forms.RadioButton();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.rbOutForDelivery = new System.Windows.Forms.RadioButton();
            this.rbTransit = new System.Windows.Forms.RadioButton();
            this.rbHub = new System.Windows.Forms.RadioButton();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbAccepted = new System.Windows.Forms.RadioButton();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rdOther = new System.Windows.Forms.RadioButton();
            this.dgvShipments = new System.Windows.Forms.DataGridView();
            this.txtStatusDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(811, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdOther);
            this.grpStatus.Controls.Add(this.rbDeliveryFailed);
            this.grpStatus.Controls.Add(this.rbDelivered);
            this.grpStatus.Controls.Add(this.rbOutForDelivery);
            this.grpStatus.Controls.Add(this.rbTransit);
            this.grpStatus.Controls.Add(this.rbHub);
            this.grpStatus.Controls.Add(this.rbReturned);
            this.grpStatus.Controls.Add(this.rbAccepted);
            this.grpStatus.Controls.Add(this.rbCancelled);
            this.grpStatus.Location = new System.Drawing.Point(756, 12);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(207, 279);
            this.grpStatus.TabIndex = 12;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rbDeliveryFailed
            // 
            this.rbDeliveryFailed.AutoSize = true;
            this.rbDeliveryFailed.Location = new System.Drawing.Point(11, 181);
            this.rbDeliveryFailed.Name = "rbDeliveryFailed";
            this.rbDeliveryFailed.Size = new System.Drawing.Size(119, 20);
            this.rbDeliveryFailed.TabIndex = 8;
            this.rbDeliveryFailed.TabStop = true;
            this.rbDeliveryFailed.Text = "Delivery Failed";
            this.rbDeliveryFailed.UseVisualStyleBackColor = true;
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Location = new System.Drawing.Point(11, 155);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(87, 20);
            this.rbDelivered.TabIndex = 7;
            this.rbDelivered.TabStop = true;
            this.rbDelivered.Text = "Delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            // 
            // rbOutForDelivery
            // 
            this.rbOutForDelivery.AutoSize = true;
            this.rbOutForDelivery.Location = new System.Drawing.Point(11, 129);
            this.rbOutForDelivery.Name = "rbOutForDelivery";
            this.rbOutForDelivery.Size = new System.Drawing.Size(124, 20);
            this.rbOutForDelivery.TabIndex = 6;
            this.rbOutForDelivery.TabStop = true;
            this.rbOutForDelivery.Text = "Out For Delivery";
            this.rbOutForDelivery.UseVisualStyleBackColor = true;
            // 
            // rbTransit
            // 
            this.rbTransit.AutoSize = true;
            this.rbTransit.Location = new System.Drawing.Point(11, 103);
            this.rbTransit.Name = "rbTransit";
            this.rbTransit.Size = new System.Drawing.Size(82, 20);
            this.rbTransit.TabIndex = 5;
            this.rbTransit.TabStop = true;
            this.rbTransit.Text = "In Transit";
            this.rbTransit.UseVisualStyleBackColor = true;
            // 
            // rbHub
            // 
            this.rbHub.AutoSize = true;
            this.rbHub.Location = new System.Drawing.Point(11, 77);
            this.rbHub.Name = "rbHub";
            this.rbHub.Size = new System.Drawing.Size(68, 20);
            this.rbHub.TabIndex = 4;
            this.rbHub.TabStop = true;
            this.rbHub.Text = "At Hub";
            this.rbHub.UseVisualStyleBackColor = true;
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Location = new System.Drawing.Point(11, 207);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(83, 20);
            this.rbReturned.TabIndex = 3;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            // 
            // rbAccepted
            // 
            this.rbAccepted.AutoSize = true;
            this.rbAccepted.Location = new System.Drawing.Point(11, 51);
            this.rbAccepted.Name = "rbAccepted";
            this.rbAccepted.Size = new System.Drawing.Size(86, 20);
            this.rbAccepted.TabIndex = 2;
            this.rbAccepted.TabStop = true;
            this.rbAccepted.Text = "Accepted";
            this.rbAccepted.UseVisualStyleBackColor = true;
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Location = new System.Drawing.Point(11, 25);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(89, 20);
            this.rbCancelled.TabIndex = 0;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Text = "Cancelled";
            this.rbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdOther
            // 
            this.rdOther.AutoSize = true;
            this.rdOther.Location = new System.Drawing.Point(11, 233);
            this.rdOther.Name = "rdOther";
            this.rdOther.Size = new System.Drawing.Size(60, 20);
            this.rdOther.TabIndex = 9;
            this.rdOther.TabStop = true;
            this.rdOther.Text = "Other";
            this.rdOther.UseVisualStyleBackColor = true;
            // 
            // dgvShipments
            // 
            this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipments.Location = new System.Drawing.Point(25, 94);
            this.dgvShipments.Name = "dgvShipments";
            this.dgvShipments.RowHeadersWidth = 51;
            this.dgvShipments.RowTemplate.Height = 24;
            this.dgvShipments.Size = new System.Drawing.Size(686, 279);
            this.dgvShipments.TabIndex = 10;
            // 
            // txtStatusDescription
            // 
            this.txtStatusDescription.Location = new System.Drawing.Point(756, 297);
            this.txtStatusDescription.Multiline = true;
            this.txtStatusDescription.Name = "txtStatusDescription";
            this.txtStatusDescription.Size = new System.Drawing.Size(207, 45);
            this.txtStatusDescription.TabIndex = 14;
            this.txtStatusDescription.TextChanged += new System.EventHandler(this.txtStatusDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cargo List:";
            // 
            // UpdateShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatusDescription);
            this.Controls.Add(this.dgvShipments);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateShipmentForm";
            this.Text = "UpdateShipmentForm";
            this.Load += new System.EventHandler(this.UpdateShipmentForm_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rbDeliveryFailed;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.RadioButton rbOutForDelivery;
        private System.Windows.Forms.RadioButton rbTransit;
        private System.Windows.Forms.RadioButton rbHub;
        private System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.RadioButton rbAccepted;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.DataGridView dgvShipments;
        private System.Windows.Forms.RadioButton rdOther;
        private System.Windows.Forms.TextBox txtStatusDescription;
        private System.Windows.Forms.Label label1;
    }
}