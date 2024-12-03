﻿using Dechode.Application.Repositories;
using Dechode.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Application.Repositories
{
    public interface IReadGenericRepository<T> : IGenericRepository<T> where T : class,  IBaseEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync(); 
        Task<IQueryable<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id); 

    }
}
