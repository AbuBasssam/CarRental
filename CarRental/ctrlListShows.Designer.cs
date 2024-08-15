namespace CarRental
{
    partial class ctrlListShows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsOptoins = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPageNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsOptoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Location = new System.Drawing.Point(508, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Padding = new System.Windows.Forms.Padding(20);
            this.gunaLabel1.Size = new System.Drawing.Size(388, 80);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Regular Maintenance";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.ContextMenuStrip = this.cmsOptoins;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(0, 465);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 50;
            this.dgvList.RowTemplate.Height = 26;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1500, 235);
            this.dgvList.TabIndex = 2;
            this.dgvList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvList.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvList.ThemeStyle.ReadOnly = true;
            this.dgvList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvList.ThemeStyle.RowsStyle.Height = 26;
            this.dgvList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsOptoins
            // 
            this.cmsOptoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmsOptoins.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOptoins.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmUpdate,
            this.tsmDelete});
            this.cmsOptoins.Name = "cmsOptoins";
            this.cmsOptoins.RenderStyle.ArrowColor = System.Drawing.Color.Cyan;
            this.cmsOptoins.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsOptoins.RenderStyle.ColorTable = null;
            this.cmsOptoins.RenderStyle.RoundedEdges = true;
            this.cmsOptoins.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsOptoins.RenderStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.cmsOptoins.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsOptoins.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsOptoins.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmsOptoins.Size = new System.Drawing.Size(226, 112);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.ForeColor = System.Drawing.Color.Blue;
            this.tsmShowDetails.Image = global::CarRental.Properties.Resources.info;
            this.tsmShowDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tsmShowDetails.Size = new System.Drawing.Size(225, 36);
            this.tsmShowDetails.Text = "   Show Details";
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.ForeColor = System.Drawing.Color.Blue;
            this.tsmUpdate.Image = global::CarRental.Properties.Resources.updating;
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tsmUpdate.Size = new System.Drawing.Size(225, 36);
            this.tsmUpdate.Text = "   Update";
            // 
            // tsmDelete
            // 
            this.tsmDelete.ForeColor = System.Drawing.Color.Blue;
            this.tsmDelete.Image = global::CarRental.Properties.Resources.delete;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tsmDelete.Size = new System.Drawing.Size(225, 36);
            this.tsmDelete.Text = "   Delete";
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::CarRental.Properties.Resources.more;
            this.btnAdd.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAdd.Location = new System.Drawing.Point(1421, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 42;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CarRental.Properties.Resources.Regular_maintenance;
            this.guna2PictureBox1.Location = new System.Drawing.Point(587, 93);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(235, 220);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.AutoRoundedCorners = true;
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 17;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.Black;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBy.FocusedState.Parent = this.cbFilterBy;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.Cyan;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFilterBy.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFilterBy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFilterBy.HoverState.Parent = this.cbFilterBy;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbFilterBy.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbFilterBy.ItemsAppearance.Parent = this.cbFilterBy;
            this.cbFilterBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFilterBy.Location = new System.Drawing.Point(83, 352);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.ShadowDecoration.Parent = this.cbFilterBy;
            this.cbFilterBy.Size = new System.Drawing.Size(237, 36);
            this.cbFilterBy.TabIndex = 45;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel2.Location = new System.Drawing.Point(-5, 355);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel2.TabIndex = 44;
            this.gunaLabel2.Text = "Filter By";
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.AutoRoundedCorners = true;
            this.txtFilterBy.BorderRadius = 17;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.DisabledState.Parent = this.txtFilterBy;
            this.txtFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.FillColor = System.Drawing.Color.Black;
            this.txtFilterBy.FocusedState.BorderColor = System.Drawing.Color.Cyan;
            this.txtFilterBy.FocusedState.Parent = this.txtFilterBy;
            this.txtFilterBy.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.txtFilterBy.HoverState.Parent = this.txtFilterBy;
            this.txtFilterBy.Location = new System.Drawing.Point(327, 352);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Parent = this.txtFilterBy;
            this.txtFilterBy.Size = new System.Drawing.Size(233, 36);
            this.txtFilterBy.TabIndex = 43;
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
            this.cbPageNumber.FocusedState.Parent = this.cbPageNumber;
            this.cbPageNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPageNumber.ForeColor = System.Drawing.Color.Cyan;
            this.cbPageNumber.FormattingEnabled = true;
            this.cbPageNumber.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbPageNumber.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPageNumber.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPageNumber.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbPageNumber.HoverState.Parent = this.cbPageNumber;
            this.cbPageNumber.ItemHeight = 30;
            this.cbPageNumber.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbPageNumber.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbPageNumber.ItemsAppearance.Parent = this.cbPageNumber;
            this.cbPageNumber.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbPageNumber.Location = new System.Drawing.Point(704, 352);
            this.cbPageNumber.Name = "cbPageNumber";
            this.cbPageNumber.ShadowDecoration.Parent = this.cbPageNumber;
            this.cbPageNumber.Size = new System.Drawing.Size(237, 36);
            this.cbPageNumber.TabIndex = 47;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel3.Location = new System.Drawing.Point(571, 355);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 28);
            this.gunaLabel3.TabIndex = 46;
            this.gunaLabel3.Text = "PageNumber";
            // 
            // ctrlShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.cbPageNumber);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "ctrlShows";
            this.Size = new System.Drawing.Size(1500, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsOptoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI.WinForms.GunaContextMenuStrip cmsOptoins;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbPageNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}
