using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCategoryToGoogleProductCategory
    {
        public string GoogleProductCategory { get; set; }
        public int StoreId { get; set; }
        public int CategoryId { get; set; }
    }
}
