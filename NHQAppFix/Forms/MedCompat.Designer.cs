namespace NHQAppFix.Forms
{
    partial class MedCompat
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
            this.pbMedCompat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedCompat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMedCompat
            // 
            this.pbMedCompat.BackColor = System.Drawing.Color.White;
            this.pbMedCompat.Location = new System.Drawing.Point(12, 12);
            this.pbMedCompat.Name = "pbMedCompat";
            this.pbMedCompat.Size = new System.Drawing.Size(192, 567);
            this.pbMedCompat.TabIndex = 0;
            this.pbMedCompat.TabStop = false;
            // 
            // MedCompat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 591);
            this.Controls.Add(this.pbMedCompat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedCompat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MED Compatibility";
            this.Load += new System.EventHandler(this.MedCompat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMedCompat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMedCompat;
    }
}