﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExercise.Models
{
    public class CdSearchResult
    {
        public int AlbumId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}