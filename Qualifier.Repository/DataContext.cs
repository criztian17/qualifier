using Microsoft.EntityFrameworkCore;
using Qualifier.Repository.Entities;

namespace Qualifier.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TaxiEntity> Taxis { get; set; }
    }
}
