using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Request
{
    public class ProductCategoryRequest : BaseRequest
    {
        public Guid? ProductGameId { get; set; }
    }
}
