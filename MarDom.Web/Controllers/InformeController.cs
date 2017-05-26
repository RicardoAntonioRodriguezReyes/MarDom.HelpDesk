using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarDom.Web.Controllers
{
    public class InformeController : Controller
    {
        [Authorize]
        // GET: Informe
        public ActionResult Index()
        {
            return View();
        }
    }
}