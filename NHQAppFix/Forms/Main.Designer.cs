namespace NHQAppFix.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbAppFixList = new System.Windows.Forms.ComboBox();
            this.lblMedList = new System.Windows.Forms.Label();
            this.pbNovaHQ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaHQ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 174);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(177, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install / Update Selected App Fix";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(9, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(283, 102);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // cbAppFixList
            // 
            this.cbAppFixList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppFixList.FormattingEnabled = true;
            this.cbAppFixList.Location = new System.Drawing.Point(12, 138);
            this.cbAppFixList.Name = "cbAppFixList";
            this.cbAppFixList.Size = new System.Drawing.Size(280, 21);
            this.cbAppFixList.TabIndex = 0;
            this.cbAppFixList.SelectedIndexChanged += new System.EventHandler(this.cbAppFixList_SelectedIndexChanged);
            // 
            // lblMedList
            // 
            this.lblMedList.AutoSize = true;
            this.lblMedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMedList.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMedList.Location = new System.Drawing.Point(12, 111);
            this.lblMedList.Name = "lblMedList";
            this.lblMedList.Size = new System.Drawing.Size(270, 13);
            this.lblMedList.TabIndex = 4;
            this.lblMedList.Text = "Click here to see compatible NL Mission Editors (MEDS)\r\n";
            this.lblMedList.Click += new System.EventHandler(this.lblMedList_Click);
            // 
            // pbNovaHQ
            // 
            this.pbNovaHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNovaHQ.InitialImage = global::NHQAppFix.Properties.Resources.NovaHQ;
            this.pbNovaHQ.Location = new System.Drawing.Point(192, 172);
            this.pbNovaHQ.Name = "pbNovaHQ";
            this.pbNovaHQ.Size = new System.Drawing.Size(100, 25);
            this.pbNovaHQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNovaHQ.TabIndex = 2;
            this.pbNovaHQ.TabStop = false;
            this.pbNovaHQ.Tag = "";
            this.pbNovaHQ.Click += new System.EventHandler(this.pbNovaHQ_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 206);
            this.Controls.Add(this.lblMedList);
            this.Controls.Add(this.cbAppFixList);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbNovaHQ);
            this.Controls.Add(this.btnInstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "NovaHQ App Fix Installer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaHQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.PictureBox pbNovaHQ;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbAppFixList;
        private System.Windows.Forms.Label lblMedList;
    }
}

