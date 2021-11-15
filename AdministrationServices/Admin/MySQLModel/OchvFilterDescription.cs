using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvFilterDescription
    {
        public int FilterId { get; set; }
        public int LanguageId { get; set; }
        public int FilterGroupId { get; set; }
        public string Name { get; set; }
    }
}
