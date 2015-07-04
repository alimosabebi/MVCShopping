using OnlineShopping.Domain.Entities;

namespace OnlineShopping.Web.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

    }
}