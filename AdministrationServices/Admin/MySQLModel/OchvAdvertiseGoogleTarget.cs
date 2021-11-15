using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAdvertiseGoogleTarget
    {
        public int AdvertiseGoogleTargetId { get; set; }
        public int StoreId { get; set; }
        public string CampaignName { get; set; }
        public string Country { get; set; }
        public decimal Budget { get; set; }
        public string Feeds { get; set; }
        public string Status { get; set; }
    }
}
