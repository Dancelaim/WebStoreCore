using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfQueryDescription
    {
        public int QueryId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public string H1 { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
