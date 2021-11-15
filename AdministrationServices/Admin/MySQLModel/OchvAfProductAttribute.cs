using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? AttributeId { get; set; }
        public int? AttributeValueId { get; set; }
    }
}
