using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrnoMvc1.Web.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genres SelectGenres { get; set; }
        public string Desription { get; set; }
    }
}