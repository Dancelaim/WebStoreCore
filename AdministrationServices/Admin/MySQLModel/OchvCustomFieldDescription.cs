using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomFieldDescription
    {
        public int CustomFieldId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
