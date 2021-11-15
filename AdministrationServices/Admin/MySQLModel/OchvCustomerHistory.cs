using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerHistory
    {
        public int CustomerHistoryId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
