using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmAuthor
    {
        public int AuthorId { get; set; }
        public int UserId { get; set; }
        public int AuthorGroupId { get; set; }
        public int? Custom { get; set; }
        public string Setting { get; set; }
    }
}
