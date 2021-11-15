using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductAttribute
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
    }
}
