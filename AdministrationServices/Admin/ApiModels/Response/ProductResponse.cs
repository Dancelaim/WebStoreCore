using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Models;

namespace Admin.ApiModels.Response
{
    public class ProductResponse : BaseResponse
    {
        public string ProductName { get; set; }

        public bool? InStock { get; set; }

        public bool PreOrder { get; set; }

        public int? ProductQuantity { get; set; }

        public string ProductImage { get; set; }

        public int? ProductPriority { get; set; }

        public bool ProductEnabled { get; set; }

        public string ProductImageThumb { get; set; }

        public decimal? UsPrice { get; set; }

        public decimal? UsSale { get; set; }

        public decimal? EuPrice { get; set; }

        public decimal? EuSale { get; set; }

        public string GameName { get; set; }

        public string ProductcategoryName { get; set; }

        public string MetaTagTitle { get; set;}

    }
}
