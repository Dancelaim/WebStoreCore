using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvRaidTime
    {
        public int ProductId { get; set; }
        public string Scheduler { get; set; }
        public string Timezone { get; set; }
        public string Faction { get; set; }
    }
}
