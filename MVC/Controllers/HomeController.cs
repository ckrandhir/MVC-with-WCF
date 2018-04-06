using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using MVC.Models;
using System.Data.Entity;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            // DataAccess d = new DataAccess();         
            //int x=   d.GetCustomerAndOrders("VINET");
            //   db.Categories.ToList()
            var x = db.Categories.ToList();
            

            return View(db.Categories.ToList());
        }

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
    }
}