using Microsoft.AspNetCore.Http;
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
            OptionViewModel Options = new OptionViewModel()
            {
                ParentOption = await _context.ProductOptions.Where(a => a.OptionId == OptionId && a.ProductOptionParams.Any(p => p.ParameterParentId == ParamParentId)).Include(o => o.ProductOptionParams).FirstOrDefaultAsync(),
                ChildOption = await _context.ProductOptions.Where(a => a.OptionParentId == OptionId).Include(o => o.ProductOptionParams).FirstOrDefaultAsync()
            };

            var switchResult = Options.ParentOption != null ? Options.ParentOption.OptionType : Options.ChildOption.OptionType;

            return switchResult  switch
            {
                (int)OptionType.CheckBox  => View(OptionType.CheckBox.ToString(), Options),
                (int)OptionType.RadioButton  => View(OptionType.RadioButton.ToString(), Options),
                (int)OptionType.TextArea  => View(OptionType.TextArea.ToString(), Options),
                (int)OptionType.DropDownList  => View(OptionType.DropDownList.ToString(), Options),
                (int)OptionType.Slider  => View(OptionType.Slider.ToString(), Options),
                (int)OptionType.TwoSideSlider  => View(OptionType.TwoSideSlider.ToString(), Options),
                _ => View(Options),
            };
        }
    }
}

