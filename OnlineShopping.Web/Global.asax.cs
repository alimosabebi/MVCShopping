using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OnlineShopping.Domain.Entities;
using OnlineShopping.Web.Binders;

namespace OnlineShopping.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}
