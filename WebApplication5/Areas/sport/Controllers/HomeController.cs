using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Areas.sport.Controllers
{
    public class HomeController : Controller
    {
        // GET: sport/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}