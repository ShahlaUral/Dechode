using Dechode.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Application.Repositories
{
    public interface IWriteGenericRepository<T> where T : class, IBaseEntity, new()
    {
        Task AddAsync(T entity); 
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
