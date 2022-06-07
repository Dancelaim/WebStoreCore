using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Models;

namespace Admin.ApiModels.Request
{
    public class ProductRequest : BaseRequest
    {
        public Product Product { get; set; }
        public ProductDescription    Description { get; set; }
        public ProductPrice Price { get; set; }
    }
}
