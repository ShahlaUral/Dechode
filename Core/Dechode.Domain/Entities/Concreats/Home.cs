using Dechode.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Domain.Entities.Concreats
{
    public class Home : BaseEntitiy
    {
        public string? BannerTitle { get; set; } 
        public string? BannerSubtitle { get; set; } 
        public string? BannerImage { get; set; } 
    }
}
