using Dechode.Application.Repositories;
using Dechode.Domain.Entities.Abstracts;
using Dechode.Domain.Entities.Commons;
using Dechode.Persistance.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.Repositories.Common
{
    public class WriteGenericRepository<T> : GenericRepository<T>,  IWriteGenericRepository<T> where T : class, IBaseEntity, new()
    {
        public WriteGenericRepository(DechodeDbContext context) : 
            base(context) 
        {
        }

        public async Task AddAsync(T entity)
        {
            _dbContext.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _table.FirstOrDefaultAsync(x => x.Id == id); 
            if (entity != null)
                _table.Remove(entity);
           
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _table.Update(entity);
        }
    }
}
