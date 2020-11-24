namespace WistiaDownloader
{
    partial class DownloadControl
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
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblFilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(70, 4);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "label1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 20);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(412, 23);
            this.progressBar.TabIndex = 1;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(5, 4);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(59, 13);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "lblFilename";
            this.lblFilename.Click += new System.EventHandler(this.lblFilename_Click);
            // 
            // DownloadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblProgress);
            this.Name = "DownloadControl";
            this.Size = new System.Drawing.Size(423, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblFilename;
    }
}
