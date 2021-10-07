using App.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
