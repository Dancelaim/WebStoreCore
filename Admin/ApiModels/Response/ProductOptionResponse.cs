using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Response
{
    public class ProductOptionResponse : BaseResponse
    {
        public ProductOption ProductOption { get; set; }
    }
}
