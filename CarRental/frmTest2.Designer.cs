namespace CarRental
{
    partial class frmTest2
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
            this.ctrlShows1 = new CarRental.ctrlListShows();
            this.SuspendLayout();
            // 
            // ctrlShows1
            // 
            this.ctrlShows1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ctrlShows1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShows1.Name = "ctrlShows1";
            this.ctrlShows1.Size = new System.Drawing.Size(1505, 653);
            this.ctrlShows1.TabIndex = 0;
            // 
            // frmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1472, 643);
            this.Controls.Add(this.ctrlShows1);
            this.Name = "frmTest2";
            this.Text = "frmTest2";
            this.Load += new System.EventHandler(this.frmTest2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlListShows ctrlShows1;
    }
}