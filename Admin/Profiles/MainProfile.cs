using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Entities;
using Admin.Models;
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<DbProduct, Product>();
            CreateMap<Product, DbProduct>();

            CreateMap<DbProductPrice, Product>();
            CreateMap<DbProductCategory, Product>();
            CreateMap<DbProductGame, Product>();
            CreateMap<DbSeo, Product>();

            CreateMap<DbProductDescription, DescriptionResponse>();
            CreateMap<ProductDescription , DbProductDescription>();

            CreateMap<DbOrder, Order>();
            CreateMap<DbOrderCustomField, Order>();
            CreateMap<DbOrderProduct, Order>();
            CreateMap<DbCustomer, Order>();

            CreateMap<DbProductOption, ProductOption>();
            CreateMap<DbProductOptionParam, ProductOption>();

            CreateMap<DbTemplateOption, TemplateOption>();
            CreateMap<DbTempOptionParam, TemplateOption>();

            CreateMap<DbTempOptionParam, TempOptionParam>();

            CreateMap<ProductPrice, DbProductPrice>();
            CreateMap<ProductPrice,DbProduct>();
            CreateMap<ProductDescription, DbProduct>();

            CreateMap<Seo, DbSeo>();
            CreateMap<DbSeo, Seo>();    

            CreateMap<ProductGame ,DbProductGame>();
            CreateMap<DbProductGame , ProductGame>();  
        }
    }
}
