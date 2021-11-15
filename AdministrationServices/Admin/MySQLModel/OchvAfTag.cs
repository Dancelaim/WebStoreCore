using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfTag
    {
        public int TagId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }
    }
}
