using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.Web.Areas.Administration.Controllers
{
    public class AdminController : Controller
    {
        // GET: Administration/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}