using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAmazonLoginPayOrderTransaction
    {
        public int AmazonLoginPayOrderTransactionId { get; set; }
        public int AmazonLoginPayOrderId { get; set; }
        public string AmazonAuthorizationId { get; set; }
        public string AmazonCaptureId { get; set; }
        public string AmazonRefundId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
    }
}
