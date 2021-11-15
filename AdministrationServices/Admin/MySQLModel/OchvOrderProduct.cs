using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrderProduct
    {
        public int OrderProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal Reward { get; set; }
        public int SelectLevel { get; set; }
        public string RaidTypeFaction { get; set; }
        public string RaidDateTime { get; set; }
        public string RaidDateTimeUser { get; set; }
    }
}
