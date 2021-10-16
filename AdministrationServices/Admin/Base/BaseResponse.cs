using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Base
{
    public class BaseResponse
    {
        public DateTime ResponseTime { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
