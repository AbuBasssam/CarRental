namespace CarRental
{
    partial class frmRegularMaintenanceScheduleDetails
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
            this.ctrlRegularMaintenanceSchedule1 = new CarRental.ctrlRegularMaintenanceSchedule();
            this.SuspendLayout();
            // 
            // ctrlRegularMaintenanceSchedule1
            // 
            this.ctrlRegularMaintenanceSchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ctrlRegularMaintenanceSchedule1.EnableUpdatMode = true;
            this.ctrlRegularMaintenanceSchedule1.Location = new System.Drawing.Point(-3, -1);
            this.ctrlRegularMaintenanceSchedule1.Name = "ctrlRegularMaintenanceSchedule1";
            this.ctrlRegularMaintenanceSchedule1.Size = new System.Drawing.Size(1093, 616);
            this.ctrlRegularMaintenanceSchedule1.TabIndex = 0;
            // 
            // frmRegularMaintenanceScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 614);
            this.Controls.Add(this.ctrlRegularMaintenanceSchedule1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegularMaintenanceScheduleDetails";
            this.Text = "Regular MaintenanceSchedule Details";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlRegularMaintenanceSchedule ctrlRegularMaintenanceSchedule1;
    }
}