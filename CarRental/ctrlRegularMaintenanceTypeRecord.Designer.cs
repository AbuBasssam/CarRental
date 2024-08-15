namespace CarRental
{
    partial class ctrlRegularMaintenanceTypeRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNextScheduled = new System.Windows.Forms.Label();
            this.lblRegularMaintenenceType = new Guna.UI.WinForms.GunaLabel();
            this.txtNextScheduledMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.pbRegularMaintenenceType = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegularMaintenenceType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNextScheduled
            // 
            this.lblNextScheduled.AutoSize = true;
            this.lblNextScheduled.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextScheduled.ForeColor = System.Drawing.Color.Gray;
            this.lblNextScheduled.Location = new System.Drawing.Point(79, 35);
            this.lblNextScheduled.Name = "lblNextScheduled";
            this.lblNextScheduled.Size = new System.Drawing.Size(201, 17);
            this.lblNextScheduled.TabIndex = 27;
            this.lblNextScheduled.Text = "Next Scheduled Mileage : ";
            // 
            // lblRegularMaintenenceType
            // 
            this.lblRegularMaintenenceType.AutoSize = true;
            this.lblRegularMaintenenceType.BackColor = System.Drawing.Color.Transparent;
            this.lblRegularMaintenenceType.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularMaintenenceType.ForeColor = System.Drawing.Color.White;
            this.lblRegularMaintenenceType.Location = new System.Drawing.Point(79, 5);
            this.lblRegularMaintenenceType.Name = "lblRegularMaintenenceType";
            this.lblRegularMaintenenceType.Size = new System.Drawing.Size(274, 23);
            this.lblRegularMaintenenceType.TabIndex = 28;
            this.lblRegularMaintenenceType.Text = "Regular Maintenence Type";
            // 
            // txtNextScheduledMileage
            // 
            this.txtNextScheduledMileage.BackColor = System.Drawing.Color.Transparent;
            this.txtNextScheduledMileage.BorderThickness = 0;
            this.txtNextScheduledMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNextScheduledMileage.DefaultText = "";
            this.txtNextScheduledMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNextScheduledMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNextScheduledMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNextScheduledMileage.DisabledState.Parent = this.txtNextScheduledMileage;
            this.txtNextScheduledMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNextScheduledMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNextScheduledMileage.FocusedState.Parent = this.txtNextScheduledMileage;
            this.txtNextScheduledMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNextScheduledMileage.HoverState.Parent = this.txtNextScheduledMileage;
            this.txtNextScheduledMileage.Location = new System.Drawing.Point(287, 32);
            this.txtNextScheduledMileage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNextScheduledMileage.Name = "txtNextScheduledMileage";
            this.txtNextScheduledMileage.PasswordChar = '\0';
            this.txtNextScheduledMileage.PlaceholderText = "";
            this.txtNextScheduledMileage.SelectedText = "";
            this.txtNextScheduledMileage.ShadowDecoration.Parent = this.txtNextScheduledMileage;
            this.txtNextScheduledMileage.Size = new System.Drawing.Size(200, 25);
            this.txtNextScheduledMileage.TabIndex = 29;
            this.txtNextScheduledMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNextScheduledMileage_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::CarRental.Properties.Resources.updating;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.Location = new System.Drawing.Point(419, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(102, 30);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbRegularMaintenenceType
            // 
            this.pbRegularMaintenenceType.BackColor = System.Drawing.Color.Transparent;
            this.pbRegularMaintenenceType.BaseColor = System.Drawing.Color.White;
            this.pbRegularMaintenenceType.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRegularMaintenenceType.Image = global::CarRental.Properties.Resources.Transmission_Fluid_Change;
            this.pbRegularMaintenenceType.Location = new System.Drawing.Point(0, 0);
            this.pbRegularMaintenenceType.Name = "pbRegularMaintenenceType";
            this.pbRegularMaintenenceType.Size = new System.Drawing.Size(73, 107);
            this.pbRegularMaintenenceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegularMaintenenceType.TabIndex = 26;
            this.pbRegularMaintenenceType.TabStop = false;
            // 
            // ctrlRegularMaintenanceTypeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNextScheduledMileage);
            this.Controls.Add(this.lblRegularMaintenenceType);
            this.Controls.Add(this.lblNextScheduled);
            this.Controls.Add(this.pbRegularMaintenenceType);
            this.Name = "ctrlRegularMaintenanceTypeRecord";
            this.Size = new System.Drawing.Size(524, 107);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegularMaintenenceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pbRegularMaintenenceType;
        private System.Windows.Forms.Label lblNextScheduled;
        private Guna.UI.WinForms.GunaLabel lblRegularMaintenenceType;
        private Guna.UI2.WinForms.Guna2TextBox txtNextScheduledMileage;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}
