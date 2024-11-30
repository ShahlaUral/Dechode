using Dechode.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.Entities.Concreats
{
    public class Activity : BaseEntitiy
    {
        public string Title { get; set; } 
        public string Description { get; set; } 
        public DateTime Date { get; set; } 
        public string ImageUrl { get; set; } 
        public string PartnerName { get; set; } 
        public string PartnerWebsite { get; set; } 
    }
}
