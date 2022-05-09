using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Validators;

namespace Admin.ApiModels.Request
{
    public class SeoRequest : BaseRequest
    {
        public Models.Seo Seo { get; set; }
    }
}
