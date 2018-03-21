using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrnoMvc1.Web.Models
{
    public enum Genres {
        Comedy, Horror, Thiler
    };

    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vyplň název")]
        public string Title { get; set; }
        public Genres SelectGenres { get; set; }
        public string Desription { get; set; }

    }



}