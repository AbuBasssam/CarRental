namespace CarRental
{
    partial class frmTransactionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbPageNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPageNumber = new Guna.UI.WinForms.GunaLabel();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbYearFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbMonthFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.cbPageNumber.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbPageNumber.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbPageNumber.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPageNumber.Location = new System.Drawing.Point(840, 346);
            this.cbPageNumber.Name = "cbPageNumber";
            this.cbPageNumber.Size = new System.Drawing.Size(237, 36);
            this.cbPageNumber.TabIndex = 65;
            this.cbPageNumber.SelectedIndexChanged += new System.EventHandler(this.cbPageNumber_SelectedIndexChanged);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.AutoSize = true;
            this.txtPageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNumber.ForeColor = System.Drawing.Color.Cyan;
            this.txtPageNumber.Location = new System.Drawing.Point(703, 349);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(131, 28);
            this.txtPageNumber.TabIndex = 64;
            this.txtPageNumber.Text = "Page Number";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeight = 25;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(0, 409);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 50;
            this.dgvTransactions.RowTemplate.Height = 26;
            this.dgvTransactions.Size = new System.Drawing.Size(1924, 382);
            this.dgvTransactions.TabIndex = 63;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvTransactions.ThemeStyle.ReadOnly = true;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 26;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbYearFilter
            // 
            this.cbYearFilter.AutoRoundedCorners = true;
            this.cbYearFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbYearFilter.BorderRadius = 17;
            this.cbYearFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearFilter.FillColor = System.Drawing.Color.Black;
            this.cbYearFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbYearFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearFilter.ForeColor = System.Drawing.Color.Cyan;
            this.cbYearFilter.FormattingEnabled = true;
            this.cbYearFilter.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbYearFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbYearFilter.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbYearFilter.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbYearFilter.ItemHeight = 30;
            this.cbYearFilter.Items.AddRange(new object[] {
            "none"});
            this.cbYearFilter.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbYearFilter.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbYearFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbYearFilter.Location = new System.Drawing.Point(416, 346);
            this.cbYearFilter.Name = "cbYearFilter";
            this.cbYearFilter.Size = new System.Drawing.Size(237, 36);
            this.cbYearFilter.StartIndex = 0;
            this.cbYearFilter.TabIndex = 62;
            this.cbYearFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBoxes_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel3.Location = new System.Drawing.Point(361, 349);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(48, 28);
            this.gunaLabel3.TabIndex = 61;
            this.gunaLabel3.Text = "Year";
            // 
            // cbMonthFilter
            // 
            this.cbMonthFilter.AutoRoundedCorners = true;
            this.cbMonthFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbMonthFilter.BorderRadius = 17;
            this.cbMonthFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonthFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthFilter.FillColor = System.Drawing.Color.Black;
            this.cbMonthFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbMonthFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthFilter.ForeColor = System.Drawing.Color.Cyan;
            this.cbMonthFilter.FormattingEnabled = true;
            this.cbMonthFilter.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbMonthFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbMonthFilter.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbMonthFilter.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbMonthFilter.ItemHeight = 30;
            this.cbMonthFilter.Items.AddRange(new object[] {
            "none",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonthFilter.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbMonthFilter.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbMonthFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbMonthFilter.Location = new System.Drawing.Point(99, 346);
            this.cbMonthFilter.Name = "cbMonthFilter";
            this.cbMonthFilter.Size = new System.Drawing.Size(237, 36);
            this.cbMonthFilter.StartIndex = 0;
            this.cbMonthFilter.TabIndex = 60;
            this.cbMonthFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBoxes_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(11, 349);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 28);
            this.gunaLabel2.TabIndex = 59;
            this.gunaLabel2.Text = "Month";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CarRental.Properties.Resources.Transaction;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(675, 87);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(287, 220);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 58;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Location = new System.Drawing.Point(701, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Padding = new System.Windows.Forms.Padding(20);
            this.gunaLabel1.Size = new System.Drawing.Size(253, 80);
            this.gunaLabel1.TabIndex = 57;
            this.gunaLabel1.Text = "Transactions";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1924, 791);
            this.Controls.Add(this.cbPageNumber);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.cbYearFilter);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbMonthFilter);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionList";
            this.Text = "frmTransactionList";
            this.Load += new System.EventHandler(this.frmTransactoinsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbPageNumber;
        private Guna.UI.WinForms.GunaLabel txtPageNumber;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private Guna.UI2.WinForms.Guna2ComboBox cbYearFilter;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbMonthFilter;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}