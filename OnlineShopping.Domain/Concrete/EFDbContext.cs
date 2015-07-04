using OnlineShopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
