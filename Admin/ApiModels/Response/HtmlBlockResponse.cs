using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Base;

namespace Admin.ApiModels.Response
{
    public class HtmlBlockResponse : BaseResponse
    {
        public List<HtmlBlock> HtmlBlocks { get; set; }
    }
}
