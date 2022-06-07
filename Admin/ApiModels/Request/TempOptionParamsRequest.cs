using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Base;
using Admin.Validators;

namespace Admin.ApiModels.Request
{
    public class TempOptionParamsRequest : BaseRequest 
    {
        [IsPositiveValueOrZero(ErrorMessage = "Skip can't be less than 0")]
        public int Skip { get; set; }

        [RequiredGreaterThanZero(ErrorMessage = "Quantity is required and should be more than 0")]
        public int Quantity { get; set; }
    }
}
