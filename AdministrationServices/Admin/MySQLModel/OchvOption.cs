using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOption
    {
        public int OptionId { get; set; }
        public string Type { get; set; }
        public int SortOrder { get; set; }
        public int? LimitCheckbox { get; set; }
    }
}
