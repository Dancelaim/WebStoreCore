using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCouponHistory
    {
        public int CouponHistoryId { get; set; }
        public int CouponId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
