using NewsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApplication.Controllers
{
    public class HomeController : Controller
    {
        NewsRepository repo = new NewsRepository();

        public ActionResult Index()
        {
            var Model = repo.GetAllNews();
            return View(Model);
        }

        /*public ActionResult Create()
        {
            return View();
        }*/
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       [HttpGet]
        public ActionResult Create()
        {
            News model = new News();
            return View(model);
        }
        
       [HttpPost]
       public ActionResult Create(News s)
       {
           return View();
       }
    }
}