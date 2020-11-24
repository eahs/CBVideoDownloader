using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Deployment.Application;
using System.Net;

namespace WistiaDownloader
{
    public delegate void Notify();

    public partial class DownloadControl : UserControl
    {
        public DownloadControl(VideoQueueItem video)
        {
            InitializeComponent();

            lblFilename.Text = video.VideoFileName;

            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(video.VideoURL), video.DestinationFile);
            });
            thread.Start();

            // On completed: OnCompleted?.Invoke(); 
        }

        void client_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                //lblProgress.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
            
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            this.BeginInvoke((MethodInvoker)delegate {
                if (OnCompleted != null)
                {
                    OnCompleted?.Invoke();
                }
            });


        }

        public event Notify OnCompleted;

        private void lblFilename_Click(object sender, EventArgs e)
        {

        }
    }
}
