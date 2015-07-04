using System.Collections.Generic;
using OnlineShopping.Domain.Entities;

namespace OnlineShopping.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

    }
}
