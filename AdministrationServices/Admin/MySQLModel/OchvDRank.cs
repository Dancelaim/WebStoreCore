using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDRank
    {
        public int CustomerGroupId { get; set; }
        public string RankName { get; set; }
        public int Discount { get; set; }
        public float SumToUp { get; set; }
        public int RankStatus { get; set; }
    }
}
