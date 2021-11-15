using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvProductOptionValue
    {
        public int ProductOptionValueId { get; set; }
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public int OptionValueId { get; set; }
        public int Quantity { get; set; }
        public bool Subtract { get; set; }
        public decimal Price { get; set; }
        public string PricePrefix { get; set; }
        public int Points { get; set; }
        public string PointsPrefix { get; set; }
        public decimal Weight { get; set; }
        public string WeightPrefix { get; set; }
        public int IsDefault { get; set; }
        public int NotIncrease { get; set; }
        public int MasterOptionValue { get; set; }
        public int Discount { get; set; }
        public string EstimatedTime { get; set; }
    }
}
