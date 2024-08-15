namespace CarRental
{
    partial class frmTest
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlCarProfile1 = new CarRental.ctrlCarProfile();
            this.ctrlRegularMaintenanceTypeRecord1 = new CarRental.ctrlRegularMaintenanceTypeRecord();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchResult);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 40);
            this.panel1.TabIndex = 10;
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.BorderThickness = 0;
            this.txtSearchResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchResult.DefaultText = "";
            this.txtSearchResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchResult.Location = new System.Drawing.Point(4, 6);
            this.txtSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.PasswordChar = '\0';
            this.txtSearchResult.PlaceholderText = "";
            this.txtSearchResult.SelectedText = "";
            this.txtSearchResult.Size = new System.Drawing.Size(282, 30);
            this.txtSearchResult.TabIndex = 4;
            this.txtSearchResult.TextChanged += new System.EventHandler(this.txtSearchResult_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(290, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(117, 40);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Search";
            // 
            // ctrlCarProfile1
            // 
            this.ctrlCarProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctrlCarProfile1.Location = new System.Drawing.Point(742, 12);
            this.ctrlCarProfile1.Name = "ctrlCarProfile1";
            this.ctrlCarProfile1.Size = new System.Drawing.Size(310, 470);
            this.ctrlCarProfile1.TabIndex = 12;
            // 
            // ctrlRegularMaintenanceTypeRecord1
            // 
            this.ctrlRegularMaintenanceTypeRecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ctrlRegularMaintenanceTypeRecord1.EnableUpdate = true;
            this.ctrlRegularMaintenanceTypeRecord1.Location = new System.Drawing.Point(1, 160);
            this.ctrlRegularMaintenanceTypeRecord1.Name = "ctrlRegularMaintenanceTypeRecord1";
            this.ctrlRegularMaintenanceTypeRecord1.RegularMaintenanceType = CarRental_BusinessLayer.clsRegularMaintenanceType.enRegularMaintenanceType.OilChange;
            this.ctrlRegularMaintenanceTypeRecord1.Size = new System.Drawing.Size(524, 107);
            this.ctrlRegularMaintenanceTypeRecord1.TabIndex = 11;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(471, 338);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(224, 36);
            this.guna2ComboBox1.TabIndex = 13;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 609);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.ctrlCarProfile1);
            this.Controls.Add(this.ctrlRegularMaintenanceTypeRecord1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Button1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ctrlRegularMaintenanceTypeRecord ctrlRegularMaintenanceTypeRecord1;
        private ctrlCarProfile ctrlCarProfile1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}