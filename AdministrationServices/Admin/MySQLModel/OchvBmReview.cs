using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmReview
    {
        public int ReviewId { get; set; }
        public int PostId { get; set; }
        public int ReplyToReviewId { get; set; }
        public int LanguageId { get; set; }
        public int CustomerId { get; set; }
        public string GuestEmail { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int? Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
