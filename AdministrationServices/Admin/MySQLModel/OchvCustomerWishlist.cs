using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerWishlist
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
