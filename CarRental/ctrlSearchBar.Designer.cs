namespace CarRental
{
    partial class ctrlSearchBar
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlCirculePictureBox1 = new CarRental.ctrlCirculePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCirculePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(67, 26);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(42, 23);
            this.lblSubTitle.TabIndex = 3;
            this.lblSubTitle.Text = "Title";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(67, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // ctrlCirculePictureBox1
            // 
            this.ctrlCirculePictureBox1.Image = global::CarRental.Properties.Resources.MaleUser;
            this.ctrlCirculePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.ctrlCirculePictureBox1.Name = "ctrlCirculePictureBox1";
            this.ctrlCirculePictureBox1.Size = new System.Drawing.Size(48, 42);
            this.ctrlCirculePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ctrlCirculePictureBox1.TabIndex = 0;
            this.ctrlCirculePictureBox1.TabStop = false;
            // 
            // ctrlSearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlCirculePictureBox1);
            this.Name = "ctrlSearchBar";
            this.Size = new System.Drawing.Size(290, 50);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCirculePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlCirculePictureBox ctrlCirculePictureBox1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
