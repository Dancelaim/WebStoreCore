using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDGdprRequest
    {
        public int Id { get; set; }
        public string RequestType { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string UserAgent { get; set; }
        public string RequestKey { get; set; }
        public byte Confirmed { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
