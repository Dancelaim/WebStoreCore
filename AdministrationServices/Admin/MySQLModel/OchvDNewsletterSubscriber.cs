using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterSubscriber
    {
        public int SubscriberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Subscribed { get; set; }
        public int? LanguageId { get; set; }
        public int? StoreId { get; set; }
    }
}
