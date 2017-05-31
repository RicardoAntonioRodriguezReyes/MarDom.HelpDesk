using MarDom.Data.Entidades;
using MarDom.Services.Servicios.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarDom.Web.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
     
        // GET: Ticket
        TicketService servicio;
        public TicketController()
        {
            servicio =   new TicketService();
        }



        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Crear()
        {
            ViewBag.Secciones = servicio.ObtenerSeccionTickets().Data;
           

            List<tkProblemas> problemasDf = new List<tkProblemas>();
            problemasDf = servicio.ObtenerProblemasTickets().Data;

            List<tkCategoria> categoriasDf = new List<tkCategoria>();
            categoriasDf = servicio.ObtenerCategoriaTickets().Data;

            ViewBag.Categorias = categoriasDf;

            ViewBag.Problemas = problemasDf.Where(x=>x.CategoriaId ==1);
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Solicitud()
        {
            return View();
        }





    }
}