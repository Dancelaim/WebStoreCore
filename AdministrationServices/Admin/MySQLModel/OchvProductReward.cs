using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductReward
    {
        public int ProductRewardId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Points { get; set; }
    }
}
