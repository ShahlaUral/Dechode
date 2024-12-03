using Dechode.Application.Repositories;
using Dechode.Domain.Entities.Concreats;
using Dechode.Persistance.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.Repositories
{
    public class ReadApplicantQueryRepository : ReadGenericRepository<ApplicantQuery>, IReadApplicantQueryRepository
    {
        public ReadApplicantQueryRepository(DechodeDbContext context) : 
            base(context) 
        {
        }
    }
}
