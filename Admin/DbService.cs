using Admin.ApiModels.Request;
using Admin.Base;
using Admin.Core;
using Admin.Entities;
using Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        //Use only for Uber Admin
        public async Task<bool> Delete<T>(Guid id) where T : class, IBaseEntity, new()
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(e=>e.Id==id);
            if(entity is null)
                return false;
            _context.Remove(entity);
            return true;
        }
        public async Task<List<T>> Find<T>(Expression<Func<T, bool>> selector) where T : class, IBaseEntity, new()
        {
            return await _context.Set<T>().Where(selector).Where(e => !e.IsArchive).ToListAsync();
        }
        public async Task<T> Get<T>(Guid id) where T : class, IBaseEntity, new()
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<List<T>> GetList<T>(int skip, int qty) where T : class, IBaseEntity, new()
        {
            return await _context.Set<T>().Where(e=>!e.IsArchive).Skip(skip).Take(qty).ToListAsync();
        }
        public async Task<Guid> Save<T>(T entity) where T : class, IBaseEntity, new()
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
        async Task<bool> IDbService.Archive<T>(Guid id)
        {
            var dbEntity = await _context.Set<T>().FindAsync(id);
            dbEntity.IsArchive = true;
            _context.Set<T>().Update(dbEntity);
            return await _context.SaveChangesAsync() is 1;
        }
    }
}
