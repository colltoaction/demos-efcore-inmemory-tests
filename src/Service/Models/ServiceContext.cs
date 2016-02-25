using JetBrains.Annotations;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace Service.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
