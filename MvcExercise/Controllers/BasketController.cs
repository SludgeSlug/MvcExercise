﻿using MvcExercise.Models;
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
            return View(GetBasket());
        }

        public ActionResult AddToBasket(CdSearchResult album)
        {
            var basket = GetBasket();
            basket.AddAlbum(album);
            SaveBasketInSession(basket);
            
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromBasket(CdSearchResult album)
        {
            var basket = GetBasket();
            basket.RemoveItem(album);
            SaveBasketInSession(basket);

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
