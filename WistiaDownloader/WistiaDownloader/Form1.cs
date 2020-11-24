using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WistiaDownloader
{
    public partial class Form1 : Form
    {
        private Queue<VideoQueueItem> VideoQueue { get; set; }
        private int DownloadsInProgress { get; set; } = 0;
        private int MaxDownloads { get; set; } = 2;
        private Dictionary<string, VideoQueueItem> CompletedDownloads { get; set; }

        public Form1()
        {
            InitializeComponent();

            VideoQueue = new Queue<VideoQueueItem>();
            CompletedDownloads = new Dictionary<string, VideoQueueItem>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            foreach (string line in linkTextBox.Lines)
            {
                int apdIndex = line.IndexOf("apd=");

                if (apdIndex == -1)
                    continue;

                try
                {
                    /*
                     * hhttps://apclassroom.collegeboard.org/8/home?apd=qyu6avch2l */
                    string key = line.Substring(line.IndexOf("apd=") + 4);

                    // download https://fast.wistia.net/embed/iframe/**?videoFoam=true

                    string remoteUri = $"https://fast.wistia.net/embed/iframe/{key}?videoFoam=true";

                    // Create a new WebClient instance.
                    WebClient wc = new WebClient();
                    string result = wc.DownloadString(remoteUri);


                    // remote url looks like this in result: https://embed-ssl.wistia.com/deliveries/66f732c9532bfac7eccc82115ad024a8.bin
                    Match m = Regex.Match(result, @"https://embed-ssl.wistia.com/deliveries/([a-z0-9]+\.bin)");

                    Match mt = Regex.Match(result, "<title>(.*?)</title>");

                    if (m.Groups.Count == 2)
                    {
                        string video = m.Value;
                        string videoFileName = MakeValidFileName(mt.Groups[1].Value);
                        string sourceFile = $"C:\\Users\\mike\\Desktop\\AP Lessons\\{videoFileName}";
                        string destFile = sourceFile + ".mp4";

                        VideoQueue.Enqueue(new VideoQueueItem
                        {
                            VideoURL = video,
                            VideoFileName = videoFileName,
                            Title = mt.Groups[1].Value,
                            DestinationFile = destFile
                        });

                    }
                }

                catch (Exception ex)
                {

                }
            }
        }



        private static string MakeValidFileName(string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void DownloaderTimer_Tick(object sender, EventArgs e)
        {
            if (VideoQueue.Count > 0 && DownloadsInProgress < MaxDownloads)
            {
                VideoQueueItem video = VideoQueue.Dequeue();

                if (CompletedDownloads.ContainsKey(video.VideoURL))
                {
                    return;
                }


                CompletedDownloads.Add(video.VideoURL, video);
                DownloadsInProgress++;

                

                /*
                Thread thread = new Thread(() => {
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri(video.VideoURL), video.DestinationFile);
                });
                thread.Start();
                */
                this.BeginInvoke((MethodInvoker)delegate
                {
                    DownloadControl dc = new DownloadControl(video);
                    dc.OnCompleted += () =>
                    {
                        DownloadsInProgress--;
                        downloadPanel.Controls.Remove(dc);
                    };
                    downloadPanel.Controls.Add(dc);
                });
            }
        }

        private void linkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!linkTextBox.Text.EndsWith("\n"))
                linkTextBox.Text += "\n";
        }

        private void linkTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!linkTextBox.Text.EndsWith("\n"))
                linkTextBox.Text += "\n";

            linkTextBox.SelectionStart = linkTextBox.Text.Length;
            linkTextBox.SelectionLength = 0;
        }

        private void linkTextBox_Enter(object sender, EventArgs e)
        {
            linkTextBox.SelectionStart = linkTextBox.Text.Length;
            linkTextBox.SelectionLength = 0;
        }
    }
}
