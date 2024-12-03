using Dechode.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Application.Services
{
    public interface IApplicantQueryService
    {
        Task AddAplicantQuery(AddApplicantQueryVM addApplicantQuery);
    }
}
