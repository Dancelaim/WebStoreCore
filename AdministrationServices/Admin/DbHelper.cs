﻿using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Entities;
using Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin
{
    public class DbHelper : IDbHelper
    {
        private readonly IDbService _dbService;
        private readonly WowCarryContext _context;
        private IMapper _mapper;
        public DbHelper(WowCarryContext context, IMapper mapper, IDbService dbService)
        {
            _dbService = dbService;
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<Product>> GetProducts(int skip, int qty)
        {
            return await _context.Product.Skip(skip).Take(qty).Select(p => new Product { ProductId = p.Id, ProductName = p.ProductName }).ToListAsync();
        }

        public async Task<Product> GetProduct(Guid Id)
        {
            var result = await _context.Product.Where(p => p.Id == Id).Select(p => new { p, p.ProductCategory, p.ProductSeo, p.ProductGame, p.ProductPrices }).FirstOrDefaultAsync();

            Product product = new Product();

            product = _mapper.Map<Product>(result.p);
            product = _mapper.Map(result.ProductPrices, product);
            product = _mapper.Map(result.ProductGame, product);
            product = _mapper.Map(result.ProductCategory, product);
            product = _mapper.Map(result.ProductSeo, product);

            return product;
        }
        public async Task<int> CreateProduct(ProductRequest request)
        {
            await _dbService.DescriptionSave(request.Description);

            await _dbService.PriceSave(request.Price);

            await _dbService.ProductSave(request.Product);

            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateProduct(ProductRequest request)
        {
            await _dbService.DescriptionSave(request.Description);

            await _dbService.PriceSave(request.Price);

            await _dbService.ProductSave(request.Product);

            return await _context.SaveChangesAsync();
        }
        public async Task<List<Product>> GetSearchMethodForProduct(string Name, int Quantity)
        {
            var products = await _context.Product.Take(Quantity).Where(c => c.ProductName.StartsWith(Name) || c.ProductName.Contains(Name) || c.ProductName.EndsWith(Name)).Select(p => new Product { ProductId = p.Id, ProductName = p.ProductName }).ToListAsync();
            return products;
        }
        public  async Task<int> DeleteProduct(Guid Id)
        {
            var result = await _context.Product.Where(p => p.Id == Id).FirstOrDefaultAsync();

            _context.Product.Remove(result);  

            return await _context.SaveChangesAsync();
        } 
        public async Task<ProductDescription> GetDescriptionByProduct(Guid Id)
        {
            var description = await _context.Product.Where(p => p.Id == Id).Select(p => p.ProductDescription).FirstOrDefaultAsync();
            var result = _mapper.Map<ProductDescription>(description);

            return result;
        }
    }
}
