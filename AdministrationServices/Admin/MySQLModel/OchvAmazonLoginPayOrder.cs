using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAmazonLoginPayOrder
    {
        public int AmazonLoginPayOrderId { get; set; }
        public int OrderId { get; set; }
        public string AmazonOrderReferenceId { get; set; }
        public string AmazonAuthorizationId { get; set; }
        public byte FreeShipping { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime Modified { get; set; }
        public int? CaptureStatus { get; set; }
        public int? CancelStatus { get; set; }
        public int? RefundStatus { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Total { get; set; }
    }
}
