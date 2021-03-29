//using System.Linq;
//using System.Web.Mvc;
//using WowCarry.Domain.Entities;
//using WowCarry.Domain.Abstract;
//using WebUI.Models;
//using System;
//using System.Collections.Generic;

//namespace WowCarry.WebUI.Controllers
//{
//    public  class OptionsController : Controller
//    {

//        IEntityRepository EntityRepository;
//        public OptionsController(IEntityRepository EntityRep)
//        {
//            EntityRepository = EntityRep;
//        }
//        public PartialViewResult Options(Guid ProductId)
//        {
//            IEnumerable<ProductOptions> Options = EntityRepository.ProductOptions.Where(o => o.OptionProductId == ProductId);
//            return PartialView(Options);
//        }


//    }
//}