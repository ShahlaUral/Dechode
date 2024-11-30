using Dechode.Domain.Entities.Concreats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance.DbContexts
{
    public class DechodeDbContext : DbContext
    {
        public DechodeDbContext(DbContextOptions<DechodeDbContext> options) : base
            (options) { }


        public class DechodeDbContextFactory : IDesignTimeDbContextFactory<DechodeDbContext>
        {
            public DechodeDbContext CreateDbContext(string[] args)
            {
                // Presentation qatının yolunu göstərin
                var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Dechode.WebApp");
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var optionsBuilder = new DbContextOptionsBuilder<DechodeDbContext>();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));

                return new DechodeDbContext(optionsBuilder.Options);
            }
        }

        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<AboutUs> AboutUsPages { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<ContactUs> ContactUsPages { get; set; }
        public virtual DbSet<ContactQuery> ContactQueries { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
    }
}
