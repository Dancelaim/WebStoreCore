using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCoupon
    {
        public int CouponId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public decimal Discount { get; set; }
        public bool Logged { get; set; }
        public bool Shipping { get; set; }
        public decimal Total { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int UsesTotal { get; set; }
        public string UsesCustomer { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
