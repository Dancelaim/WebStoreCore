using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductRecurring
    {
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public int CustomerGroupId { get; set; }
    }
}
