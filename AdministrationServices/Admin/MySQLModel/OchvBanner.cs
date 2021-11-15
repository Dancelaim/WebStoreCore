using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBanner
    {
        public int BannerId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
