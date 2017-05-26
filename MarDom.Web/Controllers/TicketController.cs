using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarDom.Web.Controllers
{
    public class TicketController : Controller
    {
        [Authorize]
        // GET: Ticket


       public ActionResult Index()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Solicitud()
        {
            return View();
        }
    }
}