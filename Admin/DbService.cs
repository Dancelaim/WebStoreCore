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
                dbDescription = new DbProductDescription(Guid.NewGuid());
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
                dbProductPrice = new DbProductPrice(Guid.NewGuid());
            }
            _mapper.Map(price, dbProductPrice);
            if(!isNew) 
                _context.ProductPrice.Update(dbProductPrice);
            _context.ProductPrice.Add(dbProductPrice);

        }
        public async Task SeoSave(Seo seo)
        {
            bool isNew = false;
            DbSeo dbSeo = await _context.Seo.Where(p => p.Id == seo.Id).FirstOrDefaultAsync();
            if (dbSeo == null)
            {
                isNew=true;
                dbSeo = new DbSeo(Guid.NewGuid());
            }
            _mapper.Map(seo, dbSeo);
            if (isNew)
            {
                _context.Seo.Add(dbSeo);
                return;
            }  
            _context.Seo.Update(dbSeo);
            
        }
        public async Task GameSave(ProductGame productgame)
        {
            bool isNew = false;
            DbProductGame dbproductGame
                = await _context.ProductGame.Where(p => p.Id == productgame.ProductGameId).FirstOrDefaultAsync();
            if (dbproductGame == null)
            {
                isNew = true;
                dbproductGame = new DbProductGame(Guid.NewGuid());
            }
            _mapper.Map(productgame, dbproductGame);
            if (isNew)
            {
                _context.ProductGame.Add(dbproductGame);
                return;
            }
            _context.ProductGame.Update(dbproductGame);

        }
        public async Task CategorySave(ProductCategory category)
        {

        }

    }
}
