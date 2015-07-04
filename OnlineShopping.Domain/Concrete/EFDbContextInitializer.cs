using System.Data.Entity;
using OnlineShopping.Domain.Entities;

namespace OnlineShopping.Domain.Concrete
{
    public class EFDbContextInitializer :
       DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            base.Seed(context);
            context.Products.Add(new Product { Name = "Football", Description = "Test test test test", Price = 23 , Category ="Men" });
            context.Products.Add(new Product { Name = "Surf Board", Description = "Test test test test", Price = 179, Category = "Men" });
            context.Products.Add(new Product { Name = "Running Shoes", Description = "Test test test test", Price = 79, Category = "Men" });
            context.Products.Add(new Product { Name = "Football2", Description = "Test test test test", Price = 23, Category = "Men" });
            context.Products.Add(new Product { Name = "Surf Board2", Description = "Test test test test", Price = 179, Category = "Women" });
                context.Products.Add(new Product { Name = "Running Shoes2", Description = "Test test test test", Price = 79, Category = "Men" });
                context.Products.Add(new Product { Name = "Football3", Description = "Test test test test", Price = 23, Category = "Men" });
                context.Products.Add(new Product { Name = "Surf Board3", Description = "Test test test test", Price = 179, Category = "Women" });
                context.Products.Add(new Product { Name = "Running Shoes3", Description = "Test test test test", Price = 79, Category = "Men" });
                context.Products.Add(new Product { Name = "Football4", Description = "Test test test test", Price = 23, Category = "Women" });
                context.Products.Add(new Product { Name = "Surf Board4", Description = "Test test test test", Price = 179, Category = "Men" });
                context.Products.Add(new Product { Name = "Running Shoes4", Description = "Test test test test", Price = 79, Category = "Women" });
                context.Products.Add(new Product { Name = "Football5", Description = "Test test test test", Price = 23, Category = "Men" });
                context.Products.Add(new Product { Name = "Surf Board5", Description = "Test test test test", Price = 179, Category = "Women" });
                


            
            
        }
    }
}
