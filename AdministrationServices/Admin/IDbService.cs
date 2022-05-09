﻿using Admin.ApiModels.Request;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin
{
    public interface IDbService
    {
        /// <summary>
        /// The method saves the modified Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Task ProductSave(Product product);
        /// <summary>
        /// The method saves the changed Description
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Task DescriptionSave(ProductDescription description);
        /// <summary>
        /// The method saves the changed Price
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public Task PriceSave(ProductPrice price);
        /// <summary>
        /// The method saves the changed Seo
        /// </summary>
        /// <param name="seo"></param>
        /// <returns></returns>
        public Task SeoSave(Seo seo);
        /// <summary>
        /// The method saves the changed ProductGame
        /// </summary>
        /// <param name="productgame"></param>
        /// <returns></returns>
        public Task GameSave(ProductGame productgame);
    }
}
