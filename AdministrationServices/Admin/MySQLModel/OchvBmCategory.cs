using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmCategory
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }
        public int SortOrder { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }
        public int LimitAccessUser { get; set; }
        public string LimitUsers { get; set; }
        public int LimitAccessUserGroup { get; set; }
        public string LimitUserGroups { get; set; }
        public int? Custom { get; set; }
        public string Setting { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
