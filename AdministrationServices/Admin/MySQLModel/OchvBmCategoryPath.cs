using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmCategoryPath
    {
        public int CategoryId { get; set; }
        public int PathId { get; set; }
        public int Level { get; set; }
    }
}
