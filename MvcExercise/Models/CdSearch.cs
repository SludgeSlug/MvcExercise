using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExercise.Models
{
    public class CdSearch
    {
        [Display(Name = "What do you want to sell?")]
        public string SearchTerm { get; set; }

        public IEnumerable<CdSearchResult> Results { get; set; }
    }
}