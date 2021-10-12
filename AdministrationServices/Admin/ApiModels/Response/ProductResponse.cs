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
        public string ProductName;

        public bool? InStock;

        public bool PreOrder;

        public int? ProductQuantity;

        public string ProductImage;

        public int? ProductPriority;

        public bool ProductEnabled;

        public string ProductImageThumb;

        public decimal? UsPrice;

        public decimal? UsSale;

        public decimal? EuPrice;

        public decimal? EuSale;

    }
}
