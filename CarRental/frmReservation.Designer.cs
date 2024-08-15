namespace CarRental
{
    partial class frmReservation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtCheckNotes = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtFulePercentage = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblSecurityDeposit = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.lblLimitsMileage = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.btnChooseCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txtNationalNo = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReserve = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbDropOffLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPickupLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.lblRentalRate = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlCustomerCard1 = new CarRental.ctrlCustomerCard();
            this.ctrlCarCard1 = new CarRental.ctrlCarCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(13, 91);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 28);
            this.gunaLabel2.TabIndex = 76;
            this.gunaLabel2.Text = "Rental Rate :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("PMingLiU-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 33);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "New Reservation";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel1.Location = new System.Drawing.Point(422, 91);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 28);
            this.gunaLabel1.TabIndex = 79;
            this.gunaLabel1.Text = "Quantity :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel3.Location = new System.Drawing.Point(13, 149);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(150, 28);
            this.gunaLabel3.TabIndex = 81;
            this.gunaLabel3.Text = "Pickup Location";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel4.Location = new System.Drawing.Point(422, 149);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(166, 28);
            this.gunaLabel4.TabIndex = 83;
            this.gunaLabel4.Text = "Drop off Location";
            // 
            // txtCheckNotes
            // 
            this.txtCheckNotes.Location = new System.Drawing.Point(189, 690);
            this.txtCheckNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckNotes.MaxLength = 50;
            this.txtCheckNotes.Multiline = true;
            this.txtCheckNotes.Name = "txtCheckNotes";
            this.txtCheckNotes.Size = new System.Drawing.Size(539, 94);
            this.txtCheckNotes.TabIndex = 138;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::CarRental.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(151, 680);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 137;
            this.pictureBox7.TabStop = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel5.Location = new System.Drawing.Point(13, 680);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(113, 28);
            this.gunaLabel5.TabIndex = 139;
            this.gunaLabel5.Text = "Check Note";
            // 
            // txtFulePercentage
            // 
            this.txtFulePercentage.BackColor = System.Drawing.Color.Transparent;
            this.txtFulePercentage.BaseColor = System.Drawing.Color.White;
            this.txtFulePercentage.BorderColor = System.Drawing.Color.Silver;
            this.txtFulePercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFulePercentage.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFulePercentage.FocusedBorderColor = System.Drawing.Color.Navy;
            this.txtFulePercentage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFulePercentage.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.txtFulePercentage.Location = new System.Drawing.Point(1361, 91);
            this.txtFulePercentage.Name = "txtFulePercentage";
            this.txtFulePercentage.PasswordChar = '\0';
            this.txtFulePercentage.Radius = 13;
            this.txtFulePercentage.SelectedText = "";
            this.txtFulePercentage.Size = new System.Drawing.Size(160, 34);
            this.txtFulePercentage.TabIndex = 143;
            this.txtFulePercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFulePercentage_KeyPress);
            this.txtFulePercentage.Validating += new System.ComponentModel.CancelEventHandler(this.txtFulePercentage_Validating);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel6.Location = new System.Drawing.Point(816, 96);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(191, 24);
            this.gunaLabel6.TabIndex = 142;
            this.gunaLabel6.Text = "Total Due Amount :";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel7.Location = new System.Drawing.Point(816, 161);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(172, 24);
            this.gunaLabel7.TabIndex = 144;
            this.gunaLabel7.Text = "Security Deposit :";
            // 
            // lblSecurityDeposit
            // 
            this.lblSecurityDeposit.AutoSize = true;
            this.lblSecurityDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityDeposit.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.lblSecurityDeposit.ForeColor = System.Drawing.Color.Cyan;
            this.lblSecurityDeposit.Location = new System.Drawing.Point(1010, 161);
            this.lblSecurityDeposit.Name = "lblSecurityDeposit";
            this.lblSecurityDeposit.Size = new System.Drawing.Size(48, 24);
            this.lblSecurityDeposit.TabIndex = 145;
            this.lblSecurityDeposit.Text = "N/A";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel9.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel9.Location = new System.Drawing.Point(1010, 99);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(48, 24);
            this.gunaLabel9.TabIndex = 147;
            this.gunaLabel9.Text = "N/A";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel10.Location = new System.Drawing.Point(1188, 96);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(167, 24);
            this.gunaLabel10.TabIndex = 146;
            this.gunaLabel10.Text = "Fule Percentage :";
            // 
            // lblLimitsMileage
            // 
            this.lblLimitsMileage.AutoSize = true;
            this.lblLimitsMileage.BackColor = System.Drawing.Color.Transparent;
            this.lblLimitsMileage.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.lblLimitsMileage.ForeColor = System.Drawing.Color.Cyan;
            this.lblLimitsMileage.Location = new System.Drawing.Point(1385, 154);
            this.lblLimitsMileage.Name = "lblLimitsMileage";
            this.lblLimitsMileage.Size = new System.Drawing.Size(48, 24);
            this.lblLimitsMileage.TabIndex = 149;
            this.lblLimitsMileage.Text = "N/A";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel12.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel12.Location = new System.Drawing.Point(1188, 154);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(160, 24);
            this.gunaLabel12.TabIndex = 148;
            this.gunaLabel12.Text = "Limits Mileage :";
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.AutoRoundedCorners = true;
            this.btnChooseCustomer.BorderRadius = 21;
            this.btnChooseCustomer.FillColor = System.Drawing.Color.Navy;
            this.btnChooseCustomer.FillColor2 = System.Drawing.Color.Black;
            this.btnChooseCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseCustomer.ForeColor = System.Drawing.Color.White;
            this.btnChooseCustomer.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnChooseCustomer.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnChooseCustomer.Location = new System.Drawing.Point(407, 615);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(150, 45);
            this.btnChooseCustomer.TabIndex = 150;
            this.btnChooseCustomer.Text = "Choose ";
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel13.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel13.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel13.Location = new System.Drawing.Point(14, 623);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(224, 24);
            this.gunaLabel13.TabIndex = 152;
            this.gunaLabel13.Text = "Customer NatinoalNO :";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalNo.BaseColor = System.Drawing.Color.White;
            this.txtNationalNo.BorderColor = System.Drawing.Color.Silver;
            this.txtNationalNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNationalNo.FocusedBorderColor = System.Drawing.Color.Navy;
            this.txtNationalNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNationalNo.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.txtNationalNo.Location = new System.Drawing.Point(241, 618);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.Radius = 13;
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(160, 34);
            this.txtNationalNo.TabIndex = 151;
            this.txtNationalNo.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Navy;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(563, 615);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(150, 45);
            this.guna2GradientButton1.TabIndex = 153;
            this.guna2GradientButton1.Text = "Add";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.AutoRoundedCorners = true;
            this.btnReserve.BorderRadius = 21;
            this.btnReserve.FillColor = System.Drawing.Color.Navy;
            this.btnReserve.FillColor2 = System.Drawing.Color.Black;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnReserve.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(1435, 739);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(150, 45);
            this.btnReserve.TabIndex = 154;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // cbDropOffLocation
            // 
            this.cbDropOffLocation.AutoRoundedCorners = true;
            this.cbDropOffLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbDropOffLocation.BorderRadius = 17;
            this.cbDropOffLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDropOffLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDropOffLocation.FillColor = System.Drawing.Color.Black;
            this.cbDropOffLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbDropOffLocation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropOffLocation.ForeColor = System.Drawing.Color.Cyan;
            this.cbDropOffLocation.FormattingEnabled = true;
            this.cbDropOffLocation.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbDropOffLocation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbDropOffLocation.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDropOffLocation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbDropOffLocation.ItemHeight = 30;
            this.cbDropOffLocation.Items.AddRange(new object[] {
            "Manchester City Centre",
            "Edinburgh City Centre",
            "London Victoria Station",
            "Birmingham City Centre",
            "Glasgow City Centre",
            "Leeds City Centre",
            "Bristol City Centre",
            "Liverpool City Centre",
            "Cardiff City Centre",
            "Nottingham City Centre"});
            this.cbDropOffLocation.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbDropOffLocation.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbDropOffLocation.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbDropOffLocation.Location = new System.Drawing.Point(594, 149);
            this.cbDropOffLocation.Name = "cbDropOffLocation";
            this.cbDropOffLocation.Size = new System.Drawing.Size(197, 36);
            this.cbDropOffLocation.StartIndex = 0;
            this.cbDropOffLocation.TabIndex = 82;
            // 
            // cbPickupLocation
            // 
            this.cbPickupLocation.AutoRoundedCorners = true;
            this.cbPickupLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbPickupLocation.BorderRadius = 17;
            this.cbPickupLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPickupLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPickupLocation.FillColor = System.Drawing.Color.Black;
            this.cbPickupLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbPickupLocation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPickupLocation.ForeColor = System.Drawing.Color.Cyan;
            this.cbPickupLocation.FormattingEnabled = true;
            this.cbPickupLocation.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbPickupLocation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPickupLocation.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPickupLocation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbPickupLocation.ItemHeight = 30;
            this.cbPickupLocation.Items.AddRange(new object[] {
            "Manchester City Centre",
            "Edinburgh City Centre",
            "London Victoria Station",
            "Birmingham City Centre",
            "Glasgow City Centre",
            "Leeds City Centre",
            "Bristol City Centre",
            "Liverpool City Centre",
            "Cardiff City Centre",
            "Nottingham City Centre"});
            this.cbPickupLocation.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbPickupLocation.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbPickupLocation.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPickupLocation.Location = new System.Drawing.Point(184, 149);
            this.cbPickupLocation.Name = "cbPickupLocation";
            this.cbPickupLocation.Size = new System.Drawing.Size(197, 36);
            this.cbPickupLocation.StartIndex = 0;
            this.cbPickupLocation.TabIndex = 80;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Cyan;
            this.lblQuantity.Location = new System.Drawing.Point(527, 96);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(48, 24);
            this.lblQuantity.TabIndex = 155;
            this.lblQuantity.Text = "N/A";
            // 
            // lblRentalRate
            // 
            this.lblRentalRate.AutoSize = true;
            this.lblRentalRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRate.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.lblRentalRate.ForeColor = System.Drawing.Color.Cyan;
            this.lblRentalRate.Location = new System.Drawing.Point(134, 95);
            this.lblRentalRate.Name = "lblRentalRate";
            this.lblRentalRate.Size = new System.Drawing.Size(48, 24);
            this.lblRentalRate.TabIndex = 156;
            this.lblRentalRate.Text = "N/A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlCustomerCard1
            // 
            this.ctrlCustomerCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlCustomerCard1.BackgroundImage")));
            this.ctrlCustomerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlCustomerCard1.Location = new System.Drawing.Point(708, 202);
            this.ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            this.ctrlCustomerCard1.Size = new System.Drawing.Size(840, 410);
            this.ctrlCustomerCard1.TabIndex = 141;
            // 
            // ctrlCarCard1
            // 
            this.ctrlCarCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlCarCard1.BackgroundImage")));
            this.ctrlCarCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlCarCard1.Location = new System.Drawing.Point(18, 202);
            this.ctrlCarCard1.Name = "ctrlCarCard1";
            this.ctrlCarCard1.Size = new System.Drawing.Size(675, 400);
            this.ctrlCarCard1.TabIndex = 140;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1597, 798);
            this.Controls.Add(this.lblRentalRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.btnChooseCustomer);
            this.Controls.Add(this.lblLimitsMileage);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.lblSecurityDeposit);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtFulePercentage);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.ctrlCustomerCard1);
            this.Controls.Add(this.ctrlCarCard1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtCheckNotes);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbDropOffLocation);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbPickupLocation);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReservation";
            this.Text = "frmReservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.TextBox txtCheckNotes;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private ctrlCarCard ctrlCarCard1;
        private ctrlCustomerCard ctrlCustomerCard1;
        private Guna.UI.WinForms.GunaTextBox txtFulePercentage;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lblSecurityDeposit;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel lblLimitsMileage;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI2.WinForms.Guna2GradientButton btnChooseCustomer;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaTextBox txtNationalNo;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btnReserve;
        private Guna.UI2.WinForms.Guna2ComboBox cbDropOffLocation;
        private Guna.UI2.WinForms.Guna2ComboBox cbPickupLocation;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private Guna.UI.WinForms.GunaLabel lblRentalRate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}