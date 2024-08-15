namespace CarRental
{
    partial class ctrlProfileCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlProfileCard));
            this.btnDetails = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.lblNatoinality = new Guna.UI.WinForms.GunaLabel();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.AnimationHoverSpeed = 0.07F;
            this.btnDetails.AnimationSpeed = 0.03F;
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BaseColor1 = System.Drawing.Color.Navy;
            this.btnDetails.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnDetails.BorderColor = System.Drawing.Color.Black;
            this.btnDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetails.FocusedColor = System.Drawing.Color.Transparent;
            this.btnDetails.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Image = null;
            this.btnDetails.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDetails.Location = new System.Drawing.Point(74, 14);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.OnHoverBaseColor1 = System.Drawing.Color.DarkBlue;
            this.btnDetails.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDetails.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDetails.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDetails.OnHoverImage = null;
            this.btnDetails.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnDetails.Radius = 20;
            this.btnDetails.Size = new System.Drawing.Size(164, 42);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "Detalis";
            this.btnDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.btnDetails);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Black;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 298);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(350, 152);
            this.gunaGradient2Panel1.TabIndex = 3;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnDelete);
            this.gunaGradientPanel1.Controls.Add(this.btnEdit);
            this.gunaGradientPanel1.Controls.Add(this.pbProfileImage);
            this.gunaGradientPanel1.Controls.Add(this.lblName);
            this.gunaGradientPanel1.Controls.Add(this.lblNatoinality);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.MediumBlue;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.DarkBlue;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.gunaGradientPanel1.Size = new System.Drawing.Size(350, 298);
            this.gunaGradientPanel1.TabIndex = 2;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProfileImage.Location = new System.Drawing.Point(74, 56);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(164, 120);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfileImage.TabIndex = 15;
            this.pbProfileImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(68, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 34);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Abu Bassam";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNatoinality
            // 
            this.lblNatoinality.BackColor = System.Drawing.Color.Transparent;
            this.lblNatoinality.Font = new System.Drawing.Font("Gadugi", 16F);
            this.lblNatoinality.ForeColor = System.Drawing.Color.Black;
            this.lblNatoinality.Location = new System.Drawing.Point(68, 245);
            this.lblNatoinality.Name = "lblNatoinality";
            this.lblNatoinality.Size = new System.Drawing.Size(170, 34);
            this.lblNatoinality.TabIndex = 13;
            this.lblNatoinality.Text = "Sayrian";
            this.lblNatoinality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEdit.Location = new System.Drawing.Point(249, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 36;
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
            this.btnDelete.Location = new System.Drawing.Point(8, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctrlProfileCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlProfileCard";
            this.Size = new System.Drawing.Size(350, 450);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaLabel lblNatoinality;
        private Guna.UI.WinForms.GunaGradientButton btnDetails;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}
