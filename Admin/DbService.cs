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
            return await _context.Set<T>().Where(selector).ToListAsync();
        }

        public async Task<T> Get<T>(Guid id) where T : class, IBaseEntity, new()
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<T>> GetList<T>() where T : class, IBaseEntity, new()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Save<T>(T entity) where T : class, IBaseEntity,new()
        {
            var isNew = false;
            var dbEntity  =  await _context.Set<T>().FindAsync(entity);
            if (dbEntity == null) 
            { 
                isNew = true;
                dbEntity = new T();
            }
            _mapper.Map(entity, dbEntity);
            if (!isNew)
                _context.Set<T>().Update(dbEntity);
            _context.Set<T>().Add(dbEntity);
            return dbEntity;
        }

        public async Task Submit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
