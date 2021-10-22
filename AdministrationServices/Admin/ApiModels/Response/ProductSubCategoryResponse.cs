using Admin.Base;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.ApiModels.Response
{
    public class ProductSubCategoryResponse : BaseResponse
    {
        public List<ProductSubCategory> productSubCategories { get; set; }
    }
}
