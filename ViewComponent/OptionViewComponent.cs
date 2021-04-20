﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WowCarryCore.Models;

namespace WowCarryCore
{
    public class OptionViewComponent : ViewComponent
    {
        private readonly ILogger<OptionViewComponent> _logger;
        private WowCarryContext _context;
        public OptionViewComponent(ILogger<OptionViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid OptionId, Guid? ParamParentId = null)
        {
            //TO DO: Should be fixed later to look it more appropriate
            ProductOption Option = await _context.ProductOptions.Where(a => a.OptionId == OptionId)
               .Include(o => o.ProductOptionParams).FirstOrDefaultAsync();

            if (ParamParentId != null)
            {
                Option.ProductOptionParams.Clear();
                Option.ProductOptionParams = _context.ProductOptionParams.Where(p => p.ParameterParentId == ParamParentId).ToList();
            }

            ViewBag.ChildOptionId = await _context.ProductOptions.Where(a => a.OptionParentId == OptionId).Select(o => o.OptionId).FirstOrDefaultAsync();

            return Option switch
            {
                { OptionType: (int)OptionType.CheckBox } => View(OptionType.CheckBox.ToString(), Option),
                { OptionType: (int)OptionType.RadioButton } => View(OptionType.RadioButton.ToString(), Option),
                { OptionType: (int)OptionType.TextArea } => View(OptionType.TextArea.ToString(), Option),
                { OptionType: (int)OptionType.DropDownList } => View(OptionType.DropDownList.ToString(), Option),
                { OptionType: (int)OptionType.Slider } => View(OptionType.Slider.ToString(), Option),
                { OptionType: (int)OptionType.TwoSideSlider } => View(OptionType.TwoSideSlider.ToString(), Option),
                _ => View(Option),
            };
        }
    }
}

