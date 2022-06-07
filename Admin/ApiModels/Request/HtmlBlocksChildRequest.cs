using Admin.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;

namespace Admin.ApiModels.Request
{
    public class HtmlBlocksChildRequest : BaseRequest
    {
        [IsPositiveValueOrZero(ErrorMessage = "Skip can't be less than 0")]
        public int Skip { get; set; }

        [RequiredGreaterThanZero(ErrorMessage = "Quantity is required and should be more than 0")]
        public int Quantity { get; set; }
    }
}
