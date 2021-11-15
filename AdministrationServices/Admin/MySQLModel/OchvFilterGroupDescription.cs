using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvFilterGroupDescription
    {
        public int FilterGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
