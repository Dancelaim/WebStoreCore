using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfProductTag
    {
        public int ProductTagId { get; set; }
        public int? ProductId { get; set; }
        public int? TagId { get; set; }
    }
}
