using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerTransaction
    {
        public int CustomerTransactionId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
