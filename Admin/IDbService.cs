using Admin.ApiModels.Request;
using Admin.Base;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        public Task<Guid> Save<T>(T entity) where T : class, IBaseEntity, new();
        public Task<T> Get<T>(Guid id) where T : class, IBaseEntity, new();
        public Task<List<T>> GetList<T>(int skip, int qty) where T : class, IBaseEntity, new();
        public Task<bool> Delete<T>(Guid id) where T : class, IBaseEntity, new();
        public Task<bool> Archive<T>(Guid id) where T : class, IBaseEntity, new();
        public Task<List<T>> Find<T>(Expression<Func<T, bool>> selector) where T : class, IBaseEntity, new();
    }
}
