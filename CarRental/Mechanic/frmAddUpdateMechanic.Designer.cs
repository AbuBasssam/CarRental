namespace CarRental
{
    partial class frmAddUpdateMechanic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMechanic));
            this.tpLoginInfo = new System.Windows.Forms.TabControl();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.ctrlUserCardWithFilter1 = new CarRental.ctrlUserCardWithFilter();
            this.tpMechanic = new System.Windows.Forms.TabPage();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.NumEnd = new Guna.UI.WinForms.GunaNumeric();
            this.NumBegin = new Guna.UI.WinForms.GunaNumeric();
            this.cbSpecialization = new Guna.UI.WinForms.GunaComboBox();
            this.chkAbilityToOverTime = new Guna.UI.WinForms.GunaCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMechanicID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tpLoginInfo.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.tpMechanic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.tpUser);
            this.tpLoginInfo.Controls.Add(this.tpMechanic);
            this.tpLoginInfo.Location = new System.Drawing.Point(7, 58);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.SelectedIndex = 0;
            this.tpLoginInfo.Size = new System.Drawing.Size(857, 516);
            this.tpLoginInfo.TabIndex = 3;
            // 
            // tpUser
            // 
            this.tpUser.BackColor = System.Drawing.Color.Transparent;
            this.tpUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpUser.Controls.Add(this.ctrlUserCardWithFilter1);
            this.tpUser.Location = new System.Drawing.Point(4, 25);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(849, 487);
            this.tpUser.TabIndex = 0;
            this.tpUser.Text = "User Info";
            // 
            // ctrlUserCardWithFilter1
            // 
            this.ctrlUserCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCardWithFilter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlUserCardWithFilter1.BackgroundImage")));
            this.ctrlUserCardWithFilter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlUserCardWithFilter1.FilterEnabled = true;
            this.ctrlUserCardWithFilter1.Location = new System.Drawing.Point(-4, 0);
            this.ctrlUserCardWithFilter1.Name = "ctrlUserCardWithFilter1";
            this.ctrlUserCardWithFilter1.Size = new System.Drawing.Size(857, 548);
            this.ctrlUserCardWithFilter1.TabIndex = 0;
            // 
            // tpMechanic
            // 
            this.tpMechanic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tpMechanic.BackgroundImage = global::CarRental.Properties.Resources.vector_OCT_2020_17_generated;
            this.tpMechanic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpMechanic.Controls.Add(this.gunaLabel2);
            this.tpMechanic.Controls.Add(this.gunaLabel1);
            this.tpMechanic.Controls.Add(this.NumEnd);
            this.tpMechanic.Controls.Add(this.NumBegin);
            this.tpMechanic.Controls.Add(this.cbSpecialization);
            this.tpMechanic.Controls.Add(this.chkAbilityToOverTime);
            this.tpMechanic.Controls.Add(this.label16);
            this.tpMechanic.Controls.Add(this.lblMechanicID);
            this.tpMechanic.Controls.Add(this.label11);
            this.tpMechanic.Controls.Add(this.label13);
            this.tpMechanic.Controls.Add(this.pictureBox12);
            this.tpMechanic.Controls.Add(this.pictureBox9);
            this.tpMechanic.Controls.Add(this.pictureBox10);
            this.tpMechanic.Location = new System.Drawing.Point(4, 25);
            this.tpMechanic.Name = "tpMechanic";
            this.tpMechanic.Padding = new System.Windows.Forms.Padding(3);
            this.tpMechanic.Size = new System.Drawing.Size(849, 487);
            this.tpMechanic.TabIndex = 1;
            this.tpMechanic.Text = "Mechanic Info";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel2.Location = new System.Drawing.Point(666, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 25);
            this.gunaLabel2.TabIndex = 152;
            this.gunaLabel2.Text = "PM";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel1.Location = new System.Drawing.Point(525, 149);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 25);
            this.gunaLabel1.TabIndex = 151;
            this.gunaLabel1.Text = "AM -";
            // 
            // NumEnd
            // 
            this.NumEnd.BackColor = System.Drawing.Color.Transparent;
            this.NumEnd.BaseColor = System.Drawing.Color.White;
            this.NumEnd.BorderColor = System.Drawing.Color.Silver;
            this.NumEnd.ButtonColor = System.Drawing.Color.Navy;
            this.NumEnd.ButtonForeColor = System.Drawing.Color.Cyan;
            this.NumEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumEnd.ForeColor = System.Drawing.Color.Black;
            this.NumEnd.Location = new System.Drawing.Point(585, 146);
            this.NumEnd.Maximum = ((long)(12));
            this.NumEnd.Minimum = ((long)(0));
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Radius = 15;
            this.NumEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumEnd.Size = new System.Drawing.Size(75, 30);
            this.NumEnd.TabIndex = 150;
            this.NumEnd.Text = "gunaNumeric2";
            this.NumEnd.Value = ((long)(0));
            // 
            // NumBegin
            // 
            this.NumBegin.BackColor = System.Drawing.Color.Transparent;
            this.NumBegin.BaseColor = System.Drawing.Color.White;
            this.NumBegin.BorderColor = System.Drawing.Color.Silver;
            this.NumBegin.ButtonColor = System.Drawing.Color.Navy;
            this.NumBegin.ButtonForeColor = System.Drawing.Color.Cyan;
            this.NumBegin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumBegin.ForeColor = System.Drawing.Color.Black;
            this.NumBegin.Location = new System.Drawing.Point(444, 145);
            this.NumBegin.Maximum = ((long)(12));
            this.NumBegin.Minimum = ((long)(0));
            this.NumBegin.Name = "NumBegin";
            this.NumBegin.Radius = 15;
            this.NumBegin.Size = new System.Drawing.Size(75, 30);
            this.NumBegin.TabIndex = 149;
            this.NumBegin.Text = "gunaNumeric1";
            this.NumBegin.Value = ((long)(0));
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecialization.BaseColor = System.Drawing.Color.White;
            this.cbSpecialization.BorderColor = System.Drawing.Color.Silver;
            this.cbSpecialization.BorderSize = 0;
            this.cbSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpecialization.FocusedColor = System.Drawing.Color.Empty;
            this.cbSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSpecialization.ForeColor = System.Drawing.Color.Black;
            this.cbSpecialization.FormattingEnabled = true;
            this.cbSpecialization.Items.AddRange(new object[] {
            "General ",
            "Brake and Suspension",
            "Transmission",
            "Automotive Electrical ",
            "HVAC",
            "Tire and Alignment "});
            this.cbSpecialization.Location = new System.Drawing.Point(444, 195);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cbSpecialization.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSpecialization.Radius = 15;
            this.cbSpecialization.Size = new System.Drawing.Size(187, 31);
            this.cbSpecialization.StartIndex = 0;
            this.cbSpecialization.TabIndex = 148;
            // 
            // chkAbilityToOverTime
            // 
            this.chkAbilityToOverTime.BaseColor = System.Drawing.Color.White;
            this.chkAbilityToOverTime.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkAbilityToOverTime.CheckedOnColor = System.Drawing.Color.RoyalBlue;
            this.chkAbilityToOverTime.FillColor = System.Drawing.Color.White;
            this.chkAbilityToOverTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbilityToOverTime.ForeColor = System.Drawing.Color.Navy;
            this.chkAbilityToOverTime.Location = new System.Drawing.Point(407, 246);
            this.chkAbilityToOverTime.Name = "chkAbilityToOverTime";
            this.chkAbilityToOverTime.Size = new System.Drawing.Size(210, 25);
            this.chkAbilityToOverTime.TabIndex = 147;
            this.chkAbilityToOverTime.Text = "Ability To Over Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(155, 195);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 25);
            this.label16.TabIndex = 137;
            this.label16.Text = "Areas Of Specialization:";
            // 
            // lblMechanicID
            // 
            this.lblMechanicID.AutoSize = true;
            this.lblMechanicID.BackColor = System.Drawing.Color.Transparent;
            this.lblMechanicID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMechanicID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMechanicID.Location = new System.Drawing.Point(447, 113);
            this.lblMechanicID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMechanicID.Name = "lblMechanicID";
            this.lblMechanicID.Size = new System.Drawing.Size(48, 25);
            this.lblMechanicID.TabIndex = 135;
            this.lblMechanicID.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(155, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 134;
            this.label11.Text = "MechanicID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(155, 151);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 25);
            this.label13.TabIndex = 132;
            this.label13.Text = "WorkSchedule :";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::CarRental.Properties.Resources.Specialization;
            this.pictureBox12.Location = new System.Drawing.Point(407, 194);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 140;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::CarRental.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(407, 113);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 136;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::CarRental.Properties.Resources.Work_schedule;
            this.pictureBox10.Location = new System.Drawing.Point(407, 149);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 133;
            this.pictureBox10.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(305, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Mechanic";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(642, 639);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 115;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(776, 639);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(735, 582);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btnPersonInfoNext.TabIndex = 120;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // frmAddUpdateMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(915, 690);
            this.Controls.Add(this.btnPersonInfoNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpLoginInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddUpdateMechanic";
            this.Text = "frmAddUpdateMechanic";
            this.Load += new System.EventHandler(this.frmAddUpdateMechanic_Load);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpUser.ResumeLayout(false);
            this.tpMechanic.ResumeLayout(false);
            this.tpMechanic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpLoginInfo;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.TabPage tpMechanic;
        private Guna.UI.WinForms.GunaCheckBox chkAbilityToOverTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMechanicID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaNumeric NumEnd;
        private Guna.UI.WinForms.GunaNumeric NumBegin;
        private Guna.UI.WinForms.GunaComboBox cbSpecialization;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private ctrlUserCardWithFilter ctrlUserCardWithFilter1;
    }
}