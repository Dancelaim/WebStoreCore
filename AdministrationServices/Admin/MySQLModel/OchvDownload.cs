using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDownload
    {
        public int DownloadId { get; set; }
        public string Filename { get; set; }
        public string Mask { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
