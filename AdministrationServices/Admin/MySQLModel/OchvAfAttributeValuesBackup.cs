using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfAttributeValuesBackup
    {
        public int AttributeValueId { get; set; }
        public int AttributeId { get; set; }
        public int LanguageId { get; set; }
        public int SortOrder { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
}
