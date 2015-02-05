using MvcExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExercise.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Results(string searchTerm)
        {
            CdSearch searchModel = new CdSearch
            {
                SearchTerm = searchTerm,
                Results = GetSampleSearchResults()
            };
            return View(searchModel);
        }

        private static List<CdSearchResult> GetSampleSearchResults()
        {
            return new List<CdSearchResult>
                {
                    new CdSearchResult
                    {
                        AlbumId = 1,
                        Artist = "Black Sabbath",
                        Title = "Master of Reality",
                        Year = 1971
                    },
                    new CdSearchResult
                    {
                        AlbumId = 2,
                        Artist = "Saint Vitus",
                        Title = "Born Too Late",
                        Year = 1986
                    },
                    new CdSearchResult
                    {
                        AlbumId = 3,
                        Artist = "Slayer",
                        Title = "Seasons in the Abyss",
                        Year = 1990
                    }
                };
        }
    }
}
