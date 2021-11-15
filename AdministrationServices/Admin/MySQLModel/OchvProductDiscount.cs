using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductDiscount
    {
        public int ProductDiscountId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Quantity { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
