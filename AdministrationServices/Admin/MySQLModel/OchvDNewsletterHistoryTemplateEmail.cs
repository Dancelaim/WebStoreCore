using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterHistoryTemplateEmail
    {
        public int TemplateId { get; set; }
        public int LanguageId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string View { get; set; }
        public bool? Send { get; set; }
        public string SiteVisited { get; set; }
        public int? StoreId { get; set; }
    }
}
