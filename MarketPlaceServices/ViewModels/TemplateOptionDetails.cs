using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using WowCarryCore.Models;

public class TemplateOptionDetails
    {
        [HiddenInput]
        public System.Guid TempOptionId { get; set; }

        [Display(Name = "TempOptionName")]
        public string TempOptionName { get; set; }

        [Display(Name = "TempOptionType")]
        public string TempOptionType { get; set; }

        //[Display(Name = "TempOptionParamParentId")]
        //public Nullable<System.Guid> TempOptionParamParentId { get; set; }

        public List<TempOptionParamsDetails> TempOptionParamsDetailsCollection { get; set; }
        public class TempOptionParamsDetails
        {
            [HiddenInput]
            public System.Guid ParameterId { get; set; }

            [Display(Name = "ParameterName")]
            public string ParameterName { get; set; }

            [Display(Name = "ParameterTooltip")]
            public string ParameterTooltip { get; set; }

            [Display(Name = "ParameterPrice")]
            public decimal ParameterPrice { get; set; }

            [HiddenInput]
            public Nullable<System.Guid> ParentOptionId { get; set; }

            [Display(Name = "ParameterSale")]
            public string ParameterSale { get; set; }
        }
        public static List<TempOptionParamsDetails> PopulateTempOptionParamsDetailsCollection(TemplateOption templateOptions)
        {
            List<TempOptionParamsDetails> result = new List<TempOptionParamsDetails>();
            foreach (var item in templateOptions.TempOptionParams)
            {
                result.Add(new TempOptionParamsDetails
                {
                    ParameterId = item.ParameterId,
                    ParameterName = item.ParameterName,
                    ParameterTooltip = item.ParameterTooltip,
                    ParameterPrice = item.ParameterPrice,
                    ParentOptionId = item.ParentOptionId,
                    ParameterSale = item.ParameterSale
                });
            }
            return result;
        }

    }