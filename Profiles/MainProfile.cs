using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WowCarryCore.Models;

namespace WowCarryCore.Profiles
{
    public class MainProfile : Profile
		{
			public MainProfile()
			{
				CreateMap<ProductDetails, Product>();
				CreateMap<Product, ProductDetails>();

				CreateMap<ProductDetails, ProductDescription>();
				CreateMap<ProductDescription, ProductDetails>();

				CreateMap<ProductDetails, ProductPrice>();
				CreateMap<ProductPrice, ProductDetails>();
		}
	}
}

