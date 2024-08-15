namespace CarRental
{
    partial class ctrlCarProfile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCarProfile));
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btnReservation = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.rbMonthly = new Guna.UI.WinForms.GunaRadioButton();
            this.rbWeekly = new Guna.UI.WinForms.GunaRadioButton();
            this.rbDaily = new Guna.UI.WinForms.GunaRadioButton();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnFee = new Guna.UI2.WinForms.Guna2Button();
            this.btnRepair = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegularMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbQuantity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new CarRental.MyLabel(this.components);
            this.lblRentalPrice = new CarRental.MyLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.Color.Transparent;
            this.pbCarImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCarImage.Location = new System.Drawing.Point(0, 0);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(310, 174);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 16;
            this.pbCarImage.TabStop = false;
            // 
            // btnReservation
            // 
            this.btnReservation.AnimationHoverSpeed = 0.07F;
            this.btnReservation.AnimationSpeed = 0.03F;
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.BaseColor1 = System.Drawing.Color.Navy;
            this.btnReservation.BaseColor2 = System.Drawing.Color.Navy;
            this.btnReservation.BorderColor = System.Drawing.Color.Transparent;
            this.btnReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = null;
            this.btnReservation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReservation.Location = new System.Drawing.Point(70, 420);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.OnHoverBaseColor1 = System.Drawing.Color.DarkBlue;
            this.btnReservation.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReservation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservation.OnHoverImage = null;
            this.btnReservation.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservation.Radius = 17;
            this.btnReservation.Size = new System.Drawing.Size(170, 40);
            this.btnReservation.TabIndex = 0;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(3, 368);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(19, 20);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "$";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 237);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(119, 20);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "Renal Rate : ";
            // 
            // rbMonthly
            // 
            this.rbMonthly.BackColor = System.Drawing.Color.Transparent;
            this.rbMonthly.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMonthly.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMonthly.CheckedOnColor = System.Drawing.Color.Blue;
            this.rbMonthly.FillColor = System.Drawing.Color.White;
            this.rbMonthly.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.rbMonthly.ForeColor = System.Drawing.Color.Cyan;
            this.rbMonthly.Location = new System.Drawing.Point(210, 275);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(102, 24);
            this.rbMonthly.TabIndex = 25;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // rbWeekly
            // 
            this.rbWeekly.BackColor = System.Drawing.Color.Transparent;
            this.rbWeekly.BaseColor = System.Drawing.SystemColors.Control;
            this.rbWeekly.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbWeekly.CheckedOnColor = System.Drawing.Color.Blue;
            this.rbWeekly.FillColor = System.Drawing.Color.White;
            this.rbWeekly.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.rbWeekly.ForeColor = System.Drawing.Color.Cyan;
            this.rbWeekly.Location = new System.Drawing.Point(110, 275);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(95, 24);
            this.rbWeekly.TabIndex = 24;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // rbDaily
            // 
            this.rbDaily.BackColor = System.Drawing.Color.Transparent;
            this.rbDaily.BaseColor = System.Drawing.SystemColors.Control;
            this.rbDaily.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbDaily.CheckedOnColor = System.Drawing.Color.Blue;
            this.rbDaily.FillColor = System.Drawing.Color.White;
            this.rbDaily.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.rbDaily.ForeColor = System.Drawing.Color.Cyan;
            this.rbDaily.Location = new System.Drawing.Point(10, 275);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(78, 24);
            this.rbDaily.TabIndex = 23;
            this.rbDaily.Text = "Daily";
            this.rbDaily.Click += new System.EventHandler(this.RadioButtons_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::CarRental.Properties.Resources.info;
            this.btnInfo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInfo.Location = new System.Drawing.Point(160, 191);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 31;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.Transparent;
            this.btnFee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFee.FillColor = System.Drawing.Color.Transparent;
            this.btnFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFee.ForeColor = System.Drawing.Color.White;
            this.btnFee.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFee.Image = global::CarRental.Properties.Resources.Fees_receipt;
            this.btnFee.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFee.Location = new System.Drawing.Point(10, 191);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(40, 40);
            this.btnFee.TabIndex = 32;
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.Color.Transparent;
            this.btnRepair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRepair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRepair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRepair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRepair.FillColor = System.Drawing.Color.Transparent;
            this.btnRepair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepair.ForeColor = System.Drawing.Color.White;
            this.btnRepair.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRepair.Image = global::CarRental.Properties.Resources.maintenance;
            this.btnRepair.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRepair.Location = new System.Drawing.Point(60, 191);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(40, 40);
            this.btnRepair.TabIndex = 33;
            // 
            // btnRegularMaintenance
            // 
            this.btnRegularMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnRegularMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegularMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegularMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegularMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegularMaintenance.FillColor = System.Drawing.Color.Transparent;
            this.btnRegularMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegularMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnRegularMaintenance.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRegularMaintenance.Image = global::CarRental.Properties.Resources.Regular_maintenance;
            this.btnRegularMaintenance.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRegularMaintenance.Location = new System.Drawing.Point(110, 191);
            this.btnRegularMaintenance.Name = "btnRegularMaintenance";
            this.btnRegularMaintenance.Size = new System.Drawing.Size(40, 40);
            this.btnRegularMaintenance.TabIndex = 34;
            this.btnRegularMaintenance.Click += new System.EventHandler(this.btnRegularMaintenance_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::CarRental.Properties.Resources.edit;
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.Location = new System.Drawing.Point(260, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::CarRental.Properties.Resources.delete;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(210, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel3.Location = new System.Drawing.Point(5, 317);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel3.TabIndex = 81;
            this.gunaLabel3.Text = "Quantity";
            // 
            // cbQuantity
            // 
            this.cbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.cbQuantity.BorderColor = System.Drawing.Color.Blue;
            this.cbQuantity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbQuantity.FocusedColor = System.Drawing.Color.Empty;
            this.cbQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantity.ForeColor = System.Drawing.Color.Cyan;
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbQuantity.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbQuantity.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbQuantity.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbQuantity.ItemHeight = 30;
            this.cbQuantity.Items.AddRange(new object[] {
            "ID",
            "Plate Number",
            "VIN"});
            this.cbQuantity.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbQuantity.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbQuantity.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbQuantity.Location = new System.Drawing.Point(95, 316);
            this.cbQuantity.MaxDropDownItems = 5;
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(90, 36);
            this.cbQuantity.StartIndex = 0;
            this.cbQuantity.TabIndex = 80;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Cyan;
            this.lblStatus.Location = new System.Drawing.Point(5, 397);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 20);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextBuilder = ((System.Text.StringBuilder)(resources.GetObject("lblStatus.TextBuilder")));
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.lblRentalPrice.ForeColor = System.Drawing.Color.Cyan;
            this.lblRentalPrice.Location = new System.Drawing.Point(17, 368);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(144, 20);
            this.lblRentalPrice.TabIndex = 27;
            this.lblRentalPrice.Text = "Rental Price/Per";
            this.lblRentalPrice.TextBuilder = ((System.Text.StringBuilder)(resources.GetObject("lblRentalPrice.TextBuilder")));
            // 
            // ctrlCarProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRegularMaintenance);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRentalPrice);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.pbCarImage);
            this.Name = "ctrlCarProfile";
            this.Size = new System.Drawing.Size(310, 470);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btnReservation;
        private System.Windows.Forms.PictureBox pbCarImage;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaRadioButton rbMonthly;
        private Guna.UI.WinForms.GunaRadioButton rbWeekly;
        private Guna.UI.WinForms.GunaRadioButton rbDaily;
        private MyLabel lblRentalPrice;
        private MyLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Button btnFee;
        private Guna.UI2.WinForms.Guna2Button btnRepair;
        private Guna.UI2.WinForms.Guna2Button btnRegularMaintenance;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuantity;
    }
}
