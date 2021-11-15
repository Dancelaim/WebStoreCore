using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCategoryToLayout
    {
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
