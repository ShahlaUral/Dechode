using Dechode.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.Entities.Concreats
{
    public class Course : BaseEntitiy
    {
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string Duration { get; set; } 
        public decimal Price { get; set; }
        public string Level { get; set; } 
        public string ImageUrl { get; set; } 
    }
}
