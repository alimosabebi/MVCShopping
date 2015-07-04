using System.Collections.Generic;
using OnlineShopping.Domain.Abstract;
using OnlineShopping.Domain.Entities;

namespace OnlineShopping.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {

        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
