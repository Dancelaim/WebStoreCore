using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Response
{
    public class CustomerResponse : BaseResponse
    {
         public List<Customer> Customer { get; set; }
    }
}
