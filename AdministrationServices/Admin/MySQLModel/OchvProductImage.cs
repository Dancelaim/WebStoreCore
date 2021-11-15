using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
