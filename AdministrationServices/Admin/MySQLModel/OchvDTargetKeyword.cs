using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDTargetKeyword
    {
        public string Route { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public int SortOrder { get; set; }
        public string Keyword { get; set; }
    }
}
