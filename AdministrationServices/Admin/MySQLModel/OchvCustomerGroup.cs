using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerGroup
    {
        public int CustomerGroupId { get; set; }
        public int Approval { get; set; }
        public int SortOrder { get; set; }
    }
}
