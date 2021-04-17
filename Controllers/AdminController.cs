using System.Linq;
using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowCarryCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

//    [Authorize(Roles = "Root Admin,Agent,Admin,Price Admin")]
public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;
    private WowCarryContext _context;

    public AdminController(ILogger<AdminController> logger, WowCarryContext context)
    {
        _context = context;
        _logger = logger;
    }
    [Route("Admin")]
    public ViewResult Admin()
    {
        return View();
    }
    public ViewResult List(string type)
    {
        switch (type)
        {
            case "Product":
                return View("List" + type, _context.Products);
            case "TemplateOption":
                return View("List" + type, _context.TemplateOptions);
            case "ProductGame":
                return View("List" + type, _context.ProductGames);
            case "HtmlBlocks":
                return View("List" + type, _context.HtmlBlocks);
            case "SEO":
                return View("List" + type, _context.Seos);
            case "Users":
                return View("List" + type, _context.Users);
            case "Ranks":
                return View("List" + type, _context.Ranks);
            case "Customers":
                return View("List" + type, _context.Customers);
            case "Roles":
                return View("List" + type, _context.Roles);
            case "Orders":
                return View("List" + type, _context.Orders);
            case "Article":
                return View("List" + type, _context.Articles);
            case "ProductCategory":
                return View("List" + type, _context.ProductCategories);
            case "ProductSubCategory":
                return View("List" + type, _context.ProductSubCategories);
            default: return View("Admin");
        }
    }

    //[Authorize(Roles = "Root Admin,Admin,Price Admin")]
    [Route("CreateEdit")]
    public ViewResult CreateEdit(Guid? Id, string type, string game = null)
    {
        switch (type)
        {
            case "Product":
                Product prod = _context.Products.Where(p => p.ProductId == Id).Include(p=>p.ProductGame).FirstOrDefault();
                if (prod != null)
                {
                    ViewBag.GamesList = new SelectList(_context.ProductGames.Select(g => g.GameName), prod?.ProductGame.GameName ?? "Select Game");

                    return View("Save" + type, prod);
                    //GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), prod?.ProductGame.GameName ?? "Select Game"),
                    //CategoriesList = new SelectList(EntityRepository.Games.Where(g => game == null || g.GameName == game).SelectMany(g => g.ProductCategory).Select(p => p.ProductCategoryName), prod?.ProductCategory.ProductCategoryName ?? "Select Category"),
                    //MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), prod?.SEO.MetaTagTitle ?? "Select Meta tag title from List"),
                }
                else
                {
                    return View("Save" + type, prod);
                    {
                        ViewBag.GamesList = new SelectList(_context.ProductGames.Select(g => g.GameName), prod?.ProductGame.GameName ?? "Select Game");
                        ViewBag.CategoriesList = new SelectList(_context.ProductGames.Where(g => game == null || g.GameName == game).SelectMany(g => g.ProductCategories).Select(p => p.ProductCategoryName), "Select Category");
                        ViewBag.MetaTagTitleList = new SelectList(_context.Seos.Select(s => s.MetaTagTitle), "Select Meta tag title from List");
                    };
                }
            case "TemplateOption":
                TemplateOption templateOption = _context.TemplateOptions.Where(p => p.OptionId == Id).FirstOrDefault();
                if (templateOption != null)
                {
                    return View("Save" + type, templateOption);
                }
                else
                {
                    return View("Save" + type, templateOption);

                }
            case "ProductGame":
                ProductGame productGame = _context.ProductGames.Where(p => p.ProductGameId == Id).FirstOrDefault();
                if (productGame != null)
                {
                    return View("Save" + type, productGame);
                }
                else
                {
                    return View("Save" + type, productGame);
                    {
                        ViewBag.MetaTagTitleList = new SelectList(_context.Seos.Select(s => s.MetaTagTitle), "Select Meta tag title from List");
                    };
                }
            case "HtmlBlocks":
                HtmlBlock siteBlock = _context.HtmlBlocks.Where(p => p.SiteBlockId == Id).FirstOrDefault();
                if (siteBlock != null)
                {
                    return View("Save" + type, siteBlock);
                }
                else
                {
                    //TODO Children
                    //var result = new HtmlBlock { SiteBlockId = Guid.NewGuid(), HtmlBlocksChildren = new List<HtmlBlock.HtmlBlocksChildren>() };
                    return View("Save" + type, siteBlock);

                }
            case "SEO":
                Seo seo = _context.Seos.Where(p => p.Seoid == Id).FirstOrDefault();
                if (seo != null)
                {
                    return View("Save" + type, seo);
                }
                else
                {
                    return View("Save" + type, seo);
                }
            case "Users":
                User user = _context.Users.Where(p => p.UserId == Id).FirstOrDefault();
                if (user != null)
                {
                    return View("Save" + type, user);
                }
                else
                {
                    return View("Save" + type, user);
                }
            case "Ranks":
                Rank ranks = _context.Ranks.Where(p => p.RankId == Id).FirstOrDefault();
                if (ranks != null)
                {
                    return View("Save" + type, ranks);
                }
                else
                {
                    return View("Save" + type, ranks);
                }
            case "Customers":
                Customer customers = _context.Customers.Where(p => p.CustomerId == Id).FirstOrDefault();
                if (customers != null)
                {
                    return View("Save" + type, customers);
                }
                else
                {
                    return View("Save" + type, customers);
                }
            case "Roles":
                Role roles = _context.Roles.Where(p => p.RoleId == Id).FirstOrDefault();
                if (roles != null)
                {
                    return View("Save" + type, roles);
                }
                else
                {
                    return View("Save" + type, roles);
                }
            case "Article":
                Article article = _context.Articles.Where(p => p.ArticleId == Id).FirstOrDefault();
                if (article != null)
                {
                    return View("Save" + type, article);
                }
                else
                {

                    return View("Save" + type, article);
                    {
                        ViewBag.MetaTagTitleList = new SelectList(_context.Seos.Select(s => s.MetaTagTitle), "Select Meta tag title from List");
                        ViewBag.GamesList = new SelectList(_context.ProductGames.Select(g => g.GameName), "Select Game");
                    };
                }
            case "Orders":
                Order orders = _context.Orders.Where(p => p.OrderId == Id).FirstOrDefault();
                if (orders != null)
                {
                    return View("Save" + type, orders);
                }
                else
                {
                    return View("Save" + type, orders);
                }
            case "ProductCategory":
                ProductCategory productCategory = _context.ProductCategories.Where(p => p.ProductCategoryId == Id).FirstOrDefault();
                if (productCategory != null)
                {
                    return View("Save" + type, productCategory);
                }
                else
                {
                    return View("Save" + type, productCategory);
                    {
                        ViewBag.MetaTagTitleList = new SelectList(_context.Seos.Select(s => s.MetaTagTitle), "Select Meta tag title from List");
                        ViewBag.GamesList = new SelectList(_context.ProductGames.Select(g => g.GameName), "Select Game");
                    };
                }
            case "ProductSubCategory":
                ProductSubCategory productSubCategory = _context.ProductSubCategories.Where(p => p.ProductSubCategoryId == Id).FirstOrDefault();
                if (productSubCategory != null)
                {
                    return View("Save" + type, productSubCategory);
                }
                else
                {
                    return View("Save" + type, productSubCategory);
                    {
                        ViewBag.MetaTagTitleList = new SelectList(_context.Seos.Select(s => s.MetaTagTitle), "Select Meta tag title from List");
                        ViewBag.CategoryList = new SelectList(_context.ProductCategories.Select(s => s.ProductCategoryName), "Select Product Category from List");
                    };
                }
            default: return View("Admin");
        }
    }
}
//    [Authorize(Roles = "Root Admin,Admin,Price Admin")]
//    public ViewResult ProductOptionsEdit(Guid productId)
//    {
//        var selectedProduct = EntityRepository.Products.Where(p => p.ProductId == productId).FirstOrDefault();
//        var ProductOptions = EntityRepository.ProductOptions.Where(o => o.OptionProductId == productId);
//        List<ProductOptionDetails> Options = new List<ProductOptionDetails>();

//        if (ProductOptions.Any())
//        {
//            foreach (var opt in ProductOptions)
//            {
//                var templateOption = EntityRepository.TemplateOptions.Where(t => t.OptionName == opt.OptionName).FirstOrDefault();
//                var ParentOpt = selectedProduct.ProductOptions.Where(o => o.OptionId == opt.OptionParentId).FirstOrDefault();

//                Options.Add(new ProductOptionDetails
//                {
//                    OptionId = opt.OptionId,
//                    OptionName = opt.OptionName,
//                    OptionType = opt.OptionType,
//                    ParentOptionList = new SelectList(selectedProduct.ProductOptions.Where(o => o.OptionId != opt.OptionId).Select(o => o.OptionName).Distinct().ToList(), opt.OptionParentId.HasValue ? opt.ProductOptionsParent.OptionName : "Empty"),
//                    ParamList = new SelectList(templateOption.TempOptionParams.Select(p => p.ParameterName), "Empty"),
//                    ParamCollection = ProductOptionDetails.PopulateParamCollection(opt, selectedProduct.ProductOptions.Where(o => o.OptionId == opt.OptionParentId).SelectMany(p => p.ProductOptionParams).Select(pr => pr.ParameterName), ParentOpt)
//                });
//            }
//        }

//        ProductOptionsViewModel result = new ProductOptionsViewModel
//        {
//            ProductOptions = Options,
//            TemplateOptionList = new SelectList(EntityRepository.TemplateOptions.Select(o => o.OptionName), "Select Option from templates"),
//            ProductId = productId,
//            ProductName = EntityRepository.Products.Where(p => p.ProductId == productId).FirstOrDefault().ProductName
//        };
//        return View(result);
//    }
//    #region POST
//    [HttpPost]
//    public PartialViewResult AddSiteBlock()
//    {
//        return PartialView("AdminSiteBlockChild", new HtmlBlockDetails.HtmlBlockChildrenDetails { SiteBlockChildsId = Guid.NewGuid() });
//    }
//    [HttpPost]
//    public PartialViewResult AddOption(ProductOptionsViewModel productOptionViewModel, string optionName, Guid prodId)
//    {
//        Product selectedProduct = EntityRepository.Products.Where(p => p.ProductId == prodId).FirstOrDefault();
//        TemplateOptions selectedOption = EntityRepository.TemplateOptions.Where(t => t.OptionName == optionName).FirstOrDefault();

//        ProductOptionDetails option = new ProductOptionDetails
//        {
//            OptionId = Guid.NewGuid(),
//            OptionName = selectedOption.OptionName,
//            OptionType = selectedOption.OptionType,
//            ParentOptionList = new SelectList(selectedProduct.ProductOptions.Select(o => o.OptionName), "Empty"),
//            ParamList = new SelectList(selectedOption.TempOptionParams.Select(p => p.ParameterName), "Empty"),
//        };

//        foreach (var param in selectedOption.TempOptionParams)
//        {
//            ProductOptionDetails.ProductOptionParamsDetails optionParams = new ProductOptionDetails.ProductOptionParamsDetails
//            {
//                ParameterId = Guid.NewGuid(),
//                Paramname = param.ParameterName,
//                ParamTooltip = param.ParameterTooltip,
//                ParamPrice = param.ParameterPrice,
//                Sale = param.ParameterSale,
//                ParamParentList = new SelectList(Enumerable.Empty<SelectListItem>())
//            };
//            if (option.ParamCollection is null)
//            {
//                option.ParamCollection = new List<ProductOptionDetails.ProductOptionParamsDetails>();
//            }
//            option.ParamCollection.Add(optionParams);
//        }

//        return PartialView("~/Views/Shared/EditorTemplates/ProductOptionDetails.cshtml", option);
//    }
//    [HttpPost]
//    public PartialViewResult AddParam(string optionName, string paramName)
//    {
//        TempOptionParams TempOptionParams = EntityRepository.TemplateOptions.Where(po => po.OptionName == optionName)?.Select(p => p.TempOptionParams.Where(par => par.ParameterName == paramName).FirstOrDefault()).FirstOrDefault();

//        ProductOptionDetails.ProductOptionParamsDetails parameter = new ProductOptionDetails.ProductOptionParamsDetails
//        {
//            ParameterId = Guid.NewGuid(),
//            Paramname = TempOptionParams?.ParameterName,
//            ParamTooltip = TempOptionParams?.ParameterTooltip,
//            ParamPrice = TempOptionParams?.ParameterPrice ?? Decimal.Zero,
//            Sale = TempOptionParams?.ParameterSale
//        };
//        return PartialView("~/Views/Shared/EditorTemplates/ProductOptionParamsDetails.cshtml", parameter);
//    }
//    #region Save
//    [HttpPost]
//    [ValidateInput(false)]
//    public ActionResult SaveProductSubCategory(ProductSubCategoryDetails productSubCategoryDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveProductSubCategory(productSubCategoryDetails);
//            TempData["message"] = string.Format("HTML BLock has been saved");
//            return RedirectToAction("List", new { type = "ProductSubCategory" });
//        }
//        else
//        {
//            return View("List", productSubCategoryDetails);
//        }
//    }
//    [ValidateInput(false)]
//    public ActionResult SaveProduct(ProductDetails productDetails, bool navigateToProdOpt = false)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveProduct(productDetails);
//            TempData["message"] = string.Format(productDetails.ProductName + " was saved");
//            if (navigateToProdOpt)
//            {
//                return RedirectToAction("ProductOptionsEdit", new { productId = productDetails.ProductId });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Product" });
//            }
//        }
//        else
//        {
//            return View("SaveProduct", new ProductDetails
//            {
//                Product = productDetails.Product,
//                ProductId = productDetails.ProductId,
//                GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), productDetails.SelectedGame ?? "Select Game"),
//                CategoriesList = new SelectList(EntityRepository.Games.Where(g => productDetails.SelectedGame == null || g.GameName == productDetails.SelectedGame).SelectMany(g => g.ProductCategory).Select(p => p.ProductCategoryName), productDetails.SelectedCategory ?? "Select Category"),
//                MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), productDetails.SelectedMetaTagTitle ?? "Select Meta tag title from List"),
//                ProductOptions = productDetails.ProductOptions,
//                ProductName = productDetails.ProductName,
//                InStock = productDetails.InStock,
//                PreOrder = productDetails.PreOrder,
//                ProductEnabled = productDetails.ProductEnabled,
//                ProductQuantity = productDetails.ProductQuantity,
//                ProductImageThumb = productDetails.ProductImageThumb,
//                ProductImage = productDetails.ProductImage,
//                ProductPriority = productDetails.ProductPriority,
//                ProductPriceEU = productDetails.ProductPriceEU,
//                ProductPriceUS = productDetails.ProductPriceUS,
//                ProductSaleEU = productDetails.ProductSaleEU,
//                ProductSaleUS = productDetails.ProductSaleUS,
//                Description = productDetails.Description,
//                SubDescriptionTitle1 = productDetails.SubDescriptionTitle1,
//                SubDescription1 = productDetails.SubDescription1,
//                SubDescriptionTitle2 = productDetails.SubDescriptionTitle2,
//                SubDescription2 = productDetails.SubDescription2,
//                SubDescriptionTitle3 = productDetails.SubDescriptionTitle3,
//                SubDescription3 = productDetails.SubDescription3,
//                SubDescriptionTitle4 = productDetails.SubDescriptionTitle4,
//                SubDescription4 = productDetails.SubDescription4,
//                SubDescriptionTitle5 = productDetails.SubDescriptionTitle5,
//                SubDescription5 = productDetails.SubDescription5,
//            });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveProductOption(ProductOptionsViewModel productOptionViewModel)
//    {
//        if (ModelState.IsValid)
//        {
//            List<Guid> userOptionIds = new List<Guid>();
//            foreach (var productOptionDetails in productOptionViewModel.ProductOptions)
//            {
//                if (productOptionDetails.OptionParent == "Empty")
//                    productOptionDetails.OptionParent = null;

//                productOptionDetails.OptionProductId = productOptionViewModel.ProductId;
//                EntityRepository.SaveProductOption(productOptionDetails);
//                userOptionIds.Add(productOptionDetails.OptionId);
//            }
//            var dbOptionIds = EntityRepository.ProductOptions.Where(p => p.OptionProductId == productOptionViewModel.ProductId).Select(o => o.OptionId);

//            foreach (var optId in dbOptionIds)
//            {
//                if (!userOptionIds.Contains(optId))
//                {
//                    Remove(optId, "ProductOption");
//                }
//            }

//            try
//            {
//                EntityRepository.SaveContextAsync();
//            }
//            catch (Exception ex)
//            {
//                TempData["message"] = string.Format(ex.Message);
//            }
//            finally
//            {
//                TempData["message"] = string.Format("Options has been saved");
//            }
//            return RedirectToAction("List", new { type = "Product" });

//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Product" });
//        }
//    }
//    [HttpPost]
//    [ValidateInput(false)]
//    public ActionResult SaveHtmlBlock(HtmlBlockDetails htmlBlockDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveHtmlBlock(htmlBlockDetails);
//            TempData["message"] = string.Format("HTML BLock has been saved");
//            return RedirectToAction("List", new { type = "HtmlBlocks" });
//        }
//        else
//        {
//            return View("SaveHtmlBlocks", htmlBlockDetails);
//        }
//    }
//    public ActionResult SaveProductCategory(ProductCategoryDetails productCategoryDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveProductCategory(productCategoryDetails);
//            TempData["message"] = string.Format("Product Category  has been saved");
//            return RedirectToAction("List", new { type = "ProductCategory" });
//        }
//        else
//        {
//            return View("List", productCategoryDetails);
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveTemplateOption(TemplateOptionDetails templateOptionDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveTemplateOption(templateOptionDetails);
//            TempData["message"] = string.Format("Template Option has been saved");
//            return RedirectToAction("List", new { type = "TemplateOptions" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "TemplateOptions" });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveSEO(SeoDetails seoDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveSEO(seoDetails);
//            TempData["message"] = string.Format("Seo has been saved");
//            return RedirectToAction("List", new { type = "SEO" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "SEO" });
//        }
//    }
//    [HttpPost]
//    [ValidateInput(false)]
//    public ActionResult SaveGame(ProductGameDetails productGameDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveGame(productGameDetails);
//            TempData["message"] = string.Format("Product Game Details has been saved");
//            return RedirectToAction("List", new { type = "ProductGame" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "ProductGame" });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveUsers(UsersDetails userDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveUsers(userDetails);
//            TempData["message"] = string.Format("User has been saved");
//            return RedirectToAction("List", new { type = "Users" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Users" });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveRanks(RankDetails rankDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveRanks(rankDetails);
//            TempData["message"] = string.Format("Ranks has been saved");
//            return RedirectToAction("List", new { type = "Ranks" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Ranks" });
//        }
//    }
//    [ValidateInput(false)]
//    public ActionResult SaveArticle(ArticleDetails ArticleDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveArticle(ArticleDetails);
//            TempData["message"] = string.Format("Article has been saved");
//            return RedirectToAction("List", new { type = "Article" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Article" });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveCustomers(CustomersDetails customers)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveCustomers(customers);
//            TempData["message"] = string.Format("Customers has been saved");
//            return RedirectToAction("List", new { type = "Customers" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Customers" });
//        }
//    }
//    [HttpPost]
//    public ActionResult SaveRoles(RolesDetails rolesDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveRoles(rolesDetails);
//            TempData["message"] = string.Format("Roles has been saved");
//            return RedirectToAction("List", new { type = "Roles" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Roles" });
//        }
//    }
//    public ActionResult SaveOrders(OrderDetails orderDetails)
//    {
//        if (ModelState.IsValid)
//        {
//            EntityRepository.SaveOrders(orderDetails);
//            TempData["message"] = string.Format("Orders has been saved");
//            return RedirectToAction("List", new { type = "Orders" });
//        }
//        else
//        {
//            return RedirectToAction("List", new { type = "Orders" });
//        }
//    }
//    #endregion
//    public ActionResult Remove(Guid Id, string type)
//    {
//        switch (type)
//        {
//            case "Product":
//                EntityRepository.RemoveProduct(Id);
//                break;
//            case "TemplateOptions":
//                EntityRepository.RemoveTemplateOption(Id);
//                break;
//            case "ProductGame":
//                EntityRepository.RemoveGame(Id);
//                break;
//            case "HtmlBlocks":
//                EntityRepository.RemoveHtmlBlock(Id);
//                break;
//            case "SEO":
//                EntityRepository.RemoveSEO(Id);
//                break;
//            case "Users":
//                EntityRepository.RemoveUsers(Id);
//                break;
//            case "Ranks":
//                EntityRepository.RemoveRanks(Id);
//                break;
//            case "Customers":
//                EntityRepository.RemoveCustomers(Id);
//                break;
//            case "Roles":
//                EntityRepository.RemoveRoles(Id);
//                break;
//            //case "Orders":
//            //    EntityRepository.RemoveOrders(Id);
//            //    break;
//            case "ProductOption":
//                EntityRepository.RemoveProductOption(Id);
//                break;
//            case "ProductCategory":
//                EntityRepository.RemoveProductCategory(Id);
//                break;
//            case "ProductSubCategory":
//                EntityRepository.RemoveProductSubCategory(Id);
//                break;
//        }
//        return RedirectToAction("List", new { type = type });
//    }
//    [HttpPost]
//    public string Upload()
//    {
//        var file = Request.Files[0];
//        if (file != null)
//        {
//            var path = Request.Form[0];
//            var requiredFileName = Request.Form[1];
//            string extension = Path.GetExtension(file.FileName);
//            string endPath = Server.MapPath(path);


//            if (!Directory.Exists(endPath))
//                Directory.CreateDirectory(endPath);

//            if (System.IO.File.Exists(endPath + requiredFileName + extension))
//                System.IO.File.Delete(endPath + requiredFileName + extension);

//            file.SaveAs(endPath + @"/" + requiredFileName + extension);

//            return path + @"/" + requiredFileName + extension;
//        }
//        return "";
//    }
//    #endregion
//}