using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfValue
    {
        public int AfValueId { get; set; }
        public string Type { get; set; }
        public int GroupId { get; set; }
        public int Value { get; set; }
    }
}
