namespace CarRental
{
    partial class frmCarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarInfo));
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlCarCard1 = new CarRental.ctrlCarCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnClose.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(842, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 157;
            // 
            // ctrlCarCard1
            // 
            this.ctrlCarCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlCarCard1.BackgroundImage")));
            this.ctrlCarCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlCarCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCarCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCarCard1.Name = "ctrlCarCard1";
            this.ctrlCarCard1.Size = new System.Drawing.Size(899, 404);
            this.ctrlCarCard1.TabIndex = 0;
            // 
            // frmCarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(899, 404);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlCarCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Info";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCarCard ctrlCarCard1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
    }
}