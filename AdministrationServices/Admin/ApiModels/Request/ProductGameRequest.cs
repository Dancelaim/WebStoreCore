using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Request
{
    public class ProductGameRequest : BaseRequest
    {
        public Models.ProductGame ProductGame { get; set; } 
    }
}
