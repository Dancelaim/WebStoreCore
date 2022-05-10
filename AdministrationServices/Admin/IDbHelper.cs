using Admin.ApiModels.Request;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin
{
    public interface IDbHelper
    {
        /// <summary>
        /// The method returns one product by ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Product> GetProduct(Guid Id);
        /// <summary>
        /// The method returns Create a new product
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<int> CreateProduct(ProductRequest request);
        /// <summary>
        /// The method returns Product Update
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<int> UpdateProduct(ProductRequest request);
        /// <summary>
        /// The method returns Remove the selected product
        /// </summary>
        public Task<int> DeleteProduct(Guid ProductId);
        /// <summary>
        /// The method returns Remove the selected product
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        public Task<List<Product>> GetProducts(int skip, int qty);
        /// <summary>
        /// The method returns a list of descriptions for the selected product
        /// </summary>
        /// <param name="Id"></param>
        public Task<ProductDescription> GetDescriptionByProduct(Guid Id);
        /// <summary>
        /// The method returns products by searching by name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Quantity"></param>
        public Task<List<Product>> GetSearchMethodForProduct(string Name, int Quantity);
        /// <summary>
        /// The method returns Seo Update and Create
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public  Task<int> SaveSeo(SeoRequest request);
        public Task<int> CreateGame(ProductGameRequest request);

    }
}
