using Admin.ApiModels.Request;
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

namespace Admin.DbHelpers
{
    public class SeoDbHelper : IDbHelper
    {
        private readonly IDbService _dbService;
        private readonly WowCarryContext _context;
        private IMapper _mapper;
        public SeoDbHelper(WowCarryContext context, IMapper mapper, IDbService dbService)
        {
            _dbService = dbService;
            _mapper = mapper;
            _context = context;
        }

        public Task<bool> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get<T>(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetList<T>(int skip, int qty)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save<T>(T request)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> SearchFor<T>(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
