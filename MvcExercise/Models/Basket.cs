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

        public void AddAlbum(CdSearchResult album)
        {
            BasketContents.Add(album);
        }
    }
}