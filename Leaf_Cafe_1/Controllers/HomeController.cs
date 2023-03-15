using Leaf_Cafe_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leaf_Cafe_1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Reservation()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Reservation1(Person person)
        {
            return View(person);
        }
    }
}
