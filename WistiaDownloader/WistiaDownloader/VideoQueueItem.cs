using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WistiaDownloader
{
    public class VideoQueueItem
    {
        public string VideoURL { get; set; }
        public string VideoFileName { get; set; }
        public string DestinationFile { get; set; }
        public string Title { get; set; }
    }
}
