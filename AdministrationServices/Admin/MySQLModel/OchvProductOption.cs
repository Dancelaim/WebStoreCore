using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductOption
    {
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public string Value { get; set; }
        public bool Required { get; set; }
        public int MasterOption { get; set; }
        public int MasterOptionValue { get; set; }
    }
}
