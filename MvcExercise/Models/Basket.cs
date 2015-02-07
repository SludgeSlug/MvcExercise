using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExercise.Models
{
    public class Basket
    {
        public IList<CdSearchResult> BasketContents { get; set; }

        public Basket()
        {
            BasketContents = new List<CdSearchResult>();
        }

        public double Total
        {
            get
            {
                return BasketContents.Select(b => b.Price).Sum();
            }
        }

        public void AddAlbum(CdSearchResult album)
        {
            BasketContents.Add(album);
        }

        public void RemoveItem(CdSearchResult item)
        {            
            BasketContents = BasketContents.Where(b => b.AlbumId != item.AlbumId).ToList();
        }
    }
}