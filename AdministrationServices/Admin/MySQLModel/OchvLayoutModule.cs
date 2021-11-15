using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvLayoutModule
    {
        public int LayoutModuleId { get; set; }
        public int LayoutId { get; set; }
        public string Code { get; set; }
        public string Position { get; set; }
        public int SortOrder { get; set; }
    }
}
