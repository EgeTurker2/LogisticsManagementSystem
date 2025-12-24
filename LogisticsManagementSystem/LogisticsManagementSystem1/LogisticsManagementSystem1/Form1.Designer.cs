namespace LogisticsManagementSystem1
{
    partial class trackingForm
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
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.dgvShipments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tracking Number:";
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(209, 71);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(100, 22);
            this.txtTrackingNumber.TabIndex = 1;
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(148, 117);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(87, 23);
            this.btnTrack.TabIndex = 2;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Location = new System.Drawing.Point(607, 64);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(160, 29);
            this.btnLoginForm.TabIndex = 3;
            this.btnLoginForm.Text = "Login";
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // dgvShipments
            // 
            this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipments.Location = new System.Drawing.Point(43, 165);
            this.dgvShipments.Name = "dgvShipments";
            this.dgvShipments.RowHeadersWidth = 51;
            this.dgvShipments.RowTemplate.Height = 24;
            this.dgvShipments.Size = new System.Drawing.Size(767, 77);
            this.dgvShipments.TabIndex = 10;
            this.dgvShipments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipments_CellContentClick);
            // 
            // trackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 286);
            this.Controls.Add(this.dgvShipments);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.label1);
            this.Name = "trackingForm";
            this.Text = "Track";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.DataGridView dgvShipments;
    }
}

