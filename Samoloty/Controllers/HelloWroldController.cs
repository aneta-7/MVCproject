using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Samoloty.Controllers
{
    public class HelloWroldController : Controller
    {
        // GET: HelloWrold
        public ActionResult Index()
        {
            return View();
        }
    }
}