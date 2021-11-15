using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductSpecial
    {
        public int ProductSpecialId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
