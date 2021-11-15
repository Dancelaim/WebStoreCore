using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCouponProduct
    {
        public int CouponProductId { get; set; }
        public int CouponId { get; set; }
        public int ProductId { get; set; }
    }
}
