using Dechode.Application.Repositories;
using Dechode.Application.Services;
using Dechode.Domain.Entities.Concreats;
using Dechode.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.Services
{
    public class ApplicantQueryService : IApplicantQueryService
    {
        private readonly IWriteApplicantQueryRepository _writeApplicantQueryRepo;

        public async Task AddAplicantQuery(AddApplicantQueryVM addApplicantQuery)
        {
            var applicantQuery = new ApplicantQuery()
            {
                FullName = addApplicantQuery.FullName,
                ContactUs = addApplicantQuery.ContactUs,
                Message = addApplicantQuery.Message,
                ContactUsId = addApplicantQuery.ContactUsId,
                Email = addApplicantQuery.Email,
                IsReplied = false,
                SentAt = addApplicantQuery.SentAt
            };

            await _writeApplicantQueryRepo.AddAsync(applicantQuery);
            await _writeApplicantQueryRepo.SaveChangesAsync();
        }
    }
}
