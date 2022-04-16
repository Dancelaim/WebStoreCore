using Admin.ApiModels.Request;
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
    public class DbService : IDbService
    {
        private readonly WowCarryContext _context;
        private IMapper _mapper;
        public DbService(WowCarryContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task ProductSave(Product product)
        {
            bool isNew = false;
            DbProduct dbProduct = await _context.Product.Where(p => p.Id == product.ProductId).FirstOrDefaultAsync();
            if(dbProduct == null) 
            { 
                isNew = true;
                dbProduct = new DbProduct(Guid.NewGuid());
            }
            _mapper.Map(product, dbProduct);
            if (!isNew)
                _context.Product.Update(dbProduct);
            _context.Product.Add(dbProduct);
            
        }
        public async Task DescriptionSave (ProductDescription description)
        {
            bool isNew = false;
            DbProductDescription dbDescription = await _context.ProductDescription.Where(d => d.Id == description.ProductDescriptionId).FirstOrDefaultAsync();
            if(dbDescription == null)
            {
                isNew= true;
                dbDescription = new DbProductDescription();
            }
            dbDescription =_mapper.Map(description, dbDescription);
            dbDescription.Id = Guid.NewGuid();
            if (!isNew)
                _context.ProductDescription.Update(dbDescription);
            _context.ProductDescription.Add(dbDescription);
        }

        public async Task PriceSave(ProductPrice price)
        {
            bool isNew = false;
            DbProductPrice dbProductPrice = await _context.ProductPrice.Where(p => p.ProductId == price.ProductId).FirstOrDefaultAsync();
            if(dbProductPrice == null)
            {
                isNew =true;
                dbProductPrice = new DbProductPrice();
            }
            _mapper.Map(price, dbProductPrice);
            if(!isNew) 
                _context.ProductPrice.Update(dbProductPrice);
            _context.ProductPrice.Add(dbProductPrice);

        }
    }
}
