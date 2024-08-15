namespace CarRental
{
    partial class ctrlUserCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlUserCardWithFilter));
            this.gbFilters = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txtIDValue = new Guna.UI.WinForms.GunaTextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFind = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserCard1 = new CarRental.ctrlUserCard();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.Color.Transparent;
            this.gbFilters.Controls.Add(this.txtIDValue);
            this.gbFilters.Controls.Add(this.btnAdd);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.gunaLabel1);
            this.gbFilters.GradientColor1 = System.Drawing.Color.Transparent;
            this.gbFilters.GradientColor2 = System.Drawing.Color.Transparent;
            this.gbFilters.Location = new System.Drawing.Point(3, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(847, 77);
            this.gbFilters.TabIndex = 0;
            // 
            // txtIDValue
            // 
            this.txtIDValue.BaseColor = System.Drawing.Color.White;
            this.txtIDValue.BorderColor = System.Drawing.Color.Navy;
            this.txtIDValue.BorderSize = 0;
            this.txtIDValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIDValue.FocusedBorderColor = System.Drawing.Color.Navy;
            this.txtIDValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDValue.Location = new System.Drawing.Point(55, 23);
            this.txtIDValue.Name = "txtIDValue";
            this.txtIDValue.PasswordChar = '\0';
            this.txtIDValue.SelectedText = "";
            this.txtIDValue.Size = new System.Drawing.Size(287, 34);
            this.txtIDValue.TabIndex = 4;
            this.txtIDValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDValue_KeyPress);
            this.txtIDValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDValue_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.White;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = null;
            this.btnAdd.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CarRental.Properties.Resources.AddNew_User;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.LineColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(434, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(54, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BaseColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.Navy;
            this.btnFind.CheckedBaseColor = System.Drawing.Color.White;
            this.btnFind.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnFind.CheckedForeColor = System.Drawing.Color.White;
            this.btnFind.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFind.CheckedImage")));
            this.btnFind.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::CarRental.Properties.Resources.find;
            this.btnFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFind.LineColor = System.Drawing.Color.Blue;
            this.btnFind.Location = new System.Drawing.Point(364, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnHoverLineColor = System.Drawing.Color.White;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Size = new System.Drawing.Size(54, 42);
            this.btnFind.TabIndex = 3;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(9, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlUserCard1.Location = new System.Drawing.Point(0, 83);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(850, 410);
            this.ctrlUserCard1.TabIndex = 1;
            // 
            // ctrlUserCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CarRental.Properties.Resources.vector_OCT_2020_17_generated;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlUserCardWithFilter";
            this.Size = new System.Drawing.Size(847, 544);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gbFilters;
        private Guna.UI.WinForms.GunaTextBox txtIDValue;
        private Guna.UI.WinForms.GunaAdvenceButton btnFind;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlUserCard ctrlUserCard1;
    }
}
