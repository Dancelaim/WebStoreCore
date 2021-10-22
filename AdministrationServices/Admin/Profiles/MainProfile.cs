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
            CreateMap<DbProductPrice, Product>();
            CreateMap<DbProductCategory, Product>();
            CreateMap<DbProductGame, Product>();
            CreateMap<DbSeo, Product>();

            CreateMap<DbProductDescription, DescriptionResponse>();


            CreateMap<DbOrder, Order>();
            CreateMap<DbOrderCustomField, Order>();
            CreateMap<DbOrderProduct, Order>();
            CreateMap<DbCustomer, Order>();
        }
    }
}
