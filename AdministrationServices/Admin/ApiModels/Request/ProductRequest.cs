﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Request
{
    public class ProductRequest : BaseRequest
    {
        public Guid ProductId;
    }
}
