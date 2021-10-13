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
        [Required(ErrorMessage = "Данное поля обязательно для заполнения")]
        [JsonPropertyName("Skip")] public int Skip { get; set; }
        [RequiredGreaterThanZero(ErrorMessage = "Quantity не может быть '0' или меньше")]
        [JsonPropertyName("Quantity")] public int Quantity { get; set; }
    }
}
