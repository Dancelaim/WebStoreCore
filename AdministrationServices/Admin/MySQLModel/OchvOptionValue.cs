using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOptionValue
    {
        public int OptionValueId { get; set; }
        public int OptionId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
