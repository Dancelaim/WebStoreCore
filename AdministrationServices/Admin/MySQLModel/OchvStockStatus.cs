using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvStockStatus
    {
        public int StockStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
