using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomFieldValue
    {
        public int CustomFieldValueId { get; set; }
        public int CustomFieldId { get; set; }
        public int SortOrder { get; set; }
    }
}
