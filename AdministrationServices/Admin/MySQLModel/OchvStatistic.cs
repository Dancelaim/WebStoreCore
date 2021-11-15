using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvStatistic
    {
        public int StatisticsId { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
    }
}
