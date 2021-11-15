using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterTemplate
    {
        public int TemplateId { get; set; }
        public int? SortOrder { get; set; }
        public int? LimitSpecial { get; set; }
        public int? LimitBestseller { get; set; }
        public int? LimitLatest { get; set; }
        public int? LimitMissing { get; set; }
        public int? LimitCategory { get; set; }
        public int? LimitRelated { get; set; }
        public string CurrencyCode { get; set; }
    }
}
