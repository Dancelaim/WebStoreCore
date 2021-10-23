using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Base;   

namespace Admin.ApiModels.Response
{
    public class TemplateOptionsResponse : BaseResponse
    {
        public List<TemplateOption> templateOptions { get; set; }
    }
}
