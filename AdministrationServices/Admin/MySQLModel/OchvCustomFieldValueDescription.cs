using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomFieldValueDescription
    {
        public int CustomFieldValueId { get; set; }
        public int LanguageId { get; set; }
        public int CustomFieldId { get; set; }
        public string Name { get; set; }
    }
}
