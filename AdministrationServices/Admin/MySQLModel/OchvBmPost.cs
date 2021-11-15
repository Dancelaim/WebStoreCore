using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmPost
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Image { get; set; }
        public string ImageTitle { get; set; }
        public string ImageAlt { get; set; }
        public int? ReviewDisplay { get; set; }
        public int? ImagesReview { get; set; }
        public int? Viewed { get; set; }
        public int? Status { get; set; }
        public int LimitAccessUser { get; set; }
        public string LimitUsers { get; set; }
        public int LimitAccessUserGroup { get; set; }
        public string LimitUserGroups { get; set; }
        public int? Custom { get; set; }
        public string Setting { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateModified { get; set; }
    }
}
