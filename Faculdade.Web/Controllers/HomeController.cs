using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Faculdade.Business.Services;

namespace Faculdade.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Media = new ProvaAlunoService().ObterMedia();

            return View();
        }
    }
}