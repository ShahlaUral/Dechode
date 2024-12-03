using Dechode.Application.Repositories;
using Dechode.Domain.Entities.Concreats;
using Dechode.Persistance.DbContexts;
using Dechode.Persistance.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.Repositories
{
    public class WriteApplicantQueryRepository : WriteGenericRepository<ApplicantQuery> , IWriteApplicantQueryRepository
    {
        public WriteApplicantQueryRepository(DechodeDbContext context) : 
            base(context) 
        { 
        }
    }
}
