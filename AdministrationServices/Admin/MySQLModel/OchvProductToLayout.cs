using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductToLayout
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
