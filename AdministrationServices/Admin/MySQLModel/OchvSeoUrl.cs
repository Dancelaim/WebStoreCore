using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvSeoUrl
    {
        public int SeoUrlId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Query { get; set; }
        public string Keyword { get; set; }
    }
}
