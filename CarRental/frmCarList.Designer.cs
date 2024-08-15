namespace CarRental
{
    partial class frmCarList
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
            this.cbPageNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbFindBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtFindBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlCarProfile12 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile11 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile10 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile9 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile8 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile7 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile1 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile6 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile4 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile3 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile2 = new CarRental.ctrlCarProfile();
            this.ctrlCarProfile5 = new CarRental.ctrlCarProfile();
            this.SuspendLayout();
            // 
            // cbPageNumber
            // 
            this.cbPageNumber.AutoRoundedCorners = true;
            this.cbPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbPageNumber.BorderRadius = 17;
            this.cbPageNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageNumber.FillColor = System.Drawing.Color.Black;
            this.cbPageNumber.FocusedColor = System.Drawing.Color.Empty;
            this.cbPageNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPageNumber.ForeColor = System.Drawing.Color.Cyan;
            this.cbPageNumber.FormattingEnabled = true;
            this.cbPageNumber.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbPageNumber.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPageNumber.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPageNumber.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbPageNumber.ItemHeight = 30;
            this.cbPageNumber.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbPageNumber.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbPageNumber.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbPageNumber.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPageNumber.Location = new System.Drawing.Point(171, 142);
            this.cbPageNumber.Name = "cbPageNumber";
            this.cbPageNumber.Size = new System.Drawing.Size(197, 36);
            this.cbPageNumber.TabIndex = 57;
            this.cbPageNumber.SelectedIndexChanged += new System.EventHandler(this.cbPageNumber_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(31, 144);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(131, 28);
            this.gunaLabel2.TabIndex = 56;
            this.gunaLabel2.Text = "Page Number";
            // 
            // btnFilter
            // 
            this.btnFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFilter.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFilter.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::CarRental.Properties.Resources.filter;
            this.btnFilter.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFilter.Location = new System.Drawing.Point(1151, 132);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(60, 60);
            this.btnFilter.TabIndex = 55;
            this.btnFilter.Tag = "OFF";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CarRental.Properties.Resources.more;
            this.btnAdd.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAdd.Location = new System.Drawing.Point(1085, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbFindBy
            // 
            this.cbFindBy.AutoRoundedCorners = true;
            this.cbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFindBy.BorderRadius = 17;
            this.cbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.FillColor = System.Drawing.Color.Black;
            this.cbFindBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFindBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindBy.ForeColor = System.Drawing.Color.Cyan;
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbFindBy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFindBy.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFindBy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFindBy.ItemHeight = 30;
            this.cbFindBy.Items.AddRange(new object[] {
            "ID",
            "Plate Number",
            "VIN"});
            this.cbFindBy.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbFindBy.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbFindBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFindBy.Location = new System.Drawing.Point(473, 142);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(197, 36);
            this.cbFindBy.StartIndex = 0;
            this.cbFindBy.TabIndex = 53;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel1.Location = new System.Drawing.Point(391, 144);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 28);
            this.gunaLabel1.TabIndex = 52;
            this.gunaLabel1.Text = "Find By";
            // 
            // txtFindBy
            // 
            this.txtFindBy.AutoRoundedCorners = true;
            this.txtFindBy.BorderRadius = 18;
            this.txtFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.DefaultText = "";
            this.txtFindBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindBy.FillColor = System.Drawing.Color.Black;
            this.txtFindBy.FocusedState.BorderColor = System.Drawing.Color.Cyan;
            this.txtFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindBy.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.txtFindBy.Location = new System.Drawing.Point(681, 143);
            this.txtFindBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindBy.Name = "txtFindBy";
            this.txtFindBy.PasswordChar = '\0';
            this.txtFindBy.PlaceholderText = "";
            this.txtFindBy.SelectedText = "";
            this.txtFindBy.Size = new System.Drawing.Size(233, 38);
            this.txtFindBy.TabIndex = 51;
            this.txtFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindBy_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("PMingLiU-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 33);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Cars";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 21;
            this.btnSearch.FillColor = System.Drawing.Color.Navy;
            this.btnSearch.FillColor2 = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(921, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 45);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlCarProfile12
            // 
            this.ctrlCarProfile12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile12.Location = new System.Drawing.Point(1055, 1242);
            this.ctrlCarProfile12.Name = "ctrlCarProfile12";
            this.ctrlCarProfile12.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile12.TabIndex = 69;
            // 
            // ctrlCarProfile11
            // 
            this.ctrlCarProfile11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile11.Location = new System.Drawing.Point(715, 1242);
            this.ctrlCarProfile11.Name = "ctrlCarProfile11";
            this.ctrlCarProfile11.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile11.TabIndex = 68;
            // 
            // ctrlCarProfile10
            // 
            this.ctrlCarProfile10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile10.Location = new System.Drawing.Point(375, 1242);
            this.ctrlCarProfile10.Name = "ctrlCarProfile10";
            this.ctrlCarProfile10.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile10.TabIndex = 67;
            // 
            // ctrlCarProfile9
            // 
            this.ctrlCarProfile9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile9.Location = new System.Drawing.Point(35, 1242);
            this.ctrlCarProfile9.Name = "ctrlCarProfile9";
            this.ctrlCarProfile9.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile9.TabIndex = 66;
            // 
            // ctrlCarProfile8
            // 
            this.ctrlCarProfile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile8.Location = new System.Drawing.Point(1055, 742);
            this.ctrlCarProfile8.Name = "ctrlCarProfile8";
            this.ctrlCarProfile8.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile8.TabIndex = 65;
            // 
            // ctrlCarProfile7
            // 
            this.ctrlCarProfile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile7.Location = new System.Drawing.Point(715, 742);
            this.ctrlCarProfile7.Name = "ctrlCarProfile7";
            this.ctrlCarProfile7.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile7.TabIndex = 64;
            // 
            // ctrlCarProfile1
            // 
            this.ctrlCarProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile1.Location = new System.Drawing.Point(35, 242);
            this.ctrlCarProfile1.Name = "ctrlCarProfile1";
            this.ctrlCarProfile1.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile1.TabIndex = 63;
            // 
            // ctrlCarProfile6
            // 
            this.ctrlCarProfile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile6.Location = new System.Drawing.Point(375, 742);
            this.ctrlCarProfile6.Name = "ctrlCarProfile6";
            this.ctrlCarProfile6.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile6.TabIndex = 62;
            // 
            // ctrlCarProfile4
            // 
            this.ctrlCarProfile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile4.Location = new System.Drawing.Point(1055, 242);
            this.ctrlCarProfile4.Name = "ctrlCarProfile4";
            this.ctrlCarProfile4.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile4.TabIndex = 61;
            // 
            // ctrlCarProfile3
            // 
            this.ctrlCarProfile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile3.Location = new System.Drawing.Point(715, 242);
            this.ctrlCarProfile3.Name = "ctrlCarProfile3";
            this.ctrlCarProfile3.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile3.TabIndex = 60;
            // 
            // ctrlCarProfile2
            // 
            this.ctrlCarProfile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile2.Location = new System.Drawing.Point(375, 242);
            this.ctrlCarProfile2.Name = "ctrlCarProfile2";
            this.ctrlCarProfile2.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile2.TabIndex = 59;
            // 
            // ctrlCarProfile5
            // 
            this.ctrlCarProfile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile5.Location = new System.Drawing.Point(35, 742);
            this.ctrlCarProfile5.Name = "ctrlCarProfile5";
            this.ctrlCarProfile5.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile5.TabIndex = 58;
            // 
            // frmCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1942, 838);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ctrlCarProfile12);
            this.Controls.Add(this.ctrlCarProfile11);
            this.Controls.Add(this.ctrlCarProfile10);
            this.Controls.Add(this.ctrlCarProfile9);
            this.Controls.Add(this.ctrlCarProfile8);
            this.Controls.Add(this.ctrlCarProfile7);
            this.Controls.Add(this.ctrlCarProfile1);
            this.Controls.Add(this.ctrlCarProfile6);
            this.Controls.Add(this.ctrlCarProfile4);
            this.Controls.Add(this.ctrlCarProfile3);
            this.Controls.Add(this.ctrlCarProfile2);
            this.Controls.Add(this.ctrlCarProfile5);
            this.Controls.Add(this.cbPageNumber);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFindBy);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtFindBy);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarList";
            this.Text = "frmCarList";
            this.Load += new System.EventHandler(this.frmCarList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbPageNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbFindBy;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindBy;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private ctrlCarProfile ctrlCarProfile2;
        private ctrlCarProfile ctrlCarProfile3;
        private ctrlCarProfile ctrlCarProfile4;
        private ctrlCarProfile ctrlCarProfile6;
        private ctrlCarProfile ctrlCarProfile1;
        private ctrlCarProfile ctrlCarProfile7;
        private ctrlCarProfile ctrlCarProfile8;
        private ctrlCarProfile ctrlCarProfile5;
        private ctrlCarProfile ctrlCarProfile9;
        private ctrlCarProfile ctrlCarProfile10;
        private ctrlCarProfile ctrlCarProfile11;
        private ctrlCarProfile ctrlCarProfile12;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
    }
}