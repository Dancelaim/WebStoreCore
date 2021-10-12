using Admin.Base;
using Admin.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin.ApiModels.Request
{
    public class ProductsRequest : BaseRequest
    {
        [RequiredGreaterThanZero]
        [JsonPropertyName("skip")] public int Skip;
        [RequiredGreaterThanZero]
        [JsonPropertyName("quantity")] public int Quantity;
    }
}
