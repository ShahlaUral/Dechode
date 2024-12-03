using Dechode.Application.Repositories;
using Dechode.Domain.Entities.Abstracts;
using Dechode.Domain.Entities.Commons;
using Dechode.Persistance.DbContexts;
using Dechode.Persistance.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.Repositories
{
    public class ReadGenericRepository<T> : GenericRepository<T>,  IReadGenericRepository<T> where T : class,  IBaseEntity, new()
    {

        public ReadGenericRepository(DechodeDbContext context) 
            : base(context) 
        {
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return  _table;
        }

        public async Task<IQueryable<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
