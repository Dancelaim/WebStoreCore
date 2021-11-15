using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerOnline
    {
        public string Ip { get; set; }
        public int CustomerId { get; set; }
        public string Url { get; set; }
        public string Referer { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
