using System.Data.Entity;
using OnlineShopping.Domain.Entities;

namespace OnlineShopping.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
        {
			Database.SetInitializer(new EFDbContextInitializer());

        }
        public DbSet<Product> Products { get; set; }
    }
}
