using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCoinbaseCommerceOrder
    {
        public int Id { get; set; }
        public int StoreOrderId { get; set; }
        public float StoreTotalAmount { get; set; }
        public string CoinbaseCommerceChargeCode { get; set; }
        public string CoinbaseCommerceTransactionId { get; set; }
        public string CoinbaseCommerceStatus { get; set; }
        public float? CoinbaseCommerceCoinsExpected { get; set; }
        public float? CoinbaseCommerceCoinsReceived { get; set; }
        public string CoinbaseCommerceReceivedCurrency { get; set; }
    }
}
