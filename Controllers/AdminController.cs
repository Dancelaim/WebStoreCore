//using System.Linq;
//using System.Web.Mvc;
//using WowCarry.Domain.Entities;
//using WowCarry.Domain.Abstract;
//using WebUI.Models;
//using System;
//using System.Collections.Generic;
//using System.Web;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace WowCarry.WebUI.Controllers
//{
//    [Authorize(Roles = "Root Admin,Agent,Admin,Price Admin")]
//    public class AdminController : Controller
//    {
//        IEntityRepository EntityRepository;
//        public AdminController(IEntityRepository entityRepo)
//        {
//            EntityRepository = entityRepo;
//        }
//        public ViewResult Admin()
//        {
//            return View();
//        }
//        public ViewResult List(string type)
//        {
//            switch (type)
//            {
//                case "Product":
//                    return View("List" + type, EntityRepository.Products);
//                case "TemplateOption":
//                    return View("List" + type, EntityRepository.TemplateOptions);
//                case "ProductGame":
//                    return View("List" + type, EntityRepository.Games);
//                case "HtmlBlocks":
//                    return View("List" + type, EntityRepository.HtmlBlocks);
//                case "SEO":
//                    return View("List" + type, EntityRepository.SEOs);
//                case "Users":
//                    return View("List" + type, EntityRepository.Users);
//                case "Ranks":
//                    return View("List" + type, EntityRepository.Ranks);
//                case "Customers":
//                    return View("List" + type, EntityRepository.Customers);
//                case "Roles":
//                    return View("List" + type, EntityRepository.Roles);
//                case "Orders":
//                    return View("List" + type, EntityRepository.Orders);
//                case "Article":
//                    return View("List" + type, EntityRepository.Articles);
//                case "ProductCategory":
//                    return View("List" + type, EntityRepository.ProductCategory);
//                case "ProductSubCategory":
//                    return View("List" + type, EntityRepository.ProductSubCategories);
//                default: return View("Admin");
//            }
//        }

//        [Authorize(Roles = "Root Admin,Admin,Price Admin")]
//        public ViewResult CreateEdit(Guid? Id, string type, string game = null)
//        {
//            switch (type)
//            {
//                case "Product":
//                    Product prod = EntityRepository.Products.Where(p => p.ProductId == Id).FirstOrDefault();
//                    if (prod != null)
//                    {
//                        return View("Save" + type, new ProductDetails
//                        {
//                            Product = prod,
//                            ProductId = prod.ProductId,
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), prod?.ProductGame.GameName ?? "Select Game"),
//                            SelectedGame = prod?.ProductGame.GameName,
//                            CategoriesList = new SelectList(EntityRepository.Games.Where(g => game == null || g.GameName == game).SelectMany(g => g.ProductCategory).Select(p => p.ProductCategoryName), prod?.ProductCategory.ProductCategoryName ?? "Select Category"),
//                            SelectedCategory = prod?.ProductCategory.ProductCategoryName,
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), prod?.SEO.MetaTagTitle ?? "Select Meta tag title from List"),
//                            SelectedMetaTagTitle = prod?.SEO.MetaTagTitle,
//                            ProductOptions = prod.ProductOptions,
//                            ProductName = prod.ProductName,
//                            InStock = prod.InStock,
//                            PreOrder = prod.PreOrder,
//                            ProductEnabled = prod.ProductEnabled,
//                            ProductQuantity = prod.ProductQuantity,
//                            ProductImageThumb = prod.ProductImageThumb,
//                            ProductImage = prod.ProductImage,
//                            ProductPriority = prod.ProductPriority,
//                            ProductPriceEU = prod.ProductPrice.Where(p => p.Region == "Europe").Select(p => p.Price).FirstOrDefault(),
//                            ProductPriceUS = prod.ProductPrice.Where(p => p.Region == "US&Oceania").Select(p => p.Price).FirstOrDefault(),
//                            ProductSaleEU = prod.ProductPrice.Where(p => p.Region == "Europe").Select(p => p.ProductSale).FirstOrDefault(),
//                            ProductSaleUS = prod.ProductPrice.Where(p => p.Region == "US&Oceania").Select(p => p.ProductSale).FirstOrDefault(),
//                            Description = prod.ProductDescription.Description,
//                            SubDescriptionTitle1 = prod.ProductDescription.SubDescriptionTitle1,
//                            SubDescription1 = prod.ProductDescription.SubDescription1,
//                            SubDescriptionTitle2 = prod.ProductDescription.SubDescriptionTitle2,
//                            SubDescription2 = prod.ProductDescription.SubDescription2,
//                            SubDescriptionTitle3 = prod.ProductDescription.SubDescriptionTitle3,
//                            SubDescription3 = prod.ProductDescription.SubDescription3,
//                            SubDescriptionTitle4 = prod.ProductDescription.SubDescriptionTitle4,
//                            SubDescription4 = prod.ProductDescription.SubDescription4,
//                            SubDescriptionTitle5 = prod.ProductDescription.SubDescriptionTitle5,
//                            SubDescription5 = prod.ProductDescription.SubDescription5,
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new ProductDetails
//                        {
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), "Select Game"),
//                            CategoriesList = new SelectList(EntityRepository.Games.Where(g => game == null || g.GameName == game).SelectMany(g => g.ProductCategory).Select(p => p.ProductCategoryName), "Select Category"),
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), "Select Meta tag title from List"),
//                        });
//                    }
//                case "TemplateOptions":
//                    TemplateOptions templateOptions = EntityRepository.TemplateOptions.Where(p => p.OptionId == Id).FirstOrDefault();
//                    if (templateOptions != null)
//                    {
//                        return View("Save" + type, new TemplateOptionDetails
//                        {
//                            TempOptionId = templateOptions.OptionId,
//                            TempOptionName = templateOptions.OptionName,
//                            TempOptionType = templateOptions.OptionType,
//                            TempOptionParamsDetailsCollection = TemplateOptionDetails.PopulateTempOptionParamsDetailsCollection(templateOptions)
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new TemplateOptionDetails { });

//                    }
//                case "ProductGame":
//                    ProductGame productGame = EntityRepository.Games.Where(p => p.ProductGameId == Id).FirstOrDefault();
//                    if (productGame != null)
//                    {
//                        return View("Save" + type, new ProductGameDetails
//                        {
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), productGame.SEO?.MetaTagTitle ?? "Select Meta tag title from List"),
//                            ProductGameId = productGame.ProductGameId,
//                            GameName = productGame.GameName,
//                            GameDescription = productGame.GameDescription,
//                            GameShortUrl = productGame.GameShortUrl,
//                            GameSeoId = productGame.GameSeoId
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new ProductGameDetails 
//                        {
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), "Select Meta tag title from List"),
//                        });
//                    }
//                case "HtmlBlocks":
//                    HtmlBlocks siteBlock = EntityRepository.HtmlBlocks.Where(p => p.SiteBlockId == Id).FirstOrDefault();
//                    if (siteBlock != null)
//                    {
//                        return View("Save" + type, new HtmlBlockDetails
//                        {
//                            SiteBlockId = siteBlock.SiteBlockId,
//                            ParentTitle = siteBlock.ParentTitle,
//                            ParentCSSClass = siteBlock.ParentCSSClass,
//                            ChildCSSClass = siteBlock.ChildCSSClass,
//                            SitePage = siteBlock.SitePage,
//                            Order = siteBlock.Order,
//                            HtmlBlockChildDetailsCollection = HtmlBlockDetails.PopulateHtmlBlockCollection(siteBlock)

//                        });
//                    }
//                    else
//                    {
//                        var result = new HtmlBlockDetails { SiteBlockId = Guid.NewGuid(), HtmlBlockChildDetailsCollection = new List<HtmlBlockDetails.HtmlBlockChildrenDetails>() };
//                        return View("Save" + type, result);

//                    }
//                case "SEO":
//                    SEO seo = EntityRepository.SEOs.Where(p => p.SEOId == Id).FirstOrDefault();
//                    if (seo != null)
//                    {
//                        return View("Save" + type, new SeoDetails
//                        {
//                            SEOId = seo.SEOId,
//                            MetaTagTitle = seo.MetaTagTitle,
//                            MetaTagDescription = seo.MetaTagDescription,
//                            MetaTagKeyWords = seo.MetaTagKeyWords,
//                            SEOTags = seo.SEOTags,
//                            CustomTitle1 = seo.CustomTitle1,
//                            CustomTitle2 = seo.CustomTitle2,
//                            CustomImageTitle = seo.CustomImageTitle,
//                            CustomImageAlt = seo.CustomImageAlt,
//                            MetaRobots = seo.MetaRobots,
//                            UrlKeyWord = seo.UrlKeyWord,
//                            SEOImage = seo.SEOImage
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new SeoDetails { });

//                    }
//                case "Users":
//                    Users user = EntityRepository.Users.Where(p => p.UserId == Id).FirstOrDefault();
//                    if (user != null)
//                    {
//                        return View("Save" + type, new UsersDetails
//                        {
//                            UserId = user.UserId,
//                            UserName = user.UserName,
//                            UserPassword = user.UserPassword,
//                            Email = user.Email,
//                            RoleId = user.RoleId
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new UsersDetails { });

//                    }
//                case "Ranks":
//                    Ranks ranks = EntityRepository.Ranks.Where(p => p.RankId == Id).FirstOrDefault();
//                    if (ranks != null)
//                    {
//                        return View("Save" + type, new RankDetails
//                        {
//                            RankId = ranks.RankId,
//                            Name = ranks.Name,
//                            Sale = ranks.Sale
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new RankDetails { });

//                    }
//                case "Customers":
//                    Customers customers = EntityRepository.Customers.Where(p => p.CustomerId == Id).FirstOrDefault();
//                    if (customers != null)
//                    {
//                        return View("Save" + type, new CustomersDetails
//                        {
//                            CustomerId = customers.CustomerId,
//                            Name = customers.Name,
//                            Password = customers.Password,
//                            Email = customers.Email,
//                            CarryCoinsValue = customers.CarryCoinsValue

//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new CustomersDetails { });

//                    }
//                case "Roles":
//                    Roles roles = EntityRepository.Roles.Where(p => p.RoleId == Id).FirstOrDefault();
//                    if (roles != null)
//                    {
//                        return View("Save" + type, new RolesDetails
//                        {
//                            RoleId = roles.RoleId,
//                            RoleName = roles.RoleName

//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new RolesDetails { });

//                    }
//                case "Article":
//                    Article article = EntityRepository.Articles.Where(p => p.ArticleId == Id).FirstOrDefault();
//                    if (article != null)
//                    {
//                        return View("Save" + type, new ArticleDetails
//                        {
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), article.SEO?.MetaTagTitle ?? "Select Meta tag title from List"),
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), article?.ProductGame.GameName ?? "Select Game"),
//                            ArticleId = article.ArticleId,
//                            Title = article.Title,
//                            ShortDescription = article.ShortDescription,
//                            Description = article.Description,
//                            ReadTime = article.ReadTime,
//                            Tags = article.Tags,
//                            ImagePath = article.ImagePath,
//                            Enabled = article.Enabled,
//                            Rating = article.Rating,
//                            ArticleCreateTime = article.ArticleCreateTime,
//                            ArticleUpdateTime = article.ArticleUpdateTime,
//                            ArticlePostTime = article.ArticlePostTime
//                        });
//                    }
//                    else {
                       
//                        return View("Save" + type, new ArticleDetails 
//                        {
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), "Select Meta tag title from List"),
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName),  "Select Game")
//                        });
//                    }
//                case "Orders":
//                    Orders orders = EntityRepository.Orders.Where(p => p.OrderId == Id).FirstOrDefault();
//                    if (orders != null)
//                    {
//                        return View("Save" + type, new OrderDetails
//                        {
//                            OrderId = orders.OrderId,
//                            Discord = orders.Discord,
//                            Comments = orders.Comment,
//                            Email = orders.Email,
//                            PaymentMethod = orders.PaymentMethod,
//                            PaymentCode = orders.PaymentCode,
//                            Total = orders.Total,
//                            OrderStatus = orders.OrderStatus,
//                            Currency = orders.Currency,
//                            CustomerIP = orders.CustomerIP,
//                            UserAgent = orders.UserAgent,
//                            OrderCreateTime = orders.OrderCreateTime,
//                            OrderUpdateTime = orders.OrderUpdateTime,
//                            EmailSended = orders.EmailSended,
//                            EmailSendTime = orders.EmailSendTime,
//                            CarryCoinsSpent = orders.CarryCoinsSpent,
//                            CarryCoinsCollected = orders.CarryCoinsCollected,
//                            ShlCharacterName = orders.OrderCustomFields.ShlCharacterName,
//                            ShlRealmName = orders.OrderCustomFields.ShlRealmName,
//                            ShlFaction = orders.OrderCustomFields.ShlFaction,
//                            ShlRegion = orders.OrderCustomFields.ShlRegion,
//                            ShlBattleTag = orders.OrderCustomFields.ShlBattleTag,
//                            Poe_CharacterName = orders.OrderCustomFields.PoeCharacterName,
//                            Poe_AccountName = orders.OrderCustomFields.PoeAccountName,
//                            Classic_CharacterName = orders.OrderCustomFields.ClassicCharacterName,
//                            Classic_RealmName = orders.OrderCustomFields.ClassicRealmName,
//                            Classic_Faction = orders.OrderCustomFields.ClassicFaction,
//                            Classic_Region = orders.OrderCustomFields.ClassicRegion,
//                            Classic_BattleTag = orders.OrderCustomFields.ClassicBattleTag
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new OrderDetails { });
//                    }
//                case "ProductCategory":
//                    ProductCategory productCategory = EntityRepository.ProductCategory.Where(p => p.ProductCategoryId == Id).FirstOrDefault();
//                    if(productCategory != null)
//                    {
//                        return View("Save" + type, new ProductCategoryDetails
//                        {
//                            ProductCategoryId = productCategory.ProductCategoryId,
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), productCategory.SEO?.MetaTagTitle ?? "Select Meta tag title from List"),
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), productCategory?.ProductGame.GameName ?? "Select Game"),
//                            ProductCategoryName = productCategory.ProductCategoryName,
//                            CategoryDescription = productCategory.CategoryDescription
//                        });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new ProductCategoryDetails {

//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), "Select Meta tag title from List"),
//                            GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), "Select Game")
//                        });
//                    }
//                case "ProductSubCategory":
//                    ProductSubCategory productSubCategory = EntityRepository.ProductSubCategories.Where(p => p.ProductSubCategoryId  == Id).FirstOrDefault();
//                    if (productSubCategory != null)
//                    {
//                        return View("Save" + type, new ProductSubCategoryDetails
//                        {
//                            ProductSubCategoryId = productSubCategory.ProductSubCategoryId,
//                            ProductCategoryName = productSubCategory.ProductCategoryName,
//                            CategoryDescription = productSubCategory.CategoryDescription,
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), productSubCategory.SEO?.MetaTagTitle ?? "Select Meta tag title from List"),
//                            CategoryList = new SelectList(EntityRepository.ProductCategory.Select(s => s.ProductCategoryName), productSubCategory.ProductCategory?.ProductCategoryName ?? "Select Product Category from List")
//                    });
//                    }
//                    else
//                    {
//                        return View("Save" + type, new ProductSubCategoryDetails
//                        {
//                            MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), "Select Meta tag title from List"),
//                            CategoryList = new SelectList(EntityRepository.ProductCategory.Select(s => s.ProductCategoryName),  "Select Product Category from List")
//                        });
//                    }
//                default: return View("Admin");
//            }
//        }
//        [Authorize(Roles = "Root Admin,Admin,Price Admin")]
//        public ViewResult ProductOptionsEdit(Guid productId)
//        {
//            var selectedProduct = EntityRepository.Products.Where(p => p.ProductId == productId).FirstOrDefault();
//            var ProductOptions = EntityRepository.ProductOptions.Where(o => o.OptionProductId == productId);
//            List<ProductOptionDetails> Options = new List<ProductOptionDetails>();

//            if (ProductOptions.Any())
//            {
//                foreach (var opt in ProductOptions)
//                {
//                    var templateOption = EntityRepository.TemplateOptions.Where(t => t.OptionName == opt.OptionName).FirstOrDefault();
//                    var ParentOpt = selectedProduct.ProductOptions.Where(o => o.OptionId == opt.OptionParentId).FirstOrDefault();

//                    Options.Add(new ProductOptionDetails
//                    {
//                        OptionId = opt.OptionId,
//                        OptionName = opt.OptionName,
//                        OptionType = opt.OptionType,
//                        ParentOptionList = new SelectList(selectedProduct.ProductOptions.Where(o => o.OptionId != opt.OptionId).Select(o => o.OptionName).Distinct().ToList(), opt.OptionParentId.HasValue ? opt.ProductOptionsParent.OptionName : "Empty"),
//                        ParamList = new SelectList(templateOption.TempOptionParams.Select(p => p.ParameterName), "Empty"),
//                        ParamCollection = ProductOptionDetails.PopulateParamCollection(opt, selectedProduct.ProductOptions.Where(o => o.OptionId == opt.OptionParentId).SelectMany(p => p.ProductOptionParams).Select(pr => pr.ParameterName), ParentOpt)
//                    });
//                }
//            }

//            ProductOptionsViewModel result = new ProductOptionsViewModel
//            {
//                ProductOptions = Options,
//                TemplateOptionList = new SelectList(EntityRepository.TemplateOptions.Select(o => o.OptionName), "Select Option from templates"),
//                ProductId = productId,
//                ProductName = EntityRepository.Products.Where(p => p.ProductId == productId).FirstOrDefault().ProductName
//            };
//            return View(result);
//        }
//        #region POST
//        [HttpPost]
//        public PartialViewResult AddSiteBlock()
//        {
//            return PartialView("AdminSiteBlockChild", new HtmlBlockDetails.HtmlBlockChildrenDetails { SiteBlockChildsId = Guid.NewGuid() });
//        }
//        [HttpPost]
//        public PartialViewResult AddOption(ProductOptionsViewModel productOptionViewModel,string optionName, Guid prodId)
//        {
//            Product selectedProduct = EntityRepository.Products.Where(p => p.ProductId == prodId).FirstOrDefault();
//            TemplateOptions selectedOption = EntityRepository.TemplateOptions.Where(t => t.OptionName == optionName).FirstOrDefault();

//            ProductOptionDetails option = new ProductOptionDetails
//            {
//                OptionId = Guid.NewGuid(),
//                OptionName = selectedOption.OptionName,
//                OptionType = selectedOption.OptionType,
//                ParentOptionList  = new SelectList(selectedProduct.ProductOptions.Select(o => o.OptionName), "Empty"),
//                ParamList = new SelectList(selectedOption.TempOptionParams.Select(p => p.ParameterName), "Empty"),
//            };

//            foreach (var param in selectedOption.TempOptionParams)
//            {
//                ProductOptionDetails.ProductOptionParamsDetails optionParams = new ProductOptionDetails.ProductOptionParamsDetails
//                {
//                    ParameterId = Guid.NewGuid(),
//                    Paramname = param.ParameterName,
//                    ParamTooltip = param.ParameterTooltip,
//                    ParamPrice = param.ParameterPrice,
//                    Sale = param.ParameterSale,
//                    ParamParentList = new SelectList(Enumerable.Empty<SelectListItem>())
//                };
//                if (option.ParamCollection is null)
//                {
//                    option.ParamCollection = new List<ProductOptionDetails.ProductOptionParamsDetails>();
//                }
//                option.ParamCollection.Add(optionParams);
//            }

//            return PartialView("~/Views/Shared/EditorTemplates/ProductOptionDetails.cshtml", option);
//        }
//        [HttpPost]
//        public PartialViewResult AddParam(string optionName, string paramName)
//        {
//            TempOptionParams TempOptionParams = EntityRepository.TemplateOptions.Where(po => po.OptionName == optionName)?.Select(p => p.TempOptionParams.Where(par => par.ParameterName == paramName).FirstOrDefault()).FirstOrDefault();

//            ProductOptionDetails.ProductOptionParamsDetails parameter = new ProductOptionDetails.ProductOptionParamsDetails
//            {
//                ParameterId = Guid.NewGuid(),
//                Paramname = TempOptionParams?.ParameterName,
//                ParamTooltip = TempOptionParams?.ParameterTooltip,
//                ParamPrice = TempOptionParams?.ParameterPrice ?? Decimal.Zero,
//                Sale = TempOptionParams?.ParameterSale
//            };
//            return PartialView("~/Views/Shared/EditorTemplates/ProductOptionParamsDetails.cshtml", parameter);
//        }
//        #region Save
//        [HttpPost]
//        [ValidateInput(false)]
//        public ActionResult SaveProductSubCategory(ProductSubCategoryDetails productSubCategoryDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveProductSubCategory(productSubCategoryDetails);
//                TempData["message"] = string.Format("HTML BLock has been saved");
//                return RedirectToAction("List", new { type = "ProductSubCategory" });
//            }
//            else
//            {
//                return View("List", productSubCategoryDetails);
//            }
//        }
//        [ValidateInput(false)]
//        public ActionResult SaveProduct(ProductDetails productDetails, bool navigateToProdOpt = false)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveProduct(productDetails);
//                TempData["message"] = string.Format(productDetails.ProductName + " was saved");
//                if (navigateToProdOpt)
//                {
//                    return RedirectToAction("ProductOptionsEdit", new { productId = productDetails.ProductId });
//                }
//                else
//                {
//                    return RedirectToAction("List", new { type = "Product" });
//                }
//            }
//            else
//            {
//                return View("SaveProduct", new ProductDetails
//                {
//                    Product = productDetails.Product,
//                    ProductId = productDetails.ProductId,
//                    GamesList = new SelectList(EntityRepository.Games.Select(g => g.GameName), productDetails.SelectedGame ?? "Select Game"),
//                    CategoriesList = new SelectList(EntityRepository.Games.Where(g => productDetails.SelectedGame == null || g.GameName == productDetails.SelectedGame).SelectMany(g => g.ProductCategory).Select(p => p.ProductCategoryName), productDetails.SelectedCategory ?? "Select Category"),
//                    MetaTagTitleList = new SelectList(EntityRepository.SEOs.Select(s => s.MetaTagTitle), productDetails.SelectedMetaTagTitle ?? "Select Meta tag title from List"),
//                    ProductOptions = productDetails.ProductOptions,
//                    ProductName = productDetails.ProductName,
//                    InStock = productDetails.InStock,
//                    PreOrder = productDetails.PreOrder,
//                    ProductEnabled = productDetails.ProductEnabled,
//                    ProductQuantity = productDetails.ProductQuantity,
//                    ProductImageThumb = productDetails.ProductImageThumb,
//                    ProductImage = productDetails.ProductImage,
//                    ProductPriority = productDetails.ProductPriority,
//                    ProductPriceEU = productDetails.ProductPriceEU,
//                    ProductPriceUS = productDetails.ProductPriceUS,
//                    ProductSaleEU = productDetails.ProductSaleEU,
//                    ProductSaleUS = productDetails.ProductSaleUS,
//                    Description = productDetails.Description,
//                    SubDescriptionTitle1 = productDetails.SubDescriptionTitle1,
//                    SubDescription1 = productDetails.SubDescription1,
//                    SubDescriptionTitle2 = productDetails.SubDescriptionTitle2,
//                    SubDescription2 = productDetails.SubDescription2,
//                    SubDescriptionTitle3 = productDetails.SubDescriptionTitle3,
//                    SubDescription3 = productDetails.SubDescription3,
//                    SubDescriptionTitle4 = productDetails.SubDescriptionTitle4,
//                    SubDescription4 = productDetails.SubDescription4,
//                    SubDescriptionTitle5 = productDetails.SubDescriptionTitle5,
//                    SubDescription5 = productDetails.SubDescription5,
//                });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveProductOption(ProductOptionsViewModel productOptionViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                List<Guid> userOptionIds = new List<Guid>();
//                foreach (var productOptionDetails in productOptionViewModel.ProductOptions)
//                {
//                    if (productOptionDetails.OptionParent == "Empty")
//                        productOptionDetails.OptionParent = null;

//                    productOptionDetails.OptionProductId = productOptionViewModel.ProductId;
//                    EntityRepository.SaveProductOption(productOptionDetails);
//                    userOptionIds.Add(productOptionDetails.OptionId);
//                }
//                var dbOptionIds = EntityRepository.ProductOptions.Where(p => p.OptionProductId == productOptionViewModel.ProductId).Select(o => o.OptionId);

//                foreach(var optId in dbOptionIds)
//                {
//                    if (!userOptionIds.Contains(optId))
//                    {
//                        Remove(optId, "ProductOption");
//                    }
//                }

//                try
//                {
//                    EntityRepository.SaveContextAsync();
//                }
//                catch(Exception ex)
//                {
//                    TempData["message"] = string.Format(ex.Message);
//                }
//                finally
//                {
//                    TempData["message"] = string.Format("Options has been saved");
//                }
//                return RedirectToAction("List", new { type = "Product" });

//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Product" });
//            }
//        }
//        [HttpPost]
//        [ValidateInput(false)]
//        public ActionResult SaveHtmlBlock(HtmlBlockDetails htmlBlockDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveHtmlBlock(htmlBlockDetails);
//                TempData["message"] = string.Format("HTML BLock has been saved");
//                return RedirectToAction("List", new { type = "HtmlBlocks" });
//            }
//            else
//            {
//                return View("SaveHtmlBlocks", htmlBlockDetails);
//            }
//        }
//        public ActionResult SaveProductCategory(ProductCategoryDetails productCategoryDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveProductCategory(productCategoryDetails);
//                TempData["message"] = string.Format("Product Category  has been saved");
//                return RedirectToAction("List", new { type = "ProductCategory" });
//            }
//            else
//            {
//                return View("List", productCategoryDetails);
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveTemplateOption(TemplateOptionDetails templateOptionDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveTemplateOption(templateOptionDetails);
//                TempData["message"] = string.Format("Template Option has been saved");
//                return RedirectToAction("List", new { type = "TemplateOptions" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "TemplateOptions" });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveSEO(SeoDetails seoDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveSEO(seoDetails);
//                TempData["message"] = string.Format("Seo has been saved");
//                return RedirectToAction("List", new { type = "SEO" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "SEO" });
//            }
//        }
//        [HttpPost]
//        [ValidateInput(false)]
//        public ActionResult SaveGame(ProductGameDetails productGameDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveGame(productGameDetails);
//                TempData["message"] = string.Format("Product Game Details has been saved");
//                return RedirectToAction("List", new { type = "ProductGame" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "ProductGame" });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveUsers(UsersDetails userDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveUsers(userDetails);
//                TempData["message"] = string.Format("User has been saved");
//                return RedirectToAction("List", new { type = "Users" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Users" });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveRanks(RankDetails rankDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveRanks(rankDetails);
//                TempData["message"] = string.Format("Ranks has been saved");
//                return RedirectToAction("List", new { type = "Ranks" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Ranks" });
//            }
//        }
//        [ValidateInput(false)]
//        public ActionResult SaveArticle(ArticleDetails ArticleDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveArticle(ArticleDetails);
//                TempData["message"] = string.Format("Article has been saved");
//                return RedirectToAction("List", new { type = "Article" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Article" });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveCustomers(CustomersDetails customers)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveCustomers(customers);
//                TempData["message"] = string.Format("Customers has been saved");
//                return RedirectToAction("List", new { type = "Customers" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Customers" });
//            }
//        }
//        [HttpPost]
//        public ActionResult SaveRoles(RolesDetails rolesDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveRoles(rolesDetails);
//                TempData["message"] = string.Format("Roles has been saved");
//                return RedirectToAction("List", new { type = "Roles" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Roles" });
//            }
//        }
//        public ActionResult SaveOrders(OrderDetails orderDetails)
//        {
//            if (ModelState.IsValid)
//            {
//                EntityRepository.SaveOrders(orderDetails);
//                TempData["message"] = string.Format("Orders has been saved");
//                return RedirectToAction("List", new { type = "Orders" });
//            }
//            else
//            {
//                return RedirectToAction("List", new { type = "Orders" });
//            }
//        }
//        #endregion
//        public ActionResult Remove(Guid Id, string type)
//        {
//            switch (type)
//            {
//                case "Product":
//                    EntityRepository.RemoveProduct(Id);
//                    break;
//                case "TemplateOptions":
//                    EntityRepository.RemoveTemplateOption(Id);
//                    break;
//                case "ProductGame":
//                    EntityRepository.RemoveGame(Id);
//                    break;
//                case "HtmlBlocks":
//                    EntityRepository.RemoveHtmlBlock(Id);
//                    break;
//                case "SEO":
//                    EntityRepository.RemoveSEO(Id);
//                    break;
//                case "Users":
//                    EntityRepository.RemoveUsers(Id);
//                    break;
//                case "Ranks":
//                    EntityRepository.RemoveRanks(Id);
//                    break;
//                case "Customers":
//                    EntityRepository.RemoveCustomers(Id);
//                    break;
//                case "Roles":
//                    EntityRepository.RemoveRoles(Id);
//                    break;
//                //case "Orders":
//                //    EntityRepository.RemoveOrders(Id);
//                //    break;
//                case "ProductOption":
//                    EntityRepository.RemoveProductOption(Id);
//                    break;
//                case "ProductCategory":
//                    EntityRepository.RemoveProductCategory(Id);
//                    break;
//                case "ProductSubCategory":
//                    EntityRepository.RemoveProductSubCategory(Id);
//                    break;
//            }
//            return RedirectToAction("List", new { type = type });
//        }
//        [HttpPost]
//        public string Upload()
//        {
//            var file = Request.Files[0];
//            if (file != null)
//            { 
//                var path = Request.Form[0];
//                var requiredFileName = Request.Form[1];
//                string extension = Path.GetExtension(file.FileName);
//                string endPath = Server.MapPath(path);

         
//                if (!Directory.Exists(endPath))
//                Directory.CreateDirectory(endPath);

//                if (System.IO.File.Exists(endPath + requiredFileName + extension))
//                System.IO.File.Delete(endPath + requiredFileName + extension);

//                file.SaveAs(endPath + @"/" + requiredFileName + extension);
            
//            return  path + @"/" + requiredFileName + extension;
//            }
//            return "";
//        }
//        #endregion
//    }
//}