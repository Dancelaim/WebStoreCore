using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvFilter
    {
        public int FilterId { get; set; }
        public int FilterGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
