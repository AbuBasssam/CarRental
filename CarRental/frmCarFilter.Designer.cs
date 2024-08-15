namespace CarRental
{
    partial class frmCarFilter
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
            this.cbMake = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbModel = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtMileage = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtMinumRentalDailyPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.cbFuleType = new Guna.UI.WinForms.GunaComboBox();
            this.cbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaxumRentalDailyPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbTransmission = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbStatus = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.cbYear = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // cbMake
            // 
            this.cbMake.BackColor = System.Drawing.Color.Transparent;
            this.cbMake.BaseColor = System.Drawing.Color.White;
            this.cbMake.BorderColor = System.Drawing.Color.Silver;
            this.cbMake.BorderSize = 0;
            this.cbMake.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.FocusedColor = System.Drawing.Color.Empty;
            this.cbMake.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbMake.ForeColor = System.Drawing.Color.Black;
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Items.AddRange(new object[] {
            "AC",
            "Acura",
            "Alfa Romeo",
            "AMC",
            "Aston Martin",
            "Asuna",
            "Audi",
            "Austin",
            "Avanti",
            "BAIC",
            "Bentley",
            "Bertone",
            "BMW",
            "Bricklin",
            "Bugatti",
            "Buick",
            "Cadillac",
            "Changan",
            "Checker",
            "Chevrolet",
            "Chirey",
            "Chrysler",
            "Citroën",
            "Coda",
            "Daewoo",
            "Daihatsu",
            "Datsun",
            "De Tomaso",
            "DeLorean",
            "Dodge",
            "Eagle",
            "Excalibur",
            "FAW",
            "Ferrari",
            "Fiat",
            "Fisker",
            "Ford",
            "Foton",
            "Freightliner",
            "Genesis",
            "Geo",
            "Giant Motors",
            "GMC",
            "Hino",
            "Honda",
            "Hummer",
            "Hyundai",
            "INFINITI",
            "International Harvester",
            "Isuzu",
            "JAC",
            "Jaguar",
            "Jeep",
            "Jensen",
            "JMC",
            "Karma",
            "Kia",
            "Lada",
            "Laforza",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Lucid",
            "Maserati",
            "Mastretta",
            "Maybach",
            "Mazda",
            "McLaren",
            "Mercedes-Benz",
            "Mercury",
            "Merkur",
            "MG",
            "Mini",
            "Mitsubishi",
            "Mobility Ventures",
            "Morgan",
            "Nissan",
            "Oldsmobile",
            "Opel",
            "Panoz",
            "Peugeot",
            "Plymouth",
            "Polestar",
            "Pontiac",
            "Porsche",
            "Qvale",
            "Ram",
            "Renault",
            "Rivian",
            "Rolls-Royce",
            "Rover",
            "Saab",
            "Saleen",
            "Saturn",
            "Scion",
            "Seat",
            "Shelby",
            "Smart",
            "Spyker",
            "SRT",
            "SsangYong",
            "Sterling",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Think",
            "Toyota",
            "Triumph",
            "UAZ",
            "VAM",
            "Volkswagen",
            "Volvo",
            "VPG",
            "Workhorse",
            "Yugo",
            "Zacua"});
            this.cbMake.Location = new System.Drawing.Point(280, 40);
            this.cbMake.Name = "cbMake";
            this.cbMake.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbMake.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMake.Radius = 14;
            this.cbMake.Size = new System.Drawing.Size(170, 32);
            this.cbMake.TabIndex = 36;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(10, 40);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 24);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "Make ";
            // 
            // cbModel
            // 
            this.cbModel.BackColor = System.Drawing.Color.Transparent;
            this.cbModel.BaseColor = System.Drawing.Color.White;
            this.cbModel.BorderColor = System.Drawing.Color.Silver;
            this.cbModel.BorderSize = 0;
            this.cbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModel.FocusedColor = System.Drawing.Color.Empty;
            this.cbModel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbModel.ForeColor = System.Drawing.Color.Black;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(280, 100);
            this.cbModel.Name = "cbModel";
            this.cbModel.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbModel.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbModel.Radius = 14;
            this.cbModel.Size = new System.Drawing.Size(170, 32);
            this.cbModel.TabIndex = 38;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel3.Location = new System.Drawing.Point(10, 100);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(74, 24);
            this.gunaLabel3.TabIndex = 37;
            this.gunaLabel3.Text = "Model ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel4.Location = new System.Drawing.Point(10, 160);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(60, 24);
            this.gunaLabel4.TabIndex = 39;
            this.gunaLabel4.Text = "Year ";
            // 
            // txtMileage
            // 
            this.txtMileage.BackColor = System.Drawing.Color.Transparent;
            this.txtMileage.BaseColor = System.Drawing.Color.White;
            this.txtMileage.BorderColor = System.Drawing.Color.Silver;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMileage.FocusedBorderColor = System.Drawing.Color.Blue;
            this.txtMileage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMileage.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.txtMileage.Location = new System.Drawing.Point(280, 220);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.Radius = 13;
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(170, 34);
            this.txtMileage.TabIndex = 41;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel5.Location = new System.Drawing.Point(10, 220);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(89, 24);
            this.gunaLabel5.TabIndex = 42;
            this.gunaLabel5.Text = "Mileage ";
            // 
            // txtMinumRentalDailyPrice
            // 
            this.txtMinumRentalDailyPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtMinumRentalDailyPrice.BaseColor = System.Drawing.Color.White;
            this.txtMinumRentalDailyPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtMinumRentalDailyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinumRentalDailyPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMinumRentalDailyPrice.FocusedBorderColor = System.Drawing.Color.Blue;
            this.txtMinumRentalDailyPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinumRentalDailyPrice.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.txtMinumRentalDailyPrice.Location = new System.Drawing.Point(280, 400);
            this.txtMinumRentalDailyPrice.Name = "txtMinumRentalDailyPrice";
            this.txtMinumRentalDailyPrice.PasswordChar = '\0';
            this.txtMinumRentalDailyPrice.Radius = 13;
            this.txtMinumRentalDailyPrice.SelectedText = "";
            this.txtMinumRentalDailyPrice.Size = new System.Drawing.Size(170, 34);
            this.txtMinumRentalDailyPrice.TabIndex = 150;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel13.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel13.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel13.Location = new System.Drawing.Point(10, 400);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(248, 24);
            this.gunaLabel13.TabIndex = 149;
            this.gunaLabel13.Text = "Minum Rental Daily Price";
            // 
            // cbFuleType
            // 
            this.cbFuleType.BackColor = System.Drawing.Color.Transparent;
            this.cbFuleType.BaseColor = System.Drawing.Color.White;
            this.cbFuleType.BorderColor = System.Drawing.Color.Silver;
            this.cbFuleType.BorderSize = 0;
            this.cbFuleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuleType.FocusedColor = System.Drawing.Color.Empty;
            this.cbFuleType.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbFuleType.ForeColor = System.Drawing.Color.Black;
            this.cbFuleType.FormattingEnabled = true;
            this.cbFuleType.Location = new System.Drawing.Point(280, 340);
            this.cbFuleType.Name = "cbFuleType";
            this.cbFuleType.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbFuleType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFuleType.Radius = 14;
            this.cbFuleType.Size = new System.Drawing.Size(170, 32);
            this.cbFuleType.TabIndex = 148;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BaseColor = System.Drawing.Color.White;
            this.cbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbCategory.BorderSize = 0;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(280, 280);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCategory.Radius = 14;
            this.cbCategory.Size = new System.Drawing.Size(170, 32);
            this.cbCategory.TabIndex = 147;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel10.Location = new System.Drawing.Point(10, 280);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(131, 24);
            this.gunaLabel10.TabIndex = 146;
            this.gunaLabel10.Text = "CarCategory ";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel12.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel12.Location = new System.Drawing.Point(10, 340);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(102, 24);
            this.gunaLabel12.TabIndex = 145;
            this.gunaLabel12.Text = "FuelType ";
            // 
            // txtMaxumRentalDailyPrice
            // 
            this.txtMaxumRentalDailyPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxumRentalDailyPrice.BaseColor = System.Drawing.Color.White;
            this.txtMaxumRentalDailyPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtMaxumRentalDailyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxumRentalDailyPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaxumRentalDailyPrice.FocusedBorderColor = System.Drawing.Color.Blue;
            this.txtMaxumRentalDailyPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaxumRentalDailyPrice.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.txtMaxumRentalDailyPrice.Location = new System.Drawing.Point(280, 460);
            this.txtMaxumRentalDailyPrice.Name = "txtMaxumRentalDailyPrice";
            this.txtMaxumRentalDailyPrice.PasswordChar = '\0';
            this.txtMaxumRentalDailyPrice.Radius = 13;
            this.txtMaxumRentalDailyPrice.SelectedText = "";
            this.txtMaxumRentalDailyPrice.Size = new System.Drawing.Size(170, 34);
            this.txtMaxumRentalDailyPrice.TabIndex = 152;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel1.Location = new System.Drawing.Point(10, 460);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(252, 24);
            this.gunaLabel1.TabIndex = 151;
            this.gunaLabel1.Text = "Maxum Rental Daily Price";
            // 
            // cbTransmission
            // 
            this.cbTransmission.BackColor = System.Drawing.Color.Transparent;
            this.cbTransmission.BaseColor = System.Drawing.Color.White;
            this.cbTransmission.BorderColor = System.Drawing.Color.Silver;
            this.cbTransmission.BorderSize = 0;
            this.cbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmission.FocusedColor = System.Drawing.Color.Empty;
            this.cbTransmission.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbTransmission.ForeColor = System.Drawing.Color.Black;
            this.cbTransmission.FormattingEnabled = true;
            this.cbTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cbTransmission.Location = new System.Drawing.Point(280, 520);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbTransmission.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTransmission.Radius = 14;
            this.cbTransmission.Size = new System.Drawing.Size(170, 32);
            this.cbTransmission.TabIndex = 154;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel8.Location = new System.Drawing.Point(10, 520);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(138, 24);
            this.gunaLabel8.TabIndex = 153;
            this.gunaLabel8.Text = "Transmission ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnClose.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(480, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 155;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BaseColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cbStatus.BorderSize = 0;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "In Rent",
            "In Maintenance"});
            this.cbStatus.Location = new System.Drawing.Point(280, 580);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbStatus.Radius = 14;
            this.cbStatus.Size = new System.Drawing.Size(170, 32);
            this.cbStatus.TabIndex = 159;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel6.Location = new System.Drawing.Point(10, 580);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(61, 24);
            this.gunaLabel6.TabIndex = 158;
            this.gunaLabel6.Text = "status";
            // 
            // btnOK
            // 
            this.btnOK.AutoRoundedCorners = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 21;
            this.btnOK.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.Font = new System.Drawing.Font("PMingLiU-ExtB", 10F);
            this.btnOK.ForeColor = System.Drawing.Color.Cyan;
            this.btnOK.Image = global::CarRental.Properties.Resources.filter;
            this.btnOK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOK.Location = new System.Drawing.Point(127, 630);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(162, 45);
            this.btnOK.TabIndex = 156;
            this.btnOK.Text = "Filter";
            this.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.BaseColor = System.Drawing.Color.White;
            this.cbYear.BorderColor = System.Drawing.Color.Silver;
            this.cbYear.BorderSize = 0;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FocusedColor = System.Drawing.Color.Empty;
            this.cbYear.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(280, 160);
            this.cbYear.Name = "cbYear";
            this.cbYear.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbYear.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbYear.Radius = 14;
            this.cbYear.Size = new System.Drawing.Size(170, 32);
            this.cbYear.TabIndex = 160;
            // 
            // frmCarFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(537, 687);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbTransmission);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtMaxumRentalDailyPrice);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtMinumRentalDailyPrice);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.cbFuleType);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarFilter";
            this.Text = "Car Filter";
            this.Load += new System.EventHandler(this.frmCarFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbMake;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbModel;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtMileage;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtMinumRentalDailyPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaComboBox cbFuleType;
        private Guna.UI.WinForms.GunaComboBox cbCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txtMaxumRentalDailyPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbTransmission;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI.WinForms.GunaComboBox cbStatus;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox cbYear;
    }
}