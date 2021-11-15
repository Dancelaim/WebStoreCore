using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerIp
    {
        public int CustomerIpId { get; set; }
        public int CustomerId { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
