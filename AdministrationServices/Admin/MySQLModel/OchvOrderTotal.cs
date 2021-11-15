using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrderTotal
    {
        public int OrderTotalId { get; set; }
        public int OrderId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public int SortOrder { get; set; }
    }
}
