using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmPostDescription
    {
        public int PostDescriptionId { get; set; }
        public int PostId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string Tag { get; set; }
        public string ReadTime { get; set; }
    }
}
