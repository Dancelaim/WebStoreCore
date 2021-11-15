using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvInformation
    {
        public int InformationId { get; set; }
        public int Bottom { get; set; }
        public int SortOrder { get; set; }
        public bool? Status { get; set; }
    }
}
