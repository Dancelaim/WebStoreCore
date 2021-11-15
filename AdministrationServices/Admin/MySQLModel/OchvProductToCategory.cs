using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductToCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public bool MainCategory { get; set; }
    }
}
