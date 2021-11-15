using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerApproval
    {
        public int CustomerApprovalId { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
