using Admin.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.ApiModels.Request
{
    public class ProductRequest
    {
        [RequiredGreaterThanZero]
        public int _skip;
        [RequiredGreaterThanZero]
        public int quantity;
    }
}
