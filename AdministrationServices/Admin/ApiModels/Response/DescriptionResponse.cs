using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Models;

namespace Admin.ApiModels.Response
{
    public class DescriptionResponse : BaseResponse
    {
        public string Description { get; set; }

        public string SubDescriptionTitle1 { get; set; }

        public string SubDescriptionTitle2 { get; set; }

        public string SubDescriptionTitle3 { get; set; }

        public string SubDescriptionTitle4 { get; set; }

        public string SubDescriptionTitle5 { get; set; }

        public string SubDescription1 { get; set; }

        public string SubDescription2 { get; set; }

        public string SubDescription3 { get; set; }

        public string SubDescription4 { get; set; }

        public string SubDescription5 { get; set; }

    }
}
