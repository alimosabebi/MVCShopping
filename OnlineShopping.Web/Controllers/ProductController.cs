using System.Linq;
using System.Web.Mvc;
using OnlineShopping.Domain.Abstract;
using OnlineShopping.Web.Models;

namespace OnlineShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where (p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                                 repository.Products.Count() :
                                 repository.Products.Where(c => c.Category == category ).Count() 
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
    
}