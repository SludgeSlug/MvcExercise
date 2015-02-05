using MvcExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExercise.Controllers
{
    public class BasketController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToBasket(int id)
        {
            //TODO Add it to the shopping cart

            // Go back to the main store page for more searches
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult BasketSummary()
        {
            return PartialView("BasketSummary");
        }
    }
}
