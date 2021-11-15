using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAttribute
    {
        public int AttributeId { get; set; }
        public int AttributeGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
