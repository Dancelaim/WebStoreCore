using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDownloadDescription
    {
        public int DownloadId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
