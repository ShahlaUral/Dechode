using Dechode.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.Entities.Concreats
{
    public class ContactUs : BaseEntitiy
    {
        public string Address { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<ContactQuery> Queries { get; set; }
    }
    public class ContactQuery : BaseEntitiy
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;
        public bool IsReplied { get; set; } 
        public int ContactUsId { get; set; }
        public ContactUs ContactUs { get; set; }
    }
}
