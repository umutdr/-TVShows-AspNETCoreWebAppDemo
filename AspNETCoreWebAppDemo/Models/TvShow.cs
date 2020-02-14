﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNETCoreWebAppDemo.Models
{
    public class TvShow
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public decimal Rating { get; set; }

        public string ImdbUrl { get; set; }
    }
}
