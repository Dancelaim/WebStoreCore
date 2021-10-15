using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Validators
{
    public class RequiredGreaterThanZero : ValidationAttribute 
    {
        public override bool IsValid(object value)
        { 
            return value != null && int.TryParse(value.ToString(), out int  i) && i > 0;
        }
    }

    public class IsPositiveValueOrZero : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return int.TryParse(value.ToString(), out int i) && i >= 0;
        }

    }
}
