using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}
        // 
        // GET: /HelloWorld/ 
        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                     name: "Hello",
                     url: "{controller}/{action}/{name}/{id}"
                 );
            }
        }
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string Priya, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + Priya + ", ID: " + ID);
        }
    }
}