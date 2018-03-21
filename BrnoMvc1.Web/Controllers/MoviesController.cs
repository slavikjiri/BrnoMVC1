using BrnoMvc1.Business.Extension;
using BrnoMvc1.Business.Services;
using BrnoMvc1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IEmailService emailService;

        public List<MovieViewModel> Models { get; set; }

        public List<MovieViewModel> MovieViewModel { get; set; } = new List<Web.Models.MovieViewModel>();
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MoviesController(IEmailService emailService)
        {
            /*
            List<MovieViewModel> ListMovie = new List<MovieViewModel>();

            MovieViewModel movie = new MovieViewModel();
            movie.Id = 1;
            movie.Title = "Homer";
            movie.SelectGenres = Genres.Comedy;
            movie.Desription = "Moc pěkný film";

            ListMovie.Add(movie);

            movie = new MovieViewModel();
            movie.Id = 2;
            movie.Title = "ScaryMovie";
            movie.Desription = "Nedívat";
            movie.SelectGenres = Genres.Horror;

            ListMovie.Add(movie);

            Models = ListMovie;*/


            using (var context = new ApplicationDbContext())
            {
                this.Movies = context.Movies.ToList();
            }


            var movie = new Movie { Id = 20, Title = "Test" };
            var movieViewModel = new MovieViewModel();

            Models = AutoMapper.Mapper.Map<List<Movie>, List<MovieViewModel>>(this.Movies);
            this.emailService = emailService;
        }

        public ActionResult _Grid()
        {
            return PartialView(Models);
        }


        // GET: Movies
        public ActionResult Index()
        {

            //Business.Services.EmailService es = new Business.Services.EmailService();
            //es.Send("Hello world");
            this.emailService.Send("Hello world");


            //BrnoMvc1.Business.XmlActionResult ar = new Business.XmlActionResult(movie);

            //return this.Json(movie, JsonRequestBehavior.AllowGet);
            //return this.Xml(Models);

            ViewBag.Nadpis = "Pěkný nadpis";

            ViewData["Dict"] = "Pěkný nadpis 2";

            TempData["Dict3"] = "Pěkný nadpis 3";

            TempData["Error"] = "chyba";


            /*

            if (true)
            {
                //Response.Redirect("/Home/About", true);
                return this.RedirectToAction("About");
            }

            */

            return View(Models);
        }

        public ActionResult Details(int Id)
        {
            //BrnoMvc1.Business.XmlActionResult ar = new Business.XmlActionResult(movie);

            //return this.Json(movie, JsonRequestBehavior.AllowGet);
            //return this.Xml(Models);
            //MovieModels movie = new MovieModels();
            //movie.Id = Models[Id].Id;
            //movie.Title = Models[Id].Title;
            //movie.SelectGenres = Models[Id].SelectGenres;
            //movie.Desription = Models[Id].Desription;


            var result = this.Models.Find(x => x.Id == Id);


            return View(result);
        }


        public ActionResult Released(int year, int month)
        {
            return this.Content(year.ToString()+ " " + month.ToString());
        }



        public ActionResult Create()
        {
            MovieViewModel movie = new MovieViewModel();
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(MovieViewModel movie)
        {
            if (this.ModelState.IsValid)
            { 
                return this.Json(movie, JsonRequestBehavior.AllowGet);
            }
            return View(movie);
        }


        public ActionResult CreateMovies()
        {
            return View(Models);
        }


        [HttpPost]
        public ActionResult CreateMovies(List<MovieViewModel> movies)
        {
            if (this.ModelState.IsValid)
            {
                return this.Json(movies, JsonRequestBehavior.AllowGet);
            }
            return View(movies);
        }

    }
}