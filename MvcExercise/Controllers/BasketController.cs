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
        private const string BASKET_SESSION_KEY = "BasketKey";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToBasket(int id)
        {
            var basket = GetBasket();
            basket.AddAlbumId(id);
            SaveBasketInSession(basket);
            // Go back to the main store page for more searches
            return RedirectToAction("Index");
        }        

        [ChildActionOnly]
        public ActionResult BasketSummary()
        {
            var basket = GetBasket();

            ViewData["BasketCount"] = basket.BasketContents.Count();
            return PartialView("BasketSummary");
        }

        private void SaveBasketInSession(Basket basket)
        {
            Session[BASKET_SESSION_KEY] = basket;
        }

        private Basket GetBasket()
        {
            var basket = Session[BASKET_SESSION_KEY];
            if (basket != null)
            {
                return (Basket)basket;
            }

            return new Basket();
        }
    }
}
