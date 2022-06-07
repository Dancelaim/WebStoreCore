using Admin.Base;
using Admin.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.ApiModels.Request
{
    public class ProductOptionsRequest : BaseRequest
    {
        public Guid ProductId { get; set; }
    }
}
