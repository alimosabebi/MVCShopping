using System.Collections.Generic;
using System.Linq;

namespace OnlineShopping.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> CartLineCollection = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine line = CartLineCollection.Where(p => p.Product.ProductId == product.ProductId)
                            .FirstOrDefault();
            if (line == null)
            {
                CartLineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }

        }
        public void RemoveLine(Product product)
        {
            CartLineCollection.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }
        public decimal ComputeTotalValue()
        {
            return CartLineCollection.Sum(p => p.Product.Price * p.Quantity);
        }
        public IEnumerable<CartLine> Lines
        {
            get { return CartLineCollection; }
        }
        public void Clear()
        {
            CartLineCollection.Clear();
        }
    }
}
