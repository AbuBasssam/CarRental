namespace CarRental
{
    partial class frmProfiles
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
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ctrlProfileCard10 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard4 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard8 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard9 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard7 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard6 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard5 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard3 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard2 = new CarRental.ctrlProfileCard();
            this.ctrlProfileCard1 = new CarRental.ctrlProfileCard();
            this.SuspendLayout();
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
            this.txtFilterBy.Location = new System.Drawing.Point(305, 7);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Parent = this.txtFilterBy;
            this.txtFilterBy.Size = new System.Drawing.Size(233, 36);
            this.txtFilterBy.TabIndex = 37;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaLabel1.Location = new System.Drawing.Point(13, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Filter By";
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
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.Cyan;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFilterBy.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFilterBy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFilterBy.HoverState.Parent = this.cbFilterBy;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "First Name",
            "National No",
            "Phone Number"});
            this.cbFilterBy.ItemsAppearance.BackColor = System.Drawing.Color.Navy;
            this.cbFilterBy.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.cbFilterBy.ItemsAppearance.Parent = this.cbFilterBy;
            this.cbFilterBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cbFilterBy.Location = new System.Drawing.Point(101, 7);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.ShadowDecoration.Parent = this.cbFilterBy;
            this.cbFilterBy.Size = new System.Drawing.Size(197, 36);
            this.cbFilterBy.TabIndex = 40;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            this.btnAdd.Location = new System.Drawing.Point(545, -1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.AnimationHoverSpeed = 0.07F;
            this.btnNextPage.AnimationSpeed = 0.03F;
            this.btnNextPage.BaseColor = System.Drawing.Color.MidnightBlue;
            this.btnNextPage.BorderColor = System.Drawing.Color.Black;
            this.btnNextPage.CheckedBaseColor = System.Drawing.Color.MediumBlue;
            this.btnNextPage.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNextPage.CheckedForeColor = System.Drawing.Color.White;
            this.btnNextPage.CheckedImage = null;
            this.btnNextPage.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNextPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextPage.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Image = global::CarRental.Properties.Resources.right_arrow;
            this.btnNextPage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextPage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextPage.LineColor = System.Drawing.Color.MediumBlue;
            this.btnNextPage.Location = new System.Drawing.Point(750, 1476);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.OnHoverBaseColor = System.Drawing.Color.MediumBlue;
            this.btnNextPage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextPage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextPage.OnHoverImage = null;
            this.btnNextPage.OnHoverLineColor = System.Drawing.Color.Black;
            this.btnNextPage.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextPage.Size = new System.Drawing.Size(154, 44);
            this.btnNextPage.TabIndex = 35;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // ctrlProfileCard10
            // 
            this.ctrlProfileCard10.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard10.Location = new System.Drawing.Point(374, 1127);
            this.ctrlProfileCard10.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard10.Name = "ctrlProfileCard10";
            this.ctrlProfileCard10.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard10.TabIndex = 36;
            this.ctrlProfileCard10.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard10.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard4
            // 
            this.ctrlProfileCard4.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard4.Location = new System.Drawing.Point(1089, 192);
            this.ctrlProfileCard4.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard4.Name = "ctrlProfileCard4";
            this.ctrlProfileCard4.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard4.TabIndex = 34;
            this.ctrlProfileCard4.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard4.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard8
            // 
            this.ctrlProfileCard8.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard8.Location = new System.Drawing.Point(1089, 660);
            this.ctrlProfileCard8.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard8.Name = "ctrlProfileCard8";
            this.ctrlProfileCard8.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard8.TabIndex = 33;
            this.ctrlProfileCard8.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard8.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard9
            // 
            this.ctrlProfileCard9.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard9.Location = new System.Drawing.Point(18, 1127);
            this.ctrlProfileCard9.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard9.Name = "ctrlProfileCard9";
            this.ctrlProfileCard9.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard9.TabIndex = 32;
            this.ctrlProfileCard9.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard9.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard7
            // 
            this.ctrlProfileCard7.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard7.Location = new System.Drawing.Point(730, 660);
            this.ctrlProfileCard7.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard7.Name = "ctrlProfileCard7";
            this.ctrlProfileCard7.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard7.TabIndex = 31;
            this.ctrlProfileCard7.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard7.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard6
            // 
            this.ctrlProfileCard6.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard6.Location = new System.Drawing.Point(374, 660);
            this.ctrlProfileCard6.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard6.Name = "ctrlProfileCard6";
            this.ctrlProfileCard6.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard6.TabIndex = 30;
            this.ctrlProfileCard6.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard6.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard5
            // 
            this.ctrlProfileCard5.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard5.Location = new System.Drawing.Point(18, 660);
            this.ctrlProfileCard5.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard5.Name = "ctrlProfileCard5";
            this.ctrlProfileCard5.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard5.TabIndex = 29;
            this.ctrlProfileCard5.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard5.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard3
            // 
            this.ctrlProfileCard3.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard3.Location = new System.Drawing.Point(730, 192);
            this.ctrlProfileCard3.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard3.Name = "ctrlProfileCard3";
            this.ctrlProfileCard3.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard3.TabIndex = 28;
            this.ctrlProfileCard3.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard3.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard2
            // 
            this.ctrlProfileCard2.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard2.Location = new System.Drawing.Point(374, 192);
            this.ctrlProfileCard2.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard2.Name = "ctrlProfileCard2";
            this.ctrlProfileCard2.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard2.TabIndex = 27;
            this.ctrlProfileCard2.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard2.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // ctrlProfileCard1
            // 
            this.ctrlProfileCard1.BackColor = System.Drawing.Color.Black;
            this.ctrlProfileCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlProfileCard1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlProfileCard1.Location = new System.Drawing.Point(18, 192);
            this.ctrlProfileCard1.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlProfileCard1.Name = "ctrlProfileCard1";
            this.ctrlProfileCard1.Size = new System.Drawing.Size(350, 450);
            this.ctrlProfileCard1.TabIndex = 26;
            this.ctrlProfileCard1.EditionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.EditionEventArgs>(this.ctrlProfileCard_EditionOpreationCompleted);
            this.ctrlProfileCard1.DeletionOpreationCompleted += new System.EventHandler<CarRental.ctrlProfileCard.DeletionEventArgs>(this.ctrlProfileCard_DeletionOpreationCompleted);
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1984, 838);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.ctrlProfileCard10);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.ctrlProfileCard4);
            this.Controls.Add(this.ctrlProfileCard8);
            this.Controls.Add(this.ctrlProfileCard9);
            this.Controls.Add(this.ctrlProfileCard7);
            this.Controls.Add(this.ctrlProfileCard6);
            this.Controls.Add(this.ctrlProfileCard5);
            this.Controls.Add(this.ctrlProfileCard3);
            this.Controls.Add(this.ctrlProfileCard2);
            this.Controls.Add(this.ctrlProfileCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfiles";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frmProfiles";
            this.Load += new System.EventHandler(this.frmProfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnNextPage;
        private ctrlProfileCard ctrlProfileCard4;
        private ctrlProfileCard ctrlProfileCard8;
        private ctrlProfileCard ctrlProfileCard9;
        private ctrlProfileCard ctrlProfileCard7;
        private ctrlProfileCard ctrlProfileCard6;
        private ctrlProfileCard ctrlProfileCard5;
        private ctrlProfileCard ctrlProfileCard3;
        private ctrlProfileCard ctrlProfileCard2;
        private ctrlProfileCard ctrlProfileCard1;
        private ctrlProfileCard ctrlProfileCard10;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}