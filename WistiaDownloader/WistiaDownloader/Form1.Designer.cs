namespace WistiaDownloader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.linkTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.downloadPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DownloaderTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(12, 28);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(434, 100);
            this.linkTextBox.TabIndex = 0;
            this.linkTextBox.Text = "";
            this.linkTextBox.TextChanged += new System.EventHandler(this.linkTextBox_TextChanged);
            this.linkTextBox.Enter += new System.EventHandler(this.linkTextBox_Enter);
            this.linkTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.linkTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "College Board Video Link";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(341, 135);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(101, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download Video";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // downloadPanel
            // 
            this.downloadPanel.Location = new System.Drawing.Point(12, 181);
            this.downloadPanel.Name = "downloadPanel";
            this.downloadPanel.Size = new System.Drawing.Size(434, 218);
            this.downloadPanel.TabIndex = 5;
            // 
            // DownloaderTimer
            // 
            this.DownloaderTimer.Enabled = true;
            this.DownloaderTimer.Interval = 1000;
            this.DownloaderTimer.Tick += new System.EventHandler(this.DownloaderTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 530);
            this.Controls.Add(this.downloadPanel);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkTextBox);
            this.Name = "Form1";
            this.Text = "College Board Video Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox linkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FlowLayoutPanel downloadPanel;
        private System.Windows.Forms.Timer DownloaderTimer;
    }
}

