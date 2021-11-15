using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDqcStatistic
    {
        public int StatisticId { get; set; }
        public int SettingId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Data { get; set; }
        public int Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
