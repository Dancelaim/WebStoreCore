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
        /// The method returns entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<T> Get<T>(Guid Id);

        /// <summary>
        /// The method returns Create or save a new entity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<bool> Save<T>(T request);

        /// <summary>
        /// The method returns Remove the entity by Id
        /// </summary>
        public Task<bool> Delete(Guid Id);

        /// <summary>
        /// The method returns a list of required entities
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        public Task<List<T>> GetList<T>(int skip, int qty);

        /// <summary>
        /// The method returns all found entities by name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Quantity"></param>
        public Task<List<T>> SearchFor<T>(string Name);
    }
}
