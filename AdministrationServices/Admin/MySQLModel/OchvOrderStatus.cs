using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrderStatus
    {
        public int OrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
