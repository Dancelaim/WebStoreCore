using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomFieldCustomerGroup
    {
        public int CustomFieldId { get; set; }
        public int CustomerGroupId { get; set; }
        public bool Required { get; set; }
    }
}
