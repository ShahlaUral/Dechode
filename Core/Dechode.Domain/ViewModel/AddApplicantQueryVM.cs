using Dechode.Domain.Entities.Concreats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.ViewModel
{
    public class AddApplicantQueryVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;
        public bool IsReplied { get; set; }
        public int ContactUsId { get; set; }
        public ContactUs ContactUs { get; set; }
    }
}
