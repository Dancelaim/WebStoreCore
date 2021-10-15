using Admin.ApiModels.Response;
using Admin.Entities;
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
            CreateMap<Product, ProductResponse>();
            CreateMap<ProductPrice, ProductResponse>();
            CreateMap<ProductDescription, DescriptionResponse>();

        }
    }
}
