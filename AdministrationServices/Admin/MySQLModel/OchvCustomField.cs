using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomField
    {
        public int CustomFieldId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Validation { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
        public int SortOrder { get; set; }
    }
}
