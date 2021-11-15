using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterHistoryTemplateDescription
    {
        public int TemplateId { get; set; }
        public int LanguageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
