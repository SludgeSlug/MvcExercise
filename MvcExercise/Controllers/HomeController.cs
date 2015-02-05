using MvcExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CdSearch model)
        {
            return RedirectToAction(
                "Results", 
                "Search", 
                new { searchTerm = model.SearchTerm });
        }
    }
}
