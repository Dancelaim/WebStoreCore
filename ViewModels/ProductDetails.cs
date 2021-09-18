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

public class ProductDetails
{
    public ProductDetails() { }
    #region Properties
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    //public ICollection<ProductOptions> ProductOptions { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; }

    [Display(Name = "In Stock")]
    public bool InStock { get; set; }

    public bool PreOrder { get; set; }

    [Display(Name = "Status")]
    public bool ProductEnabled { get; set; }

    [Display(Name = "Product Quantity")]
    public int? ProductQuantity { get; set; }

    [Display(Name = "Image Thumbnail")]
    public string ProductImageThumb { get; set; }

    [Display(Name = "Large Image")]
    public string ProductImage { get; set; }

    [Display(Name = "Sort Order")]
    public int? ProductPriority { get; set; }

    #region DropDownLists
    //[Display(Name = "Template Options")]
    //public SelectList TemplateOptionsList { get; set; }
    //public string SelectedTemplateOption { get; set; }

    [Display(Name = "Game name")]
    public SelectList GamesList { get; set; }
    [Required(ErrorMessage = "Product Game is required")]
    public string SelectedGame { get; set; }

    [Display(Name = "Category name")]
    public SelectList CategoriesList { get; set; }
    [Required(ErrorMessage = "Product  Category is required")]
    public string SelectedCategory { get; set; }

    [Display(Name = "Meta tag title")]
    public SelectList MetaTagTitleList { get; set; }
    public string SelectedMetaTagTitle { get; set; }
    #endregion

    //[Display(Name = "SubCategory name")]
    //public string ProductSubCategoryName { get; set; }

    [Display(Name = "EU Price")]
    public decimal? EuPrice { get; set; }

    [Display(Name = "US Price")]
    public decimal? UsPrice { get; set; }

    [Display(Name = "EU Sale")]
    public decimal? EuSale { get; set; }

    [Display(Name = "US Sale")]
    public decimal? UsSale { get; set; }

    [Display(Name = "Product Description")]
    public string Description { get; set; }

    [Display(Name = "Product SubDescription Title 1")]
    public string SubDescriptionTitle1 { get; set; }

    [Display(Name = "Product SubDescription 1")]
    public string SubDescription1 { get; set; }

    [Display(Name = "Product SubDescription Title 2")]
    public string SubDescriptionTitle2 { get; set; }

    [Display(Name = "Product SubDescription 2")]
    public string SubDescription2 { get; set; }

    [Display(Name = "Product SubDescription Title 3")]
    public string SubDescriptionTitle3 { get; set; }

    [Display(Name = "Product SubDescription 3")]
    public string SubDescription3 { get; set; }

    [Display(Name = "Product SubDescription Title 4")]
    public string SubDescriptionTitle4 { get; set; }

    [Display(Name = "Product SubDescription 4")]
    public string SubDescription4 { get; set; }

    [Display(Name = "Product SubDescription Title 5")]
    public string SubDescriptionTitle5 { get; set; }

    [Display(Name = "Product SubDescription 5")]
    public string SubDescription5 { get; set; }
    #endregion
}
