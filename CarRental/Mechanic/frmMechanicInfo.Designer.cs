namespace CarRental
{
    partial class frmMechanicInfo
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
            this.ctrlMechanicCard1 = new CarRental.ctrlMechanicCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlMechanicCard1
            // 
            this.ctrlMechanicCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlMechanicCard1.Location = new System.Drawing.Point(12, -8);
            this.ctrlMechanicCard1.Name = "ctrlMechanicCard1";
            this.ctrlMechanicCard1.Size = new System.Drawing.Size(876, 545);
            this.ctrlMechanicCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::CarRental.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(754, 529);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMechanicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRental.Properties.Resources.vector_OCT_2020_17_generated;
            this.ClientSize = new System.Drawing.Size(892, 593);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlMechanicCard1);
            this.Name = "frmMechanicInfo";
            this.Text = "frmMechanicInfo";
            this.Load += new System.EventHandler(this.frmMechanicInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMechanicCard ctrlMechanicCard1;
        private System.Windows.Forms.Button btnClose;
    }
}