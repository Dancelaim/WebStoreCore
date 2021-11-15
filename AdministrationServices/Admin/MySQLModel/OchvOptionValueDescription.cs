using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOptionValueDescription
    {
        public int OptionValueId { get; set; }
        public int LanguageId { get; set; }
        public int OptionId { get; set; }
        public string Name { get; set; }
        public string OptionTooltip { get; set; }
    }
}
