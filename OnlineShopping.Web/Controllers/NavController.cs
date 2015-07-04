using OnlineShopping.Domain.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Web.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;
        public NavController(IProductRepository repo)
        {
            repository = repo;
        }
       public PartialViewResult Menu(string category)
        {
            ViewBag.SelectedCategory = category; 
           IEnumerable<string> Categories = repository.Products
                                             .Select(x => x.Category)
                                             .Distinct()
                                             .OrderBy(x => x);

            return PartialView(Categories);
        }
    }
}