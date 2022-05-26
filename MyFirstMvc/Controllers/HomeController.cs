using MyFirstMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvc.Controllers
{
    public class HomeController : Controller
    {
         [HttpGet]
        public ActionResult Index()
        {
            Sample product = new Sample();
            product = product.GetProduct();
            return View(product);

        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            List<Sample> products = Sample.GetAllProducts();

            return View(products);
        }
       [NonAction]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}