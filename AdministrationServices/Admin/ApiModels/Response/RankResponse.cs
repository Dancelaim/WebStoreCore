using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Models;

namespace Admin.ApiModels.Response
{
    public class RankResponse : BaseResponse
    {
        public List<Ranks> Ranks { get; set; }
    }
}
