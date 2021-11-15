using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterTask
    {
        public int TaskId { get; set; }
        public int SendMode { get; set; }
        public int DateMode { get; set; }
        public int CountDay { get; set; }
        public DateTime DateSend { get; set; }
        public int TemplateId { get; set; }
        public string Filter { get; set; }
        public string Addressees { get; set; }
        public DateTime LatestSend { get; set; }
    }
}
