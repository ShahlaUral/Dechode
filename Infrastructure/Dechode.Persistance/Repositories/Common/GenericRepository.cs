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
    public class GenericRepository<T> : IGenericRepository<T> where T : class,  IBaseEntity, new()
    {
        protected readonly DechodeDbContext _dbContext;
        protected DbSet<T> _table;

        public GenericRepository(DechodeDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }
    }
}
