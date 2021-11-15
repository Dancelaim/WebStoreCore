using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmAuthorGroup
    {
        public int AuthorGroupId { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }
    }
}
