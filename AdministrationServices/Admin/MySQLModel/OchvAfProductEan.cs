using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfProductEan
    {
        public int ProductEanId { get; set; }
        public int? ProductId { get; set; }
        public int? EanId { get; set; }
    }
}
