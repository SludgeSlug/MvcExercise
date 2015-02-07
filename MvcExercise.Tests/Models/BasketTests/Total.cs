using MvcExercise.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basket = MvcExercise.Models.Basket;

namespace MvcExercise.Tests.Models.BasketTests
{
    [TestFixture]
    public class Total
    {
        [Test]
        public void should_calculate_total_price_from_basket_contents()
        {
            var item1 = new CdSearchResult
            {
                Title = "Album 1",
                Price = 2
            };

            var item2 = new CdSearchResult
            {
                Title = "Album 2",
                Price = 3
            };

            var basket = new Basket();
            basket.AddAlbum(item1);
            basket.AddAlbum(item2);

            Assert.That(basket.Total, Is.EqualTo(5));
        }

        [Test]
        public void should_calculate_total_as_zero_when_nothing_is_in_the_basket()
        {
            var basket = new Basket();
            Assert.That(basket.Total, Is.EqualTo(0));
        }
    }
}
