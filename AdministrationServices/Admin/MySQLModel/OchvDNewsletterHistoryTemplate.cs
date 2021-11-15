using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterHistoryTemplate
    {
        public int TemplateId { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string CampaignName { get; set; }
        public int? LimitSpecial { get; set; }
        public int? LimitBestseller { get; set; }
        public int? LimitLatest { get; set; }
        public int? LimitMissing { get; set; }
        public int? LimitCategory { get; set; }
        public int? LimitRelated { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime DateSend { get; set; }
        public int? Status { get; set; }
    }
}
