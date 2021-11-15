using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrderHistory
    {
        public int OrderHistoryId { get; set; }
        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }
        public bool Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
