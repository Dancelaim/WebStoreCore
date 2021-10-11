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
            int i;
            return value != null && int.TryParse(value.ToString(), out i) && i >= 0;
        }
    }
}
