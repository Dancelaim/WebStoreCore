using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Response
{
    public class ProductOptionsResponse :BaseResponse
    {
        public List<ProductOption> productOptions { get; set; }
    }
}
