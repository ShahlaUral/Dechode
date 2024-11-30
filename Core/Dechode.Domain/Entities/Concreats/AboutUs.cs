using Dechode.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.Entities.Concreats
{
    public class AboutUs : BaseEntitiy
    {
        public string? Title { get; set; } 
        public string? Description { get; set; } 
        public string? Mission { get; set; } 
        public string? Vision { get; set; } 
        public ICollection<TeamMember>? TeamMembers { get; set; }
    }
    public class TeamMember : BaseEntitiy
    {
        public string? FullName { get; set; }
        public string? Position { get; set; } 
        public string? Bio { get; set; } 
        public string? ImageUrl { get; set; } 
        public int AboutUsId { get; set; }
        public AboutUs? AboutUs { get; set; }
    }
}
