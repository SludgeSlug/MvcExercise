using MvcExercise.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExercise.Tests.Models.BasketTests
{
    [TestFixture]
    public class RemoveItem
    {
        [Test]
        public void should_remove_item_from_basket()
        {
            var item1 = new CdSearchResult
            {
                AlbumId = Guid.NewGuid(),
                Title = "Album 1"
            };

            var item2 = new CdSearchResult
            {
                AlbumId = Guid.NewGuid(),
                Title = "Album 2"
            };

            var basket = new Basket
            {
                BasketContents = new List<CdSearchResult> { item1, item2 }
            };

            var itemToRemove = new CdSearchResult
            {
                AlbumId = item1.AlbumId,
                Title = item1.Title
            };

            basket.RemoveItem(itemToRemove);

            Assert.That(basket.BasketContents.Count(), Is.EqualTo(1));
            Assert.That(basket.BasketContents[0], Is.EqualTo(item2));

        }
    }
}
