using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExercise.Models
{
    public class Basket
    {
        public IList<int> BasketContents { get; set; }

        public Basket()
        {
            BasketContents = new List<int>();
        }

        public void AddAlbumId(int id)
        {
            BasketContents.Add(id);
        }
    }
}